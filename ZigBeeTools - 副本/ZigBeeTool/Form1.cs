using SerialPortHelpers;
using System;
using System.Collections;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ZigBeeTool.Properties;
 

namespace ZigBeeTool
{
    public partial class Form1 : Form
    { 
        int panel = 1;  
        ArrayList list = new ArrayList();
        SerialPortHelper sph;
        ZigBeeCMD zcmd = new ZigBeeCMD();
        ZigBeeCommMode zcm;
        Thread thListenReportData;

        string strSmoke = "";
        string strGasfired = "";
        string strWaterimm = "";
        string strfixed = "";

        string strHA = "";
        /// <summary>
        /// 定义图片状态回调委托
        /// </summary>
        /// <param name="zcm"></param>
        delegate void setPicSatateCallBack(ZigBeeCommMode zcm);
        /// <summary>
        /// 声明设置状态回调委托类型
        /// </summary>
        setPicSatateCallBack setState;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //载入本机串口列表
            SetComItem(); 
            //载入信道列表
            LoadChannel();
            //载入PANID列表
            LoadPANID();
            //设置默认选项
            LoadCbxData();
            ShowPanel(panel);
            
        }

        private void LoadPANID()
        {
            for (int i = 1; i <= 9; i++)
                cbxPI.Items.Add(i);
        }

        private void LoadChannel()
        {
            for (int i = 11; i <= 26; i++)
                cbxCN.Items.Add(i);
        }

        private void LoadCbxData()
        { 
           cbxCOMNumber.SelectedIndex = 0;
            cbxND.SelectedIndex = 0;
           cbxBaudrate.SelectedIndex = 2;
           cbxCN.SelectedIndex = 0;
           cbxPI.SelectedIndex = 0;
        }

        private void SetComItem()
        {
            string[] itm = SerialPort.GetPortNames();
            for (int i = 0; i < itm.Length; i++)
                cbxCOMNumber.Items.Add(itm[i]);
        }
         

        /// <summary>
        /// 显示面板
        /// </summary>
        /// <param name="panel">1：主面板   2、ZigBee配置查询面板  3、实时监测面板</param>
        private void ShowPanel(int panel)
        {
            switch (panel)
            {
                case 1: { 
                    pOne.Visible = true;
                    pTwo.Visible = false;
                 pThree.Visible = false;  
                    this.Size = new Size(590,265);
                } break;
               case 2:
                    {
                        pOne.Visible = false;
                        pTwo.Visible = true;
                       pThree.Visible = false;
                        this.Size = new Size(650,450);
                    } break;
                case 3:
                    {
                        pOne.Visible = false;
                        pTwo.Visible = false;
                      pThree.Visible = true;
                        this.Size = new Size(666, 460);
                    } break; 
            }
        }
         

