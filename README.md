###简介

Beauty Instrument Simulator是一款基于C#开发的串口模拟工具，用于模拟蓝牙采集硬件数据，需要与Beauty Instrument硬件设备通过串口连接。该工具具有串口调试助手的全部功能，额外增加了Beauty Instrument设备的通信协议，可模拟蓝牙及APP的相关通信，目的是方便Beauty Instrument硬件开发与调试。

###通信配置

Beauty Instrument Simulator工具需要USB转串口模块1个，与Beauty Instrument蓝牙通信接口连接后在软件中进行如下配置：

	波特率：9600b/s
	校验位：无
	数据位：8bit
	停止位：1bit

>发送数据格式和接收数据格式均为十六进制

###通信机制

Beauty Instrument Simulator做主机，Beauty Instrument做从机；Beauty Instrument Simulator主动向Beauty Instrument发送命令帧，Beauty Instrument不主动发送命令帧，只能被动等待设置或者查询。

Beauty Instrument发送固定长度位2+15Byte的命令帧，Beauty Instrument Simulator发送固定长度位2+6Byte的命令帧。（前面2Byte为BLE模块固有通信协议）

Beauty Instrument Simulator间隔300ms至500ms向Beauty Instrument发送一次命令，Beauty Instrument接收到命令帧并执行相关操作后给Beauty Instrument Simulator回复信息。

若Beauty Instrument Simulator发送命令300ms内没有接到Beauty Instrument的回复命令，则立即重复发送上一条命令。

Beauty Instrument Simulator连续6次接收不到Beauty Instrument的命令帧或合法命令帧，则视为Beauty Instrument工作异常，上报给Beauty Instrument Simulator显示给用户。（合法命令帧表示命令帧头为“0xA5”，接收长度正确，且校验和正确，否则视为非法命令帧）

###通信协议

请参见 `Beauty Instrument与手机APP通信协议 V1.0` 与 `BC76xx_Programming Guide_vTmp` 文档，这里将不再赘述。



