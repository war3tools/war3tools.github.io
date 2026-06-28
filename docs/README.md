### 关于
* 主页： https://war3tools.github.io
* Github： https://github.com/war3tools/war3tools.github.io

### 预览
* 主界面  
![](https://github.com/war3tools/war3tools.github.io/raw/main/docs/images/SuWar3Tools.png "主界面")
* 高级改键  
![](https://github.com/war3tools/war3tools.github.io/raw/main/docs/images/SuWar3ToolsAd.png "高级改键")

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
高级改键参考示例： [Others/AdvancedCodeDemo/README.md](https://github.com/war3tools/war3tools.github.io/blob/main/Others/AdvancedCodeDemo/README.md)
* 调用外部扩展程序：可调用第三方控制台程序并根据参数将消息以聊天形式发送  
扩展程序开发指引： [Others/SuWar3ToolsExtDemo/README.md](https://github.com/war3tools/war3tools.github.io/blob/main/Others/SuWar3ToolsExtDemo/README.md)
* 调用外部Dll注入：每次魔兽启动时可调用设置的外部Dll(如显蓝)  
注入逻辑使用指引： [Others/ExtDll/README.md](https://github.com/war3tools/war3tools.github.io/blob/main/Others/ExtDll/README.md)
* 喊话功能，如有特殊喊话需求请在高级改键里配置
* 支持Win7及以上系统(不支持XP)
* **`因程序加壳原因导致杀毒软件误报时请加入排除项即可(请完全退出360)`**
* **`请勿在对战平台上游戏时测试或使用本软件，也不要和其它改键工具同时使用`**
* **`本程序仅供学习交流，严禁用于商业用途，请于24小时内删除，作者不对因使用本软件而产生的后果和损失承担任何责任`**

### 下载
* 地址    
[https://sourceforge.net/projects/war3tools/files/](https://sourceforge.net/projects/war3tools/files/)
* 如果运行失败，请下载并安装 .net4.7.2 微软官方离线安装包：  
https://dotnet.microsoft.com/download/thank-you/net472-offline
* Bug反馈和意见及建议邮箱： war3tools@outlook.com  
  描述问题时请使用最新版本的程序测试并附带操作系统版本、魔兽版本、地图版本，以便于更方便和快速定位问题

### 更新
* [v2.1.1.158]
  + 感谢“*演”大哥打赏66
  + 纯情怀作品，去掉广告，聊胜于无
  + 修复某些平台1.20版本改键兼容问题
  + 高级改键里可设置按模块过滤，这个一般极少用到，可不必理会
  + 增加可自定义小地图友敌颜色的功能，支持1.20到1.27，精力有限，其它版本暂未支持
  + 其它小优化
* [v2.1.1.157]
  + 无奈不得不又回到github
  + 修复丢掉物品时同个物品有多个时只会丢第一个的问题
  + 丢弃物品支持手动批量输入
  + 加入喊话方案切换提示，添加喊话方案时给出快捷键提示
  + 其它小优化
* [v2.1.1.156]
  + 无奈：github账号上次被莫名封掉影响更新，近来又莫名解封了，但懒得再切换了
  + 重要：更新程序依赖的运行库至4.7.2版本，其实也是2018年就有了，也不算新了
  + 修复一定条件下喊话会导致功能键未弹起从而改键失效的问题，感谢热心魔友反馈
  + 丢掉物品功能加入可以丢掉指定物品ID的功能(无视格子位置，支持1.22~1.28)
  + 其它小优化
* [v2.1.1.155]
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
  + 增加外部Dll注入的功能(如显蓝)，具体参考Github帮助说明
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