        /// <summary>
        /// 打开指定工作模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenWorkingMode_Click(object sender, EventArgs e)
        {
            if (rbZigbeeConfig.Checked && btnOSP.Text.Equals("关闭"))
                ShowPanel(2);
            else if (rbZCDM.Checked && btnOSP.Text.Equals("关闭"))
                ShowPanel(3);
            else
                MessageBox.Show("确保串口为打开状态并择一工作模式", "温馨提示", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
         
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOSP_Click(object sender, EventArgs e)
        {  
            if (cbxCOMNumber.Text != null && !cbxCOMNumber.Text.Equals("") && btnOSP.Text.Equals("打开"))
            {
                sph = new SerialPortHelper(cbxCOMNumber.Text, cbxBaudrate.Text);
                zcm = new ZigBeeCommMode(cbxCOMNumber.Text, cbxBaudrate.Text);
               // sph.OpenSerialPort();
                btnOSP.Text = "关闭";
            }
            else
            {
                if(sph!= null)
                    sph.CloseSerialPort();
                btnOSP.Text = "打开";
            }
        }

        /// <summary>
        /// 设置硬件地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettingHA_Click(object sender, EventArgs e)
        {
             strHA = addZero(txtSettingHA.Text);//自动补0
            string res = zcm.SettingMode(zcmd.settingZigbeeHA + "00" + strHA); Thread.Sleep(1000);
             
        }

        /// <summary>
        /// 查询硬件地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectHA_Click(object sender, EventArgs e)
        {
            string res = zcm.SelectMode(zcmd.selectZigbeeHA);
            txtResultHA.Text = rmZero(res.Substring(2, 2));//截取后自动去0
        }

        /// <summary>
        /// 设置节点类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettingNT_Click(object sender, EventArgs e)
        {
            string strsetnd = zcm.SettingMode(zcmd.settingZigbeeNODE + cbxND.Text); 
        }

        /// <summary>
        /// 查询节点类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectNT_Click(object sender, EventArgs e)
        {
            string strrevnd = zcm.SelectMode(zcmd.selectZigbeeNODE);
            txtResultND.Text = strrevnd;
        }

        /// <summary>
        /// 设置信道号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettingCN_Click(object sender, EventArgs e)
        {
            string res = zcm.SettingMode(zcmd.settingZigbeeCHANNEL + cbxCN.Text); 
        }

        /// <summary>
        /// 查询信道号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectCN_Click(object sender, EventArgs e)
        {
            string res = zcm.SelectMode(zcmd.selectZigbeeCHANNEL);
            txtResultCN.Text = res;
        }

        /// <summary>
        /// 设置PANID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSettingPI_Click(object sender, EventArgs e)
        {
            string strHA = zcm.SelectMode(zcmd.selectZigbeeHA);
            string strCLHA = strHA.Substring(0, 3);//ZigBee硬件地址前三位
            string res = zcm.SettingMode(zcmd.settingZigbeePANID + strCLHA+ cbxPI.Text); 
        }

        /// <summary>
        /// 查询PANID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPI_Click(object sender, EventArgs e)
        {
            string res = zcm.SelectMode(zcmd.selectZigbeePANID);
            txtResultPI.Text = res.Substring(3, 1);
        }

        /// <summary>
        /// 关闭程序释放资源
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {

            try
            {
                thListenReportData.Abort();
                sph.CloseSerialPort();
                base.OnClosed(e);
            }
            catch { }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("确定关闭？", "确定关闭", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            base.OnClosing(e);
        }

        /// <summary>
        /// 清空设备硬件地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearHA_Click(object sender, EventArgs e)
        {
            txtSmokeHA.Text = "";
            txtGasFiredHA.Text = "";
            txtWaterimmHA.Text = "";
            txtFixedHA.Text = "";
        }

        /// <summary>
        /// 保存参数开始监测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveHA_Click(object sender, EventArgs e)
        {  
            strSmoke = addZero(txtSmokeHA.Text);//自动补0
            strWaterimm = addZero(txtWaterimmHA.Text);//自动补0
            strGasfired = addZero(txtGasFiredHA.Text);//自动补0
            strfixed = addZero(txtFixedHA.Text);//自动补0

            MessageBox.Show("保存成功", "温馨提示", MessageBoxButtons.OK);
            setState = new setPicSatateCallBack(setPic);
            thListenReportData = new Thread(new ThreadStart(ListenReportData));
            thListenReportData.IsBackground = true;
            thListenReportData.Start();


        }

        /// <summary>
        /// 监听上报数据
        /// </summary>
        private void ListenReportData()
        {
            while (true)
            {
                zcm.GetRoterReportData();//获取上报数据（数据存储在对象里）
                if (zcm.ModelState != null && !zcm.ModelState.Equals(""))
                {
                    if (zcm.HA.Equals(strSmoke))
                        picSmoke.Invoke(setState, zcm);
                    else if (zcm.HA.Equals(strWaterimm))
                        picWaterimm.Invoke(setState, zcm);
                    else if (zcm.HA.Equals(strGasfired))
                        picGasfired.Invoke(setState, zcm);
                    else if (zcm.HA.Equals(strfixed))
                        picfixed.Invoke(setState, zcm);
                }
            }
        }

        /// <summary>
        /// 回调设置图片状态
        /// </summary>
        /// <param name="zcm">无线通讯节点模块对象</param>
        private void setPic(ZigBeeCommMode zcm)
        {
            if (zcm != null && !zcm.ModelState.Equals(""))
            {
                if (zcm.HA.Equals(strSmoke))
                    SetPicState(picSmoke, zcm.ModelState);
                else if (zcm.HA.Equals(strWaterimm))
                    SetPicState(picWaterimm, zcm.ModelState);
                else if (zcm.HA.Equals(strGasfired))
                    SetPicState(picGasfired, zcm.ModelState);
                else if (zcm.HA.Equals(strfixed))
                    SetPicState(picfixed, zcm.ModelState);
            }
        }

        /// <summary>
        /// 设置图片状态
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="state"></param>
        void SetPicState(PictureBox pic,string state)
         {
             if (state.Equals("0"))
                 pic.Image = Resources.img_state_red;
             else
                 pic.Image = Resources.img_state_green;
         }

        /// <summary>
        /// 配置界面返回主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwoBackToMain_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
        }

        /// <summary>
        /// 监听界面返回主界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThreeBackToMain_Click(object sender, EventArgs e)
        {
            ShowPanel(1);
            try
            {
                thListenReportData.Abort();
            }
            catch { }
        }

        /// <summary>
        /// 限制输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSettingHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControlHA(e);
        }

        private void txtFixedHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControlHA(e);
        }

        private void txtGasFiredHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControlHA(e);
        }

        private void txtSmokeHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControlHA(e);
        }

        private void txtWaterimmHA_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputControlHA(e);
        }

        /// <summary>
        /// 控制输入为数字
        /// </summary>
        /// <param name="e"></param>
        void InputControlHA(KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))//如果不是输入数字就不让输入 
                e.Handled = true;
        }

        /// <summary>
        /// 小于等于9加0
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        string addZero(string strNumber)
        {
            if (strNumber != null && !strNumber.Equals(""))
            {
                if (int.Parse(strNumber) <= 9)
                    strNumber = "0" + strNumber;
            }

            return strNumber;
        }

        /// <summary>
        /// 小于等于9去0
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        string rmZero(string strNumber)
        {
            if (strNumber != null && !strNumber.Equals(""))
            {
                if (int.Parse(strNumber) <= 9)
                   strNumber = strNumber.Substring(1, 1);
            }

            return strNumber;
        }
    }
}
