using System;
using System.Collections.Generic;
using System.Net.Http;
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
            return "本程序为09平台总胜率查询，在进入游戏后调用扩展控制台程序即可\n在SuWar3Tools里添加时不填参数时默认为“1”，其它可选参数为1:Dota  2:IM觉醒 21:OMG";
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
                if (string.IsNullOrEmpty(gameType))
                    gameType = "1";
                outputArgs.Msg = GetGameTypeDesc(gameType) + "胜率->";
                //下面以批量查询09战绩为例
                if (names.Count > 0)
                {
                    Task<string>[] tasks = new Task<string>[names.Count];
                    for (int i = 0; i < tasks.Length; i++)
                    {
                        tasks[i] = GetPlayData(gameType, names[i]);
                    }
                    Task.WaitAll(tasks);
                    for (int i = 0; i < tasks.Length; i++)
                    {
                        string result = await tasks[i];
                        if (!string.IsNullOrEmpty(result))
                            outputArgs.Msg += result + " ";
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
            //游戏类型 1:Dota  2:IM觉醒 21:OMG
            string desc = "未知";
            switch (gameType)
            {
                case "1":
                    desc = "Dota";
                    break;
                case "2":
                    desc = "IM";
                    break;
                case "21":
                    desc = "OMG";
                    break;
            }
            return desc;
        }

        static async Task<string> GetPlayData(string gameType, string username)
        {
            try
            {
                string GameTypeID = string.IsNullOrEmpty(gameType) ? "1" : gameType;
                string result = "";
                string json = await new HttpClient().GetStringAsync("http://users.09game.com/home/GetUserPub?user_name='" + username + "'");
                UserInfo userInfo = Program.ParseJson<UserInfo>(json);
                int user_id = userInfo.temp[0].user_id;
                json = await new HttpClient().GetStringAsync("http://score.09game.com/Ordinary/SeasonSummary?UserID=" + user_id + "&GameTypeID=" + GameTypeID);
                var summary = Program.ParseJson<SeasonSummary>(json);
                //名字就只取第1个字符了，因为多了显示不下，如果要全显示就自己改代码做分行处理
                result = "[" + username.Substring(0, 1) + "]" + ((summary.data.free[0].total_win + summary.data.season[0].total_win) * 100 / (summary.data.free[0].total_times + summary.data.season[0].total_times)) + "%";
                return result;
            }
            catch
            {
                return "";
            }
        }

        public class UserInfo
        {
            public int result { get; set; }
            public List<UserInfo_temp> temp { get; set; }
        }

        public class UserInfo_temp
        {
            public int user_id { get; set; }
            public string user_name { get; set; }
            public int level { get; set; }
        }

        public class SeasonSummary
        {
            public int code { get; set; }
            public string msg { get; set; }
            public SeasonSummary_data data { get; set; }
        }

        public class SeasonSummary_data
        {
            public List<Score> season { get; set; }
            public List<Score> free { get; set; }
            public List<Score> total { get; set; }
        }

        public class Score
        {
            public int g_source { get; set; }
            public int total_times { get; set; }
            public int total_win { get; set; }
            public int total_lost { get; set; }
        }

        #endregion
    }
}