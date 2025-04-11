# 11平台天梯查询
### 地址
* 主页： https://war3tools.github.io

### 使用方法
在SuWar3Tools里改键设置里右键->脚本->添加外部控制台程序，然后将11.exe复制到“SuWar3Tools\SuWar3ToolsExt”目录里，选择11.exe程序后会提示输入参数，参数格式为“类型 11账号 11密码”(中间用空格分隔)，其中类型参数为：1:Dota 2:IMBA 3:OMG 4:真三 5:IM起源 6:信长 7:IMCA 8:OMG起源"  
如添加真三天梯查询的示例为：    
LAlt+F = <11.exe|4 username password>  
在游戏开始后按下Alt+F则可以以聊天消息的形式发送查询结果。

### 拓展定制
如果你想自定义你自己的查询结果或者想查询显示更多的信息可修改[ExtLogic.cs](ExtLogic.cs)文件后自行编译即可。  