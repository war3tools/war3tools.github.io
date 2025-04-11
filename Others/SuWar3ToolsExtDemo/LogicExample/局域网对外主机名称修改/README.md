# 局域网对外主机名称修改
### 地址
* 主页： https://war3tools.github.io

### 使用方法
在SuWar3Tools里改键设置里右键->脚本->添加外部控制台程序，然后将HostName.exe复制到“SuWar3Tools\SuWar3ToolsExt”目录里，选择HostName.exe程序后会提示输入参数，参数为“{MapFileName}的游戏”  ，然后勾选“游戏未开始也生效”，添加后的示例为：  
!LAlt+F = <HostName.exe|{MapFileName}的游戏>  
在创建主机后按下Alt+F即可，其中{MapFileName}会替换为当前选择的地图的文件名。比如选的地图是Maps\BootyBay.w3m，则修改后的房间名为“BootyBay的游戏“，如果不需要显示地图路径则不用填写"{MapFileName}"，直接填写需要修改的名称即可。