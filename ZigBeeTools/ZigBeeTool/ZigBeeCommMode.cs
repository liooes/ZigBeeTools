using DataHandler;
using HardwareModes;
using SerialPortHelpers;
using System;
using System.Text; 

namespace ZigBeeTool
{
    /// <summary>
    /// ZigBee无线通讯节点模块
    /// </summary>
    public class ZigBeeCommMode : HardwareMode
    {
        SerialPortHelper sph;
 
        public string HA { get; set; }
        public string NODE { get; set; }
        public string CHANNEL { get; set; }
        public string PI { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        public string ModelState { get; set; }
         
        /// <summary>
        /// 初始化对象设置串口参数
        /// </summary>
        /// <param name="portName">串口号</param>
        /// <param name="BaudRate">波特率</param>
        public ZigBeeCommMode(string portName, string BaudRate)
        {
             sph = new SerialPortHelper(portName,BaudRate);
        }

        /// <summary>
        /// 设置模块
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public override string SettingMode(string cmd)
        {
            //参数转十六进制加上附加位
            byte[] bytesFromCMD = StringHandle.getBytesFromCMD(cmd.ToString());
            //向串口写入数据 
            sph.sp_sendData(bytesFromCMD);
            sph.sp_DataReceive();//接收数据
            return DataReceiveHandle(sph.strspRevData);  // 处理返回上来的值、返回给调用者
        }

        /// <summary>
        /// 查询模块
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public override string SelectMode(string cmd)
        {
            //参数转十六进制加上附加位
            byte[] bytesFromCMD = StringHandle.getBytesFromCMD(cmd.ToString());
            //向串口写入数据
            sph.sp_sendData(bytesFromCMD);
            sph.sp_DataReceive();//接收数据
            return DataReceiveHandle(sph.strspRevData);  // 处理返回上来的值、返回给调用者
        }

         /// <summary>
        /// 获取路由器上报数据
        /// </summary>
        public void GetRoterReportData()
        { 
                sph.sp_DataReceive();//接收数据
                byte[] by = sph.strspRevData; //获取接收数据
                if (by != null && by.Length.Equals(24))
                {
                    string strData = Encoding.Default.GetString(by);
                    this.HA = strData.Substring(17, 2);
                    this.ModelState = strData.Substring(22, 1);
                } 
            
        }



        /// <summary>
        /// 数据过滤处理
        /// </summary>
        /// <param name="data">串口返回值</param>
        /// <returns>过滤后的值</returns>
        string DataReceiveHandle(byte[] data)
        {
            /*
             * 查询硬件地址：返回:AT+AZ_BASE_ADDRESS=1,Zxxxx<CR>//Zxxxx:
             * 设置硬件地址：返回:<LF>OK<LF>或<LF>ERROR<LF>
             * 
             * 查询ZigBee通讯节点的类型：返回:AT+AZ_Z_NODE=M<CR>//M:节点类型,取值:C(协调器)，R(路由器)
             * 设置ZigBee通讯节点的类型：返回:<LF>OK<LF>或<LF>ERROR<LF>
             * 
             * 查询ZigBee通讯节点的CHANNEL：返回:AT+AZ_Z_CHANNEL=N<CR>//N:信道号,取值11～26。对应为11到26信道。
             * 设置ZigBee通讯节点的CHANNEL：返回:<LF>OK<LF>或者<LF>ERROR<LF>。
             * 
             * 查询ZigBee通讯节点的PANID：返回:AT+AZ_Z_PAN_ID=D<CR>//D:PANID值,十六进制数据,出厂值:199BFFFE表示当前ZigBee通讯节点没有加入网络
             * 设置ZigBee通讯节点的PANID：返回:<LF>OK<LF>或<LF>ERROR<LF>。
             */

            string text;
            if (data != null)
            {
                string @string = Encoding.Default.GetString(data);
                text = @string;
                if (@string.Contains("OK"))
                {
                    text = "设置成功";
                }
                else if (@string.Contains("ERROR"))
                {
                    text = "ERROR";
                }
                else if (@string.Contains("AT+AZ_BASE_ADDRESS=1,Z"))
                {
                    text = @string.Substring(@string.IndexOf("1,Z") + 3, 5);
                    //text = "ZigBeee通讯节点硬件地址： " + strCL; 
                    this.HA = text;
                }
                else if (@string.Contains("AT+AZ_Z_NODE="))
                {
                    text = @string.Substring(@string.IndexOf("=") + 1);

                    if (text.ToUpper().Contains("C"))
                    {
                        // text = "ZigBee通讯节点类型： 协调器";
                        text = "C";
                    }
                    if (text.ToUpper().Contains("R"))
                    {
                        // text = "ZigBee通讯节点类型： 路由器";
                        text = "R";
                    }
                    this.NODE = text;
                }
                else if (@string.Contains("AT+AZ_Z_CHANNEL="))
                {
                    //text = "ZigBee通讯节点的信道： " + @string.Substring(@string.IndexOf("=") + 1, 2);
                    text = @string.Substring(@string.IndexOf("=") + 1, 2);
                    this.CHANNEL = text;
                }
                else if (@string.Contains("AT+AZ_Z_PAN_ID="))
                {
                    text = @string.Substring(@string.IndexOf("=") + 1, 4);
                    if (text.Contains("FFFE"))
                    {
                        //text = "ZigBee通讯节点的PANID： 未加入网络";
                        text = "未加入网络";
                    }
                    else if (text.Contains("199B"))
                    {
                        //text = "ZigBee通讯节点的PANID： 199B（出厂值）";
                        text = "199B（出厂值）";
                    }
                    else
                    {
                        //text = "ZigBee通讯节点的PANID： " + text;
                        //text = text;
                    }
                    this.PI = text;
                }
            }
            else
                text = "null";
            sph.ClearSPRecv();
            return text;
        }
    }
}
