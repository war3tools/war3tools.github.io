### 扩展功能
* 比如自己写一个查询具体平台的战绩后再回显到魔兽聊天消息框里
* 比如自己写一个显蓝，然后在需要的时候调用即可
* 比如对地图脚本比较熟悉的，可以单独写个地图脚本检测的程序，并将检测结果回显到魔兽聊天消息框里提醒玩家
* 其它

### VS开发
* Win7+  ->  Visual studio 2019+  ->  Windows控制台应用程序
* 直接下载此Demo源码，并在ExtLogic.cs的ProcessLogic方法里补充你的逻辑后生成Exe即可使用
* ExtInputArgs为输入的参数，ExtOutputArgs为要传回的参数，具体参数内容请看[ExtArgs.cs](https://github.com/war3tools/war3tools.github.io/blob/main/Others/SuWar3ToolsExtDemo/SuWar3ToolsExt/ExtArgs.cs)文件
* 扩展程序开发指引： [Others/SuWar3ToolsExtDemo/README.md](https://github.com/war3tools/war3tools.github.io/blob/main/Others/SuWar3ToolsExtDemo/README.md)

### 其它开发
* 任何你熟悉的最终可以生成Windows控制台应用程序的语言都可以，为啥用控制台制序，因为它没有界面故不会在运行后抢魔兽窗口的焦点
* SuWar3Tools在调用外部程序之前会先将参数放到文件“[运行文件名]_ing.json”里，这里的“[运行文件名]”为外部程序文件名
* 首先在程序启动后先读取运行目录下“[运行文件名]_ing.json”来得到参数，参数获取之后删除“[运行文件名]_ing.json”
* ExtInputArgs为输入的参数，ExtOutputArgs为要传回的参数，具体参数结构内容请看ExtArgs.cs文件，参数为json格式：  
```
{"Joiners":[],"MapPath":"Maps\\download\\真三国无双v3.9d.w3x","Players":[{"Index":0,"Name":"蜀国"},{"Index":0,"Name":"123abc"},{"Index":0,"Name":"玩者 3"},{"Index":0,"Name":"玩者 4"},{"Index":0,"Name":"玩者 5"},{"Index":0,"Name":"玩者 6"},{"Index":0,"Name":"魏国"},{"Index":0,"Name":"玩者 8"},{"Index":0,"Name":"玩者 9"},{"Index":0,"Name":"玩者 10"},{"Index":0,"Name":"玩者 11"},{"Index":0,"Name":"玩者 12"}],"Version":"1.24.4.6387"}
```
* 根据获取的参数处理你的逻辑，并将要显示的内容赋值给ExtOutputArgs.Msg
* 将最终结果对像ExtOutputArgs保存为“[运行文件名].json”后退出程序即可，如果不需要回显则不处理此对像或者不写这个文件，回显json格式：  
```
{"MType":0,"Msg":"这儿是你要显示到聊天对话框里的消息"}
```
* 生成exe程序后复制到”SuWar3Tools/SuWar3ToolsExt”目录下，在高级改键里通过“右键->脚本->运行扩展程序->选择扩展程序”进行使用
