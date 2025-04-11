using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SuWar3ToolsExt
{
    public class ExtLogic
    {
        #region 在这里实现自己的逻辑

        /// <summary>
        /// 设置程序超时秒数，本程序运行总时长超过此值时自动退出
        /// </summary>
        /// <returns></returns>
        public static int GetTimeOutSecond()
        {
            return 20;
        }

        /// <summary>
        /// 设置提示文案，当手动点击情况下(未检测到输入参数时)会显示此提示内容
        /// </summary>
        /// <returns></returns>
        public static string GetTipMsgWhenHasNoArgs()
        {
            return "本程序为11平台总胜率查询，在进入游戏后调用扩展控制台程序即可\n在SuWar3Tools里添加时需填入参数，格式为“类型 11账号 11密码”，其中类型参数为：1:Dota 2:IMBA 3:OMG 4:真三 5:IM起源 6:信长 7:IMCA 8:OMG起源";
        }

        /// <summary>
        /// 复制本代码文件替换“SuWar3ToolsExt\ExtLogic.cs”后编译生成程序即可使用
        /// </summary>
        /// <param name="launchArgs">程序启动参数</param> 
        /// <param name="inputArgs">由SuWar3Tools生成的Json文本参数</param> 
        /// <param name="outputArgs">输出的参数，将由SuWar3Tools进行处理</param>
        /// <returns></returns>
        public static async Task<ExtOutputArgs> ProcessLogic(string[] launchArgs, ExtInputArgs inputArgs, ExtOutputArgs outputArgs)
        {
            try
            {
                List<string> names = new List<string>();
                inputArgs.Joiners?.ForEach(n => names.Add(n.Name));
                inputArgs.Players?.ForEach(n => names.Add(n.Name));
                string gameType = launchArgs != null && launchArgs.Length > 0 ? launchArgs[0] : "1";
                string userName = launchArgs != null && launchArgs.Length > 1 ? launchArgs[1] : "";
                string passWord = launchArgs != null && launchArgs.Length > 2 ? launchArgs[2] : "";
                string tryCount = launchArgs != null && launchArgs.Length > 3 ? launchArgs[3] : "3";
                int retryCount = 3;
                int.TryParse(tryCount, out retryCount);
                if (string.IsNullOrEmpty(gameType) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
                    throw new Exception("请配置账号和密码");
                List<Cookie> cookies = GetCookies();
                if (cookies == null || cookies.Count < 1)
                {
                    LoginResult loginResult = await GetLoginResultAsync(userName, passWord);
                    if (loginResult == null || loginResult.code != 1 || loginResult.data == null)
                        throw new Exception("账号登录失败" + (loginResult != null && !string.IsNullOrEmpty(loginResult.msg) ? ("：" + loginResult.msg) : ""));
                    cookies = await GetPassCookieAsync(loginResult.data);
                }
                if (cookies == null || cookies.Count < 1)
                    throw new Exception("获取Cookie失败");
                //outputArgs.Msg = GetGameTypeDesc(gameType) + "天梯：";
                //批量查询11天梯胜率
                names.RemoveAll(n => n == "蜀国" || n == "魏国" || n == userName);
                if (names.Count > 0)
                {
                    Task<TaskResult>[] tasks = new Task<TaskResult>[names.Count];
                    for (int i = 0; i < tasks.Length; i++)
                    {
                        tasks[i] = GetPlayData(gameType, names[i], cookies, retryCount);
                    }
                    Task.WaitAll(tasks);
                    List<TaskResult> results = new List<TaskResult>();
                    for (int i = 0; i < tasks.Length; i++)
                    {
                        results.Add(await tasks[i]);
                    }
                    bool existSuccess = results.Exists(n => n.success);
                    SaveCookies(existSuccess ? cookies : null);
                    for (int i = 0; i < results.Count; i++)
                    {
                        if ((!existSuccess || results[i].success) && !string.IsNullOrEmpty(results[i].result))
                        {
                            if (string.IsNullOrEmpty(outputArgs.Msg))
                                outputArgs.Msg = results[i].result;
                            else
                                outputArgs.Msg += "\n" + results[i].result;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(outputArgs.Msg))
                    outputArgs.Msg = outputArgs.Msg.Trim();
            }
            catch (Exception ex)
            {
                outputArgs.Msg = ex.Message;
            }
            return outputArgs;
        }

        static string GetGameTypeDesc(string gameType)
        {
            //游戏类型 1:Dota 2:IMBA 3:OMG 4:真三 5:IM起源 6:信长 7:IMCA 8:OMG起源
            string desc = "未知";
            switch (gameType)
            {
                case "1":
                    desc = "Dota";
                    break;
                case "2":
                    desc = "IMBA";
                    break;
                case "3":
                    desc = "OMG";
                    break;
                case "4":
                    desc = "真三";
                    break;
                case "5":
                    desc = "IM起源";
                    break;
                case "6":
                    desc = "信长";
                    break;
                case "7":
                    desc = "IMCA";
                    break;
                case "8":
                    desc = "OMG起源";
                    break;
            }
            return desc;
        }

        static async Task<LoginResult> GetLoginResultAsync(string userName, string passWord)
        {
            LoginResult logResult = new LoginResult();
            try
            {
                string result = "";
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(8);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    using (var content = new MultipartFormDataContent())
                    {
                        content.Add(new StringContent(userName), "user");
                        content.Add(new StringContent(passWord), "password");
                        //content.Add(new StringContent(""), "code");
                        //content.Add(new StringContent("7"), "srvid");
                        //content.Add(new StringContent("false"), "alive");
                        var response = await client.PostAsync("https://olpassport.5211game.com/Login/Login", content);
                        result = await response.Content.ReadAsStringAsync();
                    }
                }
                if (!string.IsNullOrEmpty(result))
                    logResult = Program.ParseJson<LoginResult>(result);
            }
            catch (Exception ex)
            {
                logResult.msg = ex.Message;
            }
            return logResult;
        }

        static async Task<List<Cookie>> GetPassCookieAsync(UserInfo userInfo)
        {
            try
            {
                List<Cookie> result = null;
                Uri uri = new Uri("http://record.5211game.com/Web/Passport?returnurl=http%3A%2F%2Frecord.5211game.com%3A80%2FWeb%2FRecord%2FIndex&st=" + userInfo.st);
                CookieContainer cookieContainer = new CookieContainer();
                var handler = new HttpClientHandler();
                handler.CookieContainer = cookieContainer;
                using (var client = new HttpClient(handler))
                {
                    client.Timeout = TimeSpan.FromSeconds(8);
                    var response = await client.GetAsync(uri);
                    result = cookieContainer.GetCookies(uri).Cast<Cookie>().ToList();
                }
                return result;
            }
            catch
            {
                return null;
            }
        }

        static async Task<TaskResult> GetPlayData(string gameType, string username, List<Cookie> cookies, int retryCount)
        {
            TaskResult result = new TaskResult();
            int count = retryCount > 1 ? retryCount : 1;
            for (int i = 1; i <= count; i++)
            {
                result = await GetPlayData(gameType, username, cookies);
                if (result.success || i == count)
                    break;
            }
            return result;
        }

        static async Task<TaskResult> GetPlayData(string gameType, string username, List<Cookie> cookies)
        {
            try
            {
                string GameTypeID = string.IsNullOrEmpty(gameType) ? "1" : gameType;
                TaskResult result = new TaskResult();
                CookieContainer cookieContainer = new CookieContainer();
                var handler = new HttpClientHandler();
                handler.CookieContainer = cookieContainer;
                cookies?.ForEach((cookie) => cookieContainer.Add(cookie));
                using (var client = new HttpClient(handler))
                {
                    client.Timeout = TimeSpan.FromSeconds(8);
                    var response = await client.GetAsync("http://record.5211game.com/Web/Search/Index?u=" + username + "&t=10001");
                    var query = response.RequestMessage.RequestUri.Query;
                    string uid = "";
                    uid = query.Substring(query.IndexOf("userid=") + 7);
                    uid = uid.Substring(0, uid.IndexOf("&"));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    using (var content = new MultipartFormDataContent())
                    {
                        content.Add(new StringContent("getrecord"), "method");
                        content.Add(new StringContent(uid), "u");
                        content.Add(new StringContent("1000" + gameType), "t");
                        response = await client.PostAsync("http://record.5211game.com/Web/RecordRequest/record", content);
                        string json = await response.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(json))
                        {
                            GameResult gameResult = Program.ParseJson<GameResult>(json);
                            if (gameResult.ttInfos != null)
                            {
                                result.success = true;
                                result.result = "[" + username + "]积分:" + gameResult.rating + " 胜率:" + gameResult.ttInfos.Win * 100 / gameResult.ttInfos.Total + "% 总场次:" + gameResult.ttInfos.Total + " 逃跑率:" + gameResult.ttInfos.OfflineFormat;
                            }
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return new TaskResult() { result = ex.Message };
            }
        }

        static void SaveCookies(List<Cookie> cookies)
        {
            try
            {
                string runPath = Assembly.GetEntryAssembly().Location;
                string cookieFile = Path.Combine(Path.GetDirectoryName(runPath), Path.GetFileNameWithoutExtension(runPath) + ".cache");
                if (cookies == null || cookies.Count < 1)
                {
                    if (File.Exists(cookieFile))
                        File.Delete(cookieFile);
                }
                else
                {
                    cookies?.ForEach((item) =>
                    {
                        if (item.Expires.Ticks <= 0)
                            item.Expires = DateTime.MaxValue;
                    });
                    Program.SaveTextToFile(Program.GetJson(cookies), cookieFile);
                }
            }
            catch { }
        }

        static List<Cookie> GetCookies()
        {
            try
            {
                string runPath = Assembly.GetEntryAssembly().Location;
                string cookieFile = Path.Combine(Path.GetDirectoryName(runPath), Path.GetFileNameWithoutExtension(runPath) + ".cache");
                if (File.Exists(cookieFile))
                {
                    var cookies = Program.ParseJson<List<Cookie>>(Program.GetTextFromFile(cookieFile));
                    if (cookies != null && cookies.Count > 0)
                        return cookies;
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public class TaskResult
        {
            public TaskResult()
            {
                success = false;
                result = "";
            }
            public bool success { get; set; }
            public string result { get; set; }
        }

        public class LoginResult
        {
            public int code { get; set; }
            public string msg { get; set; }
            public UserInfo data { get; set; }
        }

        public class UserInfo
        {
            public long userId { get; set; }
            public string userName { get; set; }
            public string st { get; set; }
        }

        public class GameResult
        {
            public int error { get; set; }
            public int rating { get; set; }
            public TTInfo ttInfos { get; set; }
        }

        public class TTInfo
        {
            public int Total { get; set; }
            public int Win { get; set; }
            public int Lost { get; set; }
            public string OfflineFormat { get; set; }
        }

        #endregion
    }
}