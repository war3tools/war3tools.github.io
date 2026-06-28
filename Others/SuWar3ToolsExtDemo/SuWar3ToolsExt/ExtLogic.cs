using System;
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
            return 10;
        }

        /// <summary>
        /// 设置提示文案，当手动点击情况下(未检测到输入参数时)会显示此提示内容
        /// </summary>
        /// <returns></returns>
        public static string GetTipMsgWhenHasNoArgs()
        {
            return "本程序为Demo示例，返回显示一段文字作为测试效果";
        }

        /// <summary>
        /// 使用说明： https://war3tools.github.io
        /// </summary>
        /// <param name="launchArgs">程序启动参数</param>
        /// <param name="inputArgs">由SuWar3Tools生成的Json文本参数</param>
        /// <param name="outputArgs">输出的参数，将由SuWar3Tools进行处理</param>
        /// <returns></returns>
        public static async Task<ExtOutputArgs> ProcessLogic(string[] launchArgs, ExtInputArgs inputArgs, ExtOutputArgs outputArgs)
        {
            try
            {
                outputArgs.Msg = string.Format("[{0}]我接收到了从SuWar3Tools传来的魔兽版本号：{1}", DateTime.Now.ToString("yyyyMMdd HH:mm:ss"), inputArgs.Version);
            }
            catch (Exception ex)
            {
                outputArgs.Msg = ex.Message;
            }
            return outputArgs;
        }

        #endregion
    }
}