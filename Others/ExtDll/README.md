# 魔兽争霸3改键SuWar3Tools ExtDll示例
### 地址
* 主页： https://war3tools.github.io
* Github： https://github.com/war3tools/war3tools.github.io

### 使用原理
文件内容是一个Dll(可能后缀名不同)，通过注入后自动调用DllMain来完成逻辑代码的执行

### 使用方法
在SuWar3Tools的高级改键设置里右键->脚本->添加外部Dll注入，然后将相关文件复制到“SuWar3Tools\SuWar3ToolsExt”目录里，选择对应程序后即可添加，有些像显蓝这种是需要在游戏启动后就得注入的，此时在按下那一栏右键选择"启动时执行扩展程序"即可，最终添加后的示例为：  
*LAlt+F = <warmp.mix> + ...(如果有多个可在面继续添加)  
以上示例在每次魔兽启动后会自动执行注入动作，无需再手动按快捷键触发  
如果未勾选“启动时执行扩展程序”，则需要自行按快捷键后执行，请注意部分扩展程序的注入时机必须是在游戏开始前

### 使用示例
* **`以下程序未在任何对战平台上测试，作者不对因使用本软件而产生的后果和损失承担任何责任`**
* 以下为自己收集到的一些，均来源于网上，win10系统War3单机1.24E上测试可用，对战平台上请谨慎使用

  + warmp.mix  
显蓝的，来源于佳佳的“魔兽永久显蓝(WarMP)2.6”，在退出魔兽时会弹错误框，不过不影响使用
  + ManaBars.dll  
显蓝的，来源于魔兽超级辅助WarSuper v3.12，支持1.20e/1.24b/1.24c/1.24d/1.2.4e/1.25b/1.26a
  + mb.dll  
显蓝的，来源于零度魔兽助手5.0
  + mana.bar wars.mixtape  
显蓝的，来源于“魔兽显蓝工具 V3.5”，wars.mixtape是自定义颜色生成的文件(还有个txt我没放进来)
  + wyxl.mix  
显蓝的，来源于“魔兽无忧 三鹿告别版”，支持1.20E/1.24B/1.24E
  + strom80.mix  
魔兽争霸1.24消除延迟补丁，来源于互联网，具体使用方法自行百度哈
  + RenderEdge_Widescreen.mix  
宽屏补丁，支持1.23a/1.24e/1.26a/1.27a,1.27b/1.28.0,1.28.2,1.28.4,1.28.5，来源：https://github.com/ENAleksey/RenderEdge_Widescreen
  + Reverb3.flt  
全图加显蓝，来源：https://www.52pojie.cn/thread-948590-1-1.html
  + 1.24Ejass实现英雄头顶显示资源属性框.asi  
网友提供的，鼠标悬停在英雄上时会显示一些信息
  + War3_HQZBJC.asi  
网友提供的，好像是脚本检测啥的

### 欢迎有时间有能力有兴趣的朋友交流贡献
