### 介绍
* 快速设置一改多，设置之后按下一个键可以连续触发多个按键
* 如果不够，可以按下“一改多”右边的箭头展示进行更多设置

### 设置
* 右键-文本：复制当前输入框内显示的文字
* 右键-复制：复制当前输入框内的改键内容
* 右键-粘贴：将复制的改键内容粘贴到此输入框

### 键盘
* 屏蔽：用户按下的键会没有任何反应，一般用于Win键等
* 扩展  
  锁定单位：防止在释放技能的过程中造成选中单位丢失，这里一般是在添加鼠标左键点击后再在左键上加一个锁定单位的处理  
  选择英雄：开启后适用于有些地图F1所对应的英雄有多个单位ID时可切换多套技能改键的情况，如要使用先开启多英雄ID  
  1. 使用前要先按F1选择英雄  
  2. 再按Ctrl+F1记录英雄ID  
  3. 使用时会先判断未中英雄时则选中英雄  
  如需重设按下Ctrl+Backspace即可清空  
  按技能键：仅支持1.22-1.28版本，技能面板左上角为1，右下角为12，想要触发哪个技能就选择对应的序号即可  
  放下物品：仅支持1.22-1.28版本，背包面板从左到右、从上到下分别为Num7、Num8、Num4、Num5、Num1、Num2，如果选择All则表示放下所有物品，执行脚本时会将物品放到当前鼠标所在的位置  
  使用道具：仅支持1.22-1.28版本，添加道具具体介绍见高级改键
* 仅按下：先是在输入框输入要改的键，然后再使用此功能，表示当前按键仅按下
* 仅弹起：先是在输入框输入要改的键，然后再使用此功能，表示当前按键仅弹起
* 正常：先是在输入框输入要改的键，然后再使用此功能，默认就是正常，正常表示会模拟鼠标按下和弹起
* 技能相关  
  等待直到技能列表存在此快捷键(2秒超时)：可以在脚本中插入此键来等待一会再触发下一个改键，有些技能连放的时候按太快是不生效的，但如果用中间加延时又可能不太好把握，可用此选项来自动判断下一个要触发的快捷键判断  
  等待直到技能列表没有此快捷键(2秒超时)：可以在脚本中插入此键来等待一会再触发下一个改键，有些技能连放的时候按太快是不生效的，但如果用中间加延时又可能不太好把握，可用此选项来自动判断当前技能面板是否触发完的判断  
  判断技能快捷键存在则继续(100毫秒超时)，否则中断：比如设置一套连发，但某个技能cd还没好，用此选项可判断如果没有好就直接返回不再继续后面的动作了  
  取消技能相关等待判断：清除上面的设置，回到初始状态
* 小键盘：有些用笔记本的根本没有小键盘的键，可以用此菜单进行输入
* 通用：有些键盘某个键坏掉了，可以用此菜单进行输入
* 特殊：可输入一些特殊的组合键

### 延时
* 通过菜单输入一个延时值
* 将鼠标移到输入框上上下滚动鼠标可修改延时大小

### 鼠标
* 仅按下：表示仅按下鼠标
* 仅弹起：表示仅弹起鼠标
* 单击：正常按下弹起
* 组合：支持给合键和鼠标一起触发
* 单击技能：技能面板左上角为1，右下角为12，想要点击哪个技能就选择对应的序号即可
* 单击背包：背包面板从左到右、从上到下分别为Num7、Num8、Num4、Num5、Num1、Num2，想要点击哪个就选择对应的名称即可
* 鼠标位置自定义  
  相对鼠标实时位置偏移：根据当前鼠标位置移动指定偏移的距离  
  全屏千分比：根据屏幕大小和当前鼠标位置得出鼠标在屏幕距离左边和上边的千分比  
  点击拖动鼠标后即可获取到值并自动填入输入框，也可在输入框里手动微调，点击确定后完成录入  
  脚本执行时会根据当前配置的参数进行指定位置的移动
* 记录位置：在脚本执行时会记录当前鼠标的位置，用于脚本执行完成后进行恢复
* 恢复位置：脚本执行完成后可恢复前面记录的鼠标位置，记录位置和恢复位置一般是成对使用
* 鼠标待待：可以在脚本中插入一个鼠标待待的动作，这样当脚本执行到这里会等待用户操作(5秒超时)，当用户执行了指点操作后再继续执行后面的脚本

### 脚本
* 链接到：当在高级改键里设置脚本备注后，即可在这里进行选择，链接后将会执行高级改键里的脚本
* 切换启用状态：可通过快捷键来启用或关闭另一个脚本的启用状态