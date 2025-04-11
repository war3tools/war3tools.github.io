using System.Collections.Generic;
using System.Reflection;

namespace SuWar3ToolsExt
{
    [ObfuscationAttribute(Exclude = true, ApplyToMembers = true)]
    public class ExtInputArgs
    {
        /// <summary>
        /// 魔兽进程ID
        /// </summary>
        public int Pid { get; set; }

        /// <summary>
        /// 魔兽BaseAddr
        /// </summary>
        public long BaseAddr { get; set; }

        /// <summary>
        /// 魔兽StormAddr
        /// </summary>
        public long StormAddr { get; set; }

        /// <summary>
        /// 魔兽运行版本号
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 已加入主机的玩家列表(支持1.22~1.27)
        /// </summary>
        public List<Player> Joiners { get; set; }

        /// <summary>
        /// 开始游戏后的魔兽玩家列表(支持1.22~1.28)
        /// </summary>
        public List<Player> Players { get; set; }

        /// <summary>
        /// 游戏所用地图路径(支持1.22~1.28)
        /// </summary>
        public string MapPath { get; set; }

        /// <summary>
        /// 游戏界面状态码(支持1.22~1.28)
        /// </summary>
        public int StateCode { get; set; }

        /// <summary>
        /// 游戏时间(支持1.22~1.28)，单位毫秒
        /// </summary>
        public long GameTime { get; set; }
    }

    [ObfuscationAttribute(Exclude = true, ApplyToMembers = true)]
    public class ExtOutputArgs
    {
        /// <summary>
        /// 消息处理类型：
        /// 0: 以聊天形式向好友发送消息提示
        /// 1: 以聊天形式向所有人发送消息提示
        /// 2: 以聊天对话框显示消息但不发送
        /// 3: 自定义集合，此类型的使用场景必须开发者清晰的知道当前魔兽处理哪个界面并进行对应的返回操作集合
        ///    说明：前缀为[SendKeys]的请参考C#发送消息SendKeys.SendWait的使用方法，[SetClipboard]为自定义内置特殊标识功能，[Wait]2000表示等待2秒；
        ///    格式：[SendKeys]{Enter}\n[SetClipboard]这是要发送的消息\n[Wait]100\n[SendKeys]^v\n[SendKeys]{Enter}
        ///    解析：发送回车按键->设置剪贴板内容为“这是要发送的消息”->等待0.1秒->发送Ctrl+V->发送回车按键
        ///    如果是1.30之后的魔兽版本上面的格式可以不需要用到[SetClipboard]：[SendKeys]{Enter}\n[SendKeys]这是要发送的消息\n[Wait]100\n[SendKeys]^v\n[SendKeys]{Enter}
        /// </summary>
        public int MType { get; set; }

        /// <summary>
        /// 要显示的消息内容，如果消息内容太多或为自定义集合时都请以“\n”进行分行控制
        /// </summary>
        public string Msg { get; set; }
    }

    [ObfuscationAttribute(Exclude = true, ApplyToMembers = true)]
    public class Player
    {
        public string Name { get; set; }

        public int Index { get; set; }
    }
}