### 关于
* 主页： https://war3tools.gitlab.io
* Gitlab： https://gitlab.com/war3tools/war3tools.gitlab.io

### 预览
* 主界面  
![](https://github.com/war3tools/war3tools.github.io/raw/master/docs/images/SuWar3Tools.png "主界面")
* 高级改键  
![](https://github.com/war3tools/war3tools.github.io/raw/master/docs/images/SuWar3ToolsAd.png "高级改键")

### 介绍
* 改键、显血、窗口鼠标锁定、分辨率调整，支持1.15~1.30+
* 视野调整，支持1.15~1.34，针对1.30之后的版本需要注意(1.35之后已内置视距调整功能)：
  + 调整前视野必须为地图加载完成后的初始默认值(鼠标向下滚动到视野不变为止)
  + 按下快捷键进行调整，调整过程中不要滚动鼠标滚轮，第一次大约需要6秒调整时间
  + 游戏过程中滚动鼠标会还原，可再次按下快捷键继续调整
  + 每开一局或无效时，同时按下Ctrl+视野调整快捷键重置
  + 如果调整无效时请关闭360之类的软件
* 英雄技能改键，非鼠标模式下只支持1.22-1.28，鼠标模式下支持所有版本  
以鼠标点击方式触发技能使用方法(面板从左往右从上往下一共12个格子)
  + 将鼠标放到第1格正中心后按下 Ctrl+Alt+<
  + 将鼠标放到第12格正中心后按下 Ctrl+Alt+>
  + 设置完成，配置信息自动缓存，如有问题可重设
* 显蓝：借助第三方工具实现显蓝功能，支持1.20至1.27
* 高级改键：点击一改多区域右边的无穷符号即可进入高级改键设置  
高级改键参考示例： [Others/AdvancedCodeDemo/README.md](https://gitlab.com/war3tools/war3tools.gitlab.io/-/blob/main/Others/AdvancedCodeDemo/README.md)
* 调用外部扩展程序：可调用第三方控制台程序并根据参数将消息以聊天形式发送  
扩展程序开发指引： [Others/SuWar3ToolsExtDemo/README.md](https://gitlab.com/war3tools/war3tools.gitlab.io/-/blob/main/Others/SuWar3ToolsExtDemo/README.md)
* 调用外部Dll注入：每次魔兽启动时可调用设置的外部Dll(如显蓝)  
注入逻辑使用指引： [Others/ExtDll/README.md](https://gitlab.com/war3tools/war3tools.gitlab.io/-/blob/main/Others/ExtDll/README.md)
* 喊话功能，如有特殊喊话需求请在高级改键里配置
* 支持Win7及以上系统(不支持XP)
* **`因程序加壳原因导致杀毒软件误报时请加入排除项即可(请完全退出360)`**
* **`请勿在对战平台上游戏时测试或使用本软件，也不要和其它改键工具同时使用`**
* **`本程序仅供学习交流，严禁用于商业用途，请于24小时内删除，作者不对因使用本软件而产生的后果和损失承担任何责任`**

### 下载
* 地址  
[https://www.megadisk.net/cloud11/index.php/s/Yvt5smhuda8vxAn](https://www.megadisk.net/cloud11/index.php/s/Yvt5smhuda8vxAn)  
[https://e.pcloud.link/publink/show?code=kZuPfnZPMNuop5GahSHaMcaSxbojp7AXIFX](https://e.pcloud.link/publink/show?code=kZuPfnZPMNuop5GahSHaMcaSxbojp7AXIFX)  
[https://drive.internxt.com/sh/folder/79ed1b38-26b8-4cbc-818e-5687b072eb1f/c0c84fdce9486632690de15d1e08b94f209350c29967cfc65e3c874f6bb6b7cb](https://drive.internxt.com/sh/folder/79ed1b38-26b8-4cbc-818e-5687b072eb1f/c0c84fdce9486632690de15d1e08b94f209350c29967cfc65e3c874f6bb6b7cb)  
[https://sourceforge.net/projects/war3tools/files/](https://sourceforge.net/projects/war3tools/files/)
* 如果运行失败，请下载并安装 .net4.7.2 微软官方离线安装包：  
https://dotnet.microsoft.com/download/thank-you/net472-offline
* Bug反馈和意见及建议邮箱： war3tools@outlook.com  
  描述问题时请使用最新版本的程序测试并附带操作系统版本、魔兽版本、地图版本，以便于更方便和快速定位问题

### 更新
* [v2.1.1.156]
  + 无奈：github账号上次被莫名封掉影响更新，近来又莫名解封了，但懒得再切换了
  + 重要：更新程序依赖的运行库至4.7.2版本，其实也是2018年就有了，也不算新了
  + 修复一定条件下喊话会导致功能键未弹起从而改键失效的问题，感谢热心魔友反馈
  + 丢掉物品功能加入可以丢掉指定物品ID的功能(无视格子位置，支持1.22~1.28)
  + 其它小优化
* [v2.1.1.155]
  + 一只小鱼儿游到了其它地方： https://war3tools.gitlab.io
  + 添加当方案勾选仅对英雄生效时背包改键也可以配置对所有单位有效
  + 添加喊话可自定义间隔延时的功能
  + 优化Alt+数字键连续喊话功能
  + 优化检查更新导致的卡顿问题
  + 其它小优化
* [v2.1.1.154]
  + 添加WFE显蓝插件，支持1.26和1.27显蓝
  + 脚本功能添加按标题关闭窗口的功能
  + 内存优化、闪退修复及其它小优化
  + 优化条件判断执行逻辑
* [v2.1.1.153]
  + 条件表达式脚本功能移到输入框右键菜单里并增加一些脚本变量
  + 加强Http扩展服务功能
  + 其它小优化
* [v2.1.1.152]
  + 高级改键里加入条件脚本，具体使用请查看高级改键帮助文档
  + 加入内置Http服务，可供其它场景使用，具体可查看Http服务扩展帮助
  + 全局设置右下角添加插件功能入口，加入显蓝功能，请特别注意平台限制
  + 优化全局按键交换，支持按键改为鼠标，即键盘按下弹起等同于鼠标按下弹起
  + 建主机时当有新玩家加入时自动发送消息支持换行发送多条
  + 尝试优化了快捷施法锁定英雄的施法速度
  + 脚本增加了直接打开运行命令、卸载Dll的功能
  + 特定时间运行增加了检测魔兽退出时可执行相关脚本的功能
  + 记住窗口化设置添加延时，避免魔兽全屏运行时记录的值不正确
  + 修复技能面板自定义按键映射处理逻辑问题
  + 其它小优化
* [v2.1.1.151]
  + 启动平台加入“同时退出”的配置项，修复删除平台没有保存配置的问题
  + 加入全局右键菜单，快捷键为Alt+Esc，建议在魔兽窗口化运行模式下使用
  + 调整一键启动的功能移到全局右键菜单里，也可在右下角图标里设置
  + 加入快捷施法兼容双击动作的选项，适用于dota背包在自身上使用的情况
  + 高级改键加入魔兽版本、地图路径、运行参数的自定义过滤功能
  + 高级改键加入特定时间执行脚本的功能
  + 加入按键长按时只触发一次脚本的选项
  + 优化中文喊话的使用体验，降低聊天输入框的闪烁效果
  + 判断技能面板是否存在Esc由原来的100ms降为50ms
  + 修复切换方案信息不提示和小图标功能不显示的问题
  + 其它小优化
* [v2.1.1.150]
  + 扩展脚本加入按名称杀死指定进程的功能
  + 调用脚本dll注入时判断已注入则跳过，但可重复调用无参数的函数
  + 背包添加左键+Esc的功能修改为“添加左键+锁定单位”，防止选中单位丢失
  + 高级改键添追加时支持设置单位锁定，在左键上添加可防止选中单位丢失
  + 高级改键添加可通过快捷键改变另一个脚本的开启状态的功能
  + 高级改键支持添加XButton触发
  + 优化了窗口鼠标锁定功能、全屏锁鼠标支持多屏的情况
  + 优化了喊话功能，针对纯英文字符喊话特殊处理
  + 优化了Ctrl+技能学习的功能
  + 其它小优化
* [v2.1.1.149]
  + 全局设置更多设置里添加通过Enter/Esc来判断聊天状态，适用于1.30+
  + 其它小优化
* [v2.1.0.148]
  + 包裹、技能等加入技能面板Esc判断，如果不存在则中断后续点击动作
  + 高级改键增加判断技能面板是否存在快捷键，如果存在则继续，否则中断
  + 添加修改按键时支持通过鼠标右键选择按键，避免键盘坏掉时无法设置
  + 优化了喊话功能的配置操作，点击喊话右边的“通用”进行更多设置
  + 窗口锁定添加位置偏移设置功能，用户可根据实际情况自行调整
  + 修复框选多个英雄时使用指定道具可能不生效的问题
  + 其它小优化
* [v2.1.0.147]
  + 优化了下1.35的改键影响聊天的情况，不一定百分百，仅提升优化
  + 增加全局键盘交换功能，在高级改键里配置要交换的键后右键选择对应选项
  + 增加外部Dll注入的功能(如显蓝)，具体参考Gitlab帮助说明
  + 优化了扩展程序在检测War3启动时自动执行的逻辑
  + 暂停开关上加入右键设置快速启动魔兽功能选项
  + 修正了“游戏未开始也生效”的改键触发逻辑
  + 修正了创建主机后获取地图路径乱码的问题
  + 修正喊话时会按下Esc的问题
  + 其它小优化
* [v2.1.0.146]
  + 高级改键按下的键支持组合功能键的状态设置
  + 高级改键按下的键支持按下循环功能设置
  + 恢复魔兽窗口设置做了延时处理，防止卡死
  + 喊话增加多方案功能，最多支持9个喊话方案
* [v2.1.0.145]
  + 优化1.30+特殊场景下改键失效的Bug，仍无法使用可启用强制改键
  + 增加自定义按位置点判断聊天状态的功能
  + 增加一键隐藏魔兽的功能(默认未设置快捷键)
  + 增加调用外部控制台程序的功能(以09平台战绩查询为示例)
  + 增加第二种视野调整的方式(一般用于被修改过的魔兽版本)
  + 针对“英雄-F1”的功能支持可设置包含多个英雄ID并修改相关快捷键
  + 修复背包快捷键设置为组合键时的连续触发便捷性
  + 添加可自定义魔兽运行路径的功能
  + 其它小优化
* [v2.1.0.144]
  + 增加一键放下物品的扩展功能，如：Q = RClk + Drop-All
  + 技能面板等待快捷键的判断功能修正对Esc的支持
  + 魔兽启动选项可添加多组自定义启动参数
  + 修复HDPI环境下界面字体模糊的问题
* [v2.1.0.143]
  + 优化了喊话和1.30+视距调整功能
  + 高级改键加入了鼠标等待和指定技能位置等待判断
  + 全局设置里加入了记录游戏玩家名称功能(1.22-1.28)
  + 开放小图标快捷功能(1.22-1.28可提示游戏时间)
  + 提供重置版顺序改键的界面编辑功能(支持组合键)
  + 修正重置版喊话的问题
* [v2.1.0.142]
  + 显示界面的热键修改为全局可用(修改后需保存)
  + 增加窗口化功能，原分辨率设置功能移到其它面板里
  + 技能改键识别重复(IMBA)和缺少的情况(默认未开启)
  + 点击右上角关闭改为开启改键功能(兼容零度习惯)
  + 高级改键脚本可引用其它脚本并优化了操作细节
  + 高级改键可以设置技能等待(用于二三级技能连按)
  + 其它工具里加入魔兽CD-Key的修改和删除功能
  + 增加重置版顺序改键文本的编辑功能
  + 修正多屏环境下锁鼠问题和优化伪全屏处理逻辑
  + 如提示兼容性时可先开程序后开平台或强制运行
* [v2.1.0.141]
  + 增加程序标题自定义和随机文件名启动的功能
  + 高级改键增加触发指定技能位置和物品ID功能
  + 增加运行错误时的消息提示和日志处理
  + 优化英雄多选时技能改键判断
  + 检测到与平台不兼容时直接退出本程序
  + 高级改键可以复制代码便于分享
  + 增强检查更新逻辑以确保能正常更新
* [v2.1.0.140]
  + 针对1.31+的版本视距功能只支持从x86文件夹下启动魔兽有效
  + 一改多加入鼠标位置记录和还原功能，加入鼠标移动配置功能
  + 高级改键触发条件支持双击和循环触发(在按下那一列右键选择)
  + 高级改键的追加和删除操作支持操作任意位置
* [v2.1.0.139]
  + 针对技能改键的逻辑进行了调整和优化，如有问题请及时反馈
  + 加入技能重映射功能，对某个单位单独映射键值和鼠标点击
  + 一对多改键可以添加选择英雄和以鼠标方式点击技能位置
  + 高级改键里仅英雄条件下也可以设置单条规则强制有效(右键菜单 )
  + 加入强退魔兽，暂停继续游戏的快捷键
  + 加入日志记录功能，如有问题可开启后邮件反馈问题
* [v2.1.0.138]
  + 针对小键盘改键可以自由设置是否追加Esc键
  + 修正了英雄技能获取和触发的逻辑
  + 高级改键支持自定义喊话和英雄选择功能
  + 加入对IPvE vLan等其它平台的支持
  + 加入视距锁定功能(全局设置右边的入口)
  + 其它界面加入一些小功能(魔兽相关，对战平台启动)
* [v2.1.0.137]
  + 添加改键仅对英雄生效的选项设置(默认未开启)
  + 加入高级改键方案设置，可设置英雄为改键条件(仅支持1.22-1.28)
* [v2.1.0.136]
  + 优化1.30+版本宽屏的聊天状态检测逻辑
* [v2.1.0.135]
  + 优化英雄技能改键的逻辑
  + 加入屏蔽自定义按键的功能
* [v2.1.0.134]
  + 优化窗口化运行魔兽时的聊天状态判断
  + 增加游戏状态的检测，只有进入了游戏界面改键才生效
* [v2.1.0.133]
  + 增加方案快速切换功能：如名称前加“[D]”则快捷键为Ctrl+Shift+D
  + 优化魔兽1.30+版本判断聊天状态的逻辑
* [v2.1.0.132]
  + 加入更新提示框显示更新日志的功能
  + 加入鼠标模拟技能时可锁定鼠标位置
<details>
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
</details>

### 赞赏
<details>
<summary>如果觉得本程序对你有帮助可以在程序的赞赏入口里对我进行赞赏(金额随意)</summary>
gEt+MDdUWzPYGGhS4WAawLlUC3awXYgkrVRej8z2xkwCmnKvp22K5T46HBid9yOKtY3Y7Pt2Ng022mXhYGv8Ws4nLug62oFpCjrdTNpj+czwysHzsvPAewc1cCU6Zq8mQafwFOVQ7y8t6IaZpIxsRuW7PA/VohqG/XRB3gm/K+UKd06xXeCvLK6/tqDD6ue6wxjtLJaNgScXZXw7byrrF7nAzY4/RyXTvOi8lq6zrdkeZB7j1b7kOvo4D1a6gZVGa6CpZDCWBukR6K/cxQwYLvWJzrgsjEAD9WfelOxCwg3Plb7joRqaB2SPhqU+T8sy4c3gh6bq9mLzdyFdoneNOyu600pX/CYhSSS6UtQJgAwdwcTgRCUMilUHgpaUTCCMU2y40+oKQp4kp5bip7bkFyvNVbaTvaDU3BSCYeME2iXbwRzRDbHq+EE9fHN7XTV4fDWBfNab5AgHf70fIysXoRwRj9YeSFvyNnkm14MosZIdLX8sBowVIjOQJAzZQC7YUeLqa4tM3PIOiMceSCnyuixCcwq0uFlbAUioreZdicCze4qFhv2R0XVOu2R/+Y2fpTDQD+74J53YCrE8noFxep+AyBtmZopSWglMiTKZbcD+3Z+w2q01Phu/kVOn+Q2wFJl4oAW4XN7AREKGsvebPv3BepLe559V2QmKumHP0a5wfv6CnDNsUaM1VBKQ7upP8f0viFRQDP/gxL587arCRs5arpZiYQQ5/bgmXgwyrNmE6I/w5SBIU5CzQI5nOm9WjloO0DYDzM6BMzVJ2Eq6w0t9ozLqMXC9h7NYpUV3FRxRba4LLjCT4MFsbMd8gVO3T1i4wQK+QfKiDQyrjTapwO1eDkvVg11q/a9ZxxpQg5fQsOoiKwbG/ReMn0JEXANl0cGU8+MQCAPcQ5x93E+of01Dpo7OarWsSIAliWybs70ipmymoc0hHMBcGkfBZ/bz
</details>
