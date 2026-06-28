using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace SuWar3ToolsExt
{
    class Program
    {
        #region 程序入口和退出逻辑，此部分内容没有必要的情况下保持不变即可

        static string DefaultTipMsg = "魔兽争霸3改键SuWar3Tools外部扩展程序示例\n来源：https://war3tools.github.io";
        static string SepString = "------------------------------------------------";

        static void Main(string[] args)
        {
            try
            {
                //为防止程序长时间运行，一定时间后自动结束自己，另外SuWar3Tools也启动了线程超过60秒也会结束掉这个外部进程
                int second = ExtLogic.GetTimeOutSecond();
                if (second <= 0)
                    second = 60;
                System.Threading.Tasks.Task.Run(async () =>
                {
                    await System.Threading.Tasks.Task.Delay(second * 1000);
                    System.Environment.Exit(0);
                });
                //读取参数json
                ExtInputArgs inputArgs = null;
                string runPath = Assembly.GetEntryAssembly().Location;
                string jsonFile = Path.Combine(Path.GetDirectoryName(runPath), Path.GetFileNameWithoutExtension(runPath) + "_ing.json");
                if (File.Exists(jsonFile))
                {
                    string jsonStr = GetTextFromFile(jsonFile);
                    if (!string.IsNullOrEmpty(jsonStr))
                    {
                        try { inputArgs = ParseJson<ExtInputArgs>(jsonStr); } catch { }
                    }
                    File.Delete(jsonFile);
                }
                if (inputArgs == null)
                {
                    string tipMsg = ExtLogic.GetTipMsgWhenHasNoArgs();
                    if (!string.IsNullOrEmpty(tipMsg))
                        Console.WriteLine(DefaultTipMsg + "\n" + SepString + "\n" + tipMsg + "\n" + SepString);
                    else
                        Console.WriteLine(DefaultTipMsg + "\n" + SepString);
                    Console.WriteLine("\n按“y”继续执行将生成返回参数的json文件，否则退出(" + second + "秒后也会自动退出)：");
                    if (Console.ReadKey().Key.ToString().ToLower() == "y")
                    {
                        Task t = MainAsync(args, inputArgs);
                        t.Wait();
                    }
                }
                else
                {
                    Task t = MainAsync(args, inputArgs);
                    t.Wait();
                }
            }
            catch
            {
                return;
            }
        }

        static async Task MainAsync(string[] launchArgs, ExtInputArgs inputArgs)
        {
            try
            {
                QuitWithArgs(await ExtLogic.ProcessLogic(launchArgs, inputArgs ?? new ExtInputArgs(), new ExtOutputArgs()));
            }
            catch
            {
                System.Environment.Exit(0);
            }
        }

        static void QuitWithArgs(ExtOutputArgs extOutputArgs)
        {
            try
            {
                string runPath = Assembly.GetEntryAssembly().Location;
                string jsonFile = Path.Combine(Path.GetDirectoryName(runPath), Path.GetFileNameWithoutExtension(runPath) + ".json");
                SaveTextToFile(GetJson(extOutputArgs ?? new ExtOutputArgs()), jsonFile);
            }
            catch (Exception ex)
            {
                extOutputArgs.Msg = ex.Message;
            }
            finally
            {
                System.Environment.Exit(0);
            }
        }

        #endregion

        #region 一些公共方法

        public static string GetTextFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                return string.Empty;

            using (FileStream aFile = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(aFile))
                {
                    string data = sr.ReadToEnd();
                    return data;
                }
            }
        }

        public static void SaveTextToFile(string text, string fileName)
        {
            using (FileStream aFile = new FileStream(fileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(aFile))
                {
                    sw.Write(text);
                }
            }
        }

        public static string GetJson<T>(T obj)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                json.WriteObject(stream, obj);
                string szJson = Encoding.UTF8.GetString(stream.ToArray());
                return szJson;
            }
        }

        public static T ParseJson<T>(string szJson)
        {
            T obj = Activator.CreateInstance<T>();
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(szJson)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                return (T)serializer.ReadObject(ms);
            }
        }

        #endregion
    }
}