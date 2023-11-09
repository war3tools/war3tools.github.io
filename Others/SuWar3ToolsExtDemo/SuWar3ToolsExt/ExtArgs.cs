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
    }

    [ObfuscationAttribute(Exclude = true, ApplyToMembers = true)]
    public class ExtOutputArgs
    {
        /// <summary>
        /// 消息处理类型：
        /// 0: 以聊天形式向好友发送消息提示
        /// 1: 以聊天形式向所有人发送消息提示
        /// 2: 以聊天对话框显示消息但不发送
        /// </summary>
        public int MType { get; set; }

        /// <summary>
        /// 要显示的消息内容，如果消息内容太多不显示，请自行分行并以“\n”连接
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