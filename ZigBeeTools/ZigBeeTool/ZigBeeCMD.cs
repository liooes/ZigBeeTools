using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZigBeeTool
{
    public class ZigBeeCMD
    {
        /// <summary>
        /// 查询硬件地址 
        /// </summary>
        public string selectZigbeeHA = "AT+AZ_BASE_ADDRESS=1";

        /// <summary>
        /// 设置硬件地址
        /// </summary>
        public string settingZigbeeHA = "AT+AZ_BASE_ADDRESS=0,Z";

        /// <summary>
        /// 查询ZigBee通讯节点的类型
        /// </summary>
        public string selectZigbeeNODE = "AT+R_AZ_Z_NODE";

        /// <summary>
        /// 设置ZigBee通讯节点的类型
        /// </summary>
        public string settingZigbeeNODE = "AT+AZ_Z_NODE=";

        /// <summary>
        /// 查询ZigBee通讯节点的CHANNEL
        /// </summary>
        public string selectZigbeeCHANNEL = "AT+R_AZ_Z_CHANNEL";

        /// <summary>
        /// 设置ZigBee通讯节点的CHANNEL
        /// </summary>
        public string settingZigbeeCHANNEL = "AT+AZ_Z_CHANNEL=";

        /// <summary>
        /// 查询ZigBee通讯节点的PANID
        /// </summary>
        public string selectZigbeePANID = "AT+R_AZ_Z_PAN_ID";

        /// <summary>
        /// 设置ZigBee通讯节点的PANID
        /// </summary>
        public string settingZigbeePANID = "AT+AZ_Z_PAN_ID=";
    }
}
