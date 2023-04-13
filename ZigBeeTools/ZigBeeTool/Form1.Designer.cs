namespace ZigBeeTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pOne = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCOMNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBaudrate = new System.Windows.Forms.ComboBox();
            this.btnOSP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOWM = new System.Windows.Forms.Button();
            this.rbZigbeeConfig = new System.Windows.Forms.RadioButton();
            this.rbZCDM = new System.Windows.Forms.RadioButton();
            this.pTwo = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSettingHA = new System.Windows.Forms.Button();
            this.btnSelectHA = new System.Windows.Forms.Button();
            this.txtResultHA = new System.Windows.Forms.TextBox();
            this.txtSettingHA = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSettingNT = new System.Windows.Forms.Button();
            this.btnSelectNT = new System.Windows.Forms.Button();
            this.txtResultND = new System.Windows.Forms.TextBox();
            this.cbxND = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSettingCN = new System.Windows.Forms.Button();
            this.btnSelectCN = new System.Windows.Forms.Button();
            this.txtResultCN = new System.Windows.Forms.TextBox();
            this.cbxCN = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSettingPI = new System.Windows.Forms.Button();
            this.btnSelectPI = new System.Windows.Forms.Button();
            this.txtResultPI = new System.Windows.Forms.TextBox();
            this.cbxPI = new System.Windows.Forms.ComboBox();
            this.btnTwoBackToMain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pThree = new System.Windows.Forms.Panel();
            this.btnThreeBackToMain = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.picfixed = new System.Windows.Forms.PictureBox();
            this.picWaterimm = new System.Windows.Forms.PictureBox();
            this.picGasfired = new System.Windows.Forms.PictureBox();
            this.picSmoke = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtFixedHA = new System.Windows.Forms.TextBox();
            this.txtWaterimmHA = new System.Windows.Forms.TextBox();
            this.txtGasFiredHA = new System.Windows.Forms.TextBox();
            this.txtSmokeHA = new System.Windows.Forms.TextBox();
            this.btnSaveHA = new System.Windows.Forms.Button();
            this.btnClearHA = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pOne.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pTwo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pThree.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfixed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWaterimm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGasfired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmoke)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // pOne
            // 
            this.pOne.BackColor = System.Drawing.SystemColors.Control;
            this.pOne.Controls.Add(this.groupBox2);
            this.pOne.Controls.Add(this.groupBox1);
            this.pOne.Location = new System.Drawing.Point(3, 3);
            this.pOne.Name = "pOne";
            this.pOne.Size = new System.Drawing.Size(582, 217);
            this.pOne.TabIndex = 2;
            this.pOne.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOSP);
            this.groupBox1.Controls.Add(this.cbxBaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxCOMNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第一步：打开串口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择串口号：";
            // 
            // cbxCOMNumber
            // 
            this.cbxCOMNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCOMNumber.Font = new System.Drawing.Font("宋体", 9F);
            this.cbxCOMNumber.FormattingEnabled = true;
            this.cbxCOMNumber.Location = new System.Drawing.Point(117, 38);
            this.cbxCOMNumber.Name = "cbxCOMNumber";
            this.cbxCOMNumber.Size = new System.Drawing.Size(109, 20);
            this.cbxCOMNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(251, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择波特率：";
            // 
            // cbxBaudrate
            // 
            this.cbxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudrate.Font = new System.Drawing.Font("宋体", 9F);
            this.cbxBaudrate.FormattingEnabled = true;
            this.cbxBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600"});
            this.cbxBaudrate.Location = new System.Drawing.Point(334, 38);
            this.cbxBaudrate.Name = "cbxBaudrate";
            this.cbxBaudrate.Size = new System.Drawing.Size(109, 20);
            this.cbxBaudrate.TabIndex = 3;
            // 
            // btnOSP
            // 
            this.btnOSP.Font = new System.Drawing.Font("宋体", 9F);
            this.btnOSP.Location = new System.Drawing.Point(449, 36);
            this.btnOSP.Name = "btnOSP";
            this.btnOSP.Size = new System.Drawing.Size(75, 23);
            this.btnOSP.TabIndex = 4;
            this.btnOSP.Text = "打开";
            this.btnOSP.UseVisualStyleBackColor = true;
            this.btnOSP.Click += new System.EventHandler(this.btnOSP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbZCDM);
            this.groupBox2.Controls.Add(this.rbZigbeeConfig);
            this.groupBox2.Controls.Add(this.btnOWM);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(3, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 92);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第二步：选择工作模式";
            // 
            // btnOWM
            // 
            this.btnOWM.Font = new System.Drawing.Font("宋体", 9F);
            this.btnOWM.Location = new System.Drawing.Point(449, 40);
            this.btnOWM.Name = "btnOWM";
            this.btnOWM.Size = new System.Drawing.Size(75, 23);
            this.btnOWM.TabIndex = 4;
            this.btnOWM.Text = "打开";
            this.btnOWM.UseVisualStyleBackColor = true;
            this.btnOWM.Click += new System.EventHandler(this.btnOpenWorkingMode_Click);
            // 
            // rbZigbeeConfig
            // 
            this.rbZigbeeConfig.AutoSize = true;
            this.rbZigbeeConfig.Checked = true;
            this.rbZigbeeConfig.Font = new System.Drawing.Font("宋体", 9F);
            this.rbZigbeeConfig.Location = new System.Drawing.Point(36, 43);
            this.rbZigbeeConfig.Name = "rbZigbeeConfig";
            this.rbZigbeeConfig.Size = new System.Drawing.Size(107, 16);
            this.rbZigbeeConfig.TabIndex = 5;
            this.rbZigbeeConfig.TabStop = true;
            this.rbZigbeeConfig.Text = "ZigBee配置模式";
            this.rbZigbeeConfig.UseVisualStyleBackColor = true;
            // 
            // rbZCDM
            // 
            this.rbZCDM.AutoSize = true;
            this.rbZCDM.Font = new System.Drawing.Font("宋体", 9F);
            this.rbZCDM.Location = new System.Drawing.Point(253, 43);
            this.rbZCDM.Name = "rbZCDM";
            this.rbZCDM.Size = new System.Drawing.Size(131, 16);
            this.rbZCDM.TabIndex = 6;
            this.rbZCDM.Text = "ZigBee通信检测模式";
            this.rbZCDM.UseVisualStyleBackColor = true;
            // 
            // pTwo
            // 
            this.pTwo.BackColor = System.Drawing.SystemColors.Control;
            this.pTwo.Controls.Add(this.btnTwoBackToMain);
            this.pTwo.Controls.Add(this.groupBox6);
            this.pTwo.Controls.Add(this.groupBox5);
            this.pTwo.Controls.Add(this.groupBox4);
            this.pTwo.Controls.Add(this.groupBox3);
            this.pTwo.Location = new System.Drawing.Point(13, 12);
            this.pTwo.Name = "pTwo";
            this.pTwo.Size = new System.Drawing.Size(590, 398);
            this.pTwo.TabIndex = 19;
            this.pTwo.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSettingHA);
            this.groupBox3.Controls.Add(this.txtResultHA);
            this.groupBox3.Controls.Add(this.btnSelectHA);
            this.groupBox3.Controls.Add(this.btnSettingHA);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(23, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 72);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "第一步：设置和查询ZigBee硬件地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(42, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "选择硬件地址（ 01～99 ）：";
            // 
            // btnSettingHA
            // 
            this.btnSettingHA.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSettingHA.Location = new System.Drawing.Point(281, 29);
            this.btnSettingHA.Name = "btnSettingHA";
            this.btnSettingHA.Size = new System.Drawing.Size(75, 23);
            this.btnSettingHA.TabIndex = 2;
            this.btnSettingHA.Text = "设置";
            this.btnSettingHA.UseVisualStyleBackColor = true;
            this.btnSettingHA.Click += new System.EventHandler(this.btnSettingHA_Click);
            // 
            // btnSelectHA
            // 
            this.btnSelectHA.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSelectHA.Location = new System.Drawing.Point(368, 29);
            this.btnSelectHA.Name = "btnSelectHA";
            this.btnSelectHA.Size = new System.Drawing.Size(75, 23);
            this.btnSelectHA.TabIndex = 3;
            this.btnSelectHA.Text = "查询";
            this.btnSelectHA.UseVisualStyleBackColor = true;
            this.btnSelectHA.Click += new System.EventHandler(this.btnSelectHA_Click);
            // 
            // txtResultHA
            // 
            this.txtResultHA.Font = new System.Drawing.Font("宋体", 9F);
            this.txtResultHA.Location = new System.Drawing.Point(449, 29);
            this.txtResultHA.Name = "txtResultHA";
            this.txtResultHA.ReadOnly = true;
            this.txtResultHA.Size = new System.Drawing.Size(76, 21);
            this.txtResultHA.TabIndex = 5;
            // 
            // txtSettingHA
            // 
            this.txtSettingHA.Font = new System.Drawing.Font("宋体", 9F);
            this.txtSettingHA.Location = new System.Drawing.Point(203, 31);
            this.txtSettingHA.MaxLength = 2;
            this.txtSettingHA.Name = "txtSettingHA";
            this.txtSettingHA.Size = new System.Drawing.Size(72, 21);
            this.txtSettingHA.TabIndex = 8;
            this.txtSettingHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSettingHA_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxND);
            this.groupBox4.Controls.Add(this.txtResultND);
            this.groupBox4.Controls.Add(this.btnSelectNT);
            this.groupBox4.Controls.Add(this.btnSettingNT);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(23, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 72);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "第二步：设置和查询ZigBee节点类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.Location = new System.Drawing.Point(36, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "选择节点类型（ C 或 R ）：";
            // 
            // btnSettingNT
            // 
            this.btnSettingNT.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSettingNT.Location = new System.Drawing.Point(281, 29);
            this.btnSettingNT.Name = "btnSettingNT";
            this.btnSettingNT.Size = new System.Drawing.Size(75, 23);
            this.btnSettingNT.TabIndex = 2;
            this.btnSettingNT.Text = "设置";
            this.btnSettingNT.UseVisualStyleBackColor = true;
            this.btnSettingNT.Click += new System.EventHandler(this.btnSettingNT_Click);
            // 
            // btnSelectNT
            // 
            this.btnSelectNT.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSelectNT.Location = new System.Drawing.Point(368, 29);
            this.btnSelectNT.Name = "btnSelectNT";
            this.btnSelectNT.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNT.TabIndex = 3;
            this.btnSelectNT.Text = "查询";
            this.btnSelectNT.UseVisualStyleBackColor = true;
            this.btnSelectNT.Click += new System.EventHandler(this.btnSelectNT_Click);
            // 
            // txtResultND
            // 
            this.txtResultND.Font = new System.Drawing.Font("宋体", 9F);
            this.txtResultND.Location = new System.Drawing.Point(449, 31);
            this.txtResultND.Name = "txtResultND";
            this.txtResultND.ReadOnly = true;
            this.txtResultND.Size = new System.Drawing.Size(76, 21);
            this.txtResultND.TabIndex = 6;
            // 
            // cbxND
            // 
            this.cbxND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxND.Font = new System.Drawing.Font("宋体", 9F);
            this.cbxND.FormattingEnabled = true;
            this.cbxND.Items.AddRange(new object[] {
            "C",
            "R"});
            this.cbxND.Location = new System.Drawing.Point(203, 31);
            this.cbxND.Name = "cbxND";
            this.cbxND.Size = new System.Drawing.Size(72, 20);
            this.cbxND.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbxCN);
            this.groupBox5.Controls.Add(this.txtResultCN);
            this.groupBox5.Controls.Add(this.btnSelectCN);
            this.groupBox5.Controls.Add(this.btnSettingCN);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(23, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(542, 72);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "第三步：设置和查询ZigBee信道号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(18, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "选择信道号（ 范围 11～26 ）：";
            // 
            // btnSettingCN
            // 
            this.btnSettingCN.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSettingCN.Location = new System.Drawing.Point(281, 29);
            this.btnSettingCN.Name = "btnSettingCN";
            this.btnSettingCN.Size = new System.Drawing.Size(75, 23);
            this.btnSettingCN.TabIndex = 2;
            this.btnSettingCN.Text = "设置";
            this.btnSettingCN.UseVisualStyleBackColor = true;
            this.btnSettingCN.Click += new System.EventHandler(this.btnSettingCN_Click);
            // 
            // btnSelectCN
            // 
            this.btnSelectCN.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSelectCN.Location = new System.Drawing.Point(368, 29);
            this.btnSelectCN.Name = "btnSelectCN";
            this.btnSelectCN.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCN.TabIndex = 3;
            this.btnSelectCN.Text = "查询";
            this.btnSelectCN.UseVisualStyleBackColor = true;
            this.btnSelectCN.Click += new System.EventHandler(this.btnSelectCN_Click);
            // 
            // txtResultCN
            // 
            this.txtResultCN.Font = new System.Drawing.Font("宋体", 9F);
            this.txtResultCN.Location = new System.Drawing.Point(449, 31);
            this.txtResultCN.Name = "txtResultCN";
            this.txtResultCN.ReadOnly = true;
            this.txtResultCN.Size = new System.Drawing.Size(76, 21);
            this.txtResultCN.TabIndex = 7;
            // 
            // cbxCN
            // 
            this.cbxCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCN.Font = new System.Drawing.Font("宋体", 9F);
            this.cbxCN.FormattingEnabled = true;
            this.cbxCN.Location = new System.Drawing.Point(203, 31);
            this.cbxCN.Name = "cbxCN";
            this.cbxCN.Size = new System.Drawing.Size(72, 20);
            this.cbxCN.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxPI);
            this.groupBox6.Controls.Add(this.txtResultPI);
            this.groupBox6.Controls.Add(this.btnSelectPI);
            this.groupBox6.Controls.Add(this.btnSettingPI);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(23, 262);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(542, 72);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "第四步：设置和查询ZigBee PAN_ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.Location = new System.Drawing.Point(24, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "选择PAN_ID（ 范围 1～9 ）：";
            // 
            // btnSettingPI
            // 
            this.btnSettingPI.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSettingPI.Location = new System.Drawing.Point(281, 29);
            this.btnSettingPI.Name = "btnSettingPI";
            this.btnSettingPI.Size = new System.Drawing.Size(75, 23);
            this.btnSettingPI.TabIndex = 2;
            this.btnSettingPI.Text = "设置";
            this.btnSettingPI.UseVisualStyleBackColor = true;
            this.btnSettingPI.Click += new System.EventHandler(this.btnSelectPI_Click);
            // 
            // btnSelectPI
            // 
            this.btnSelectPI.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSelectPI.Location = new System.Drawing.Point(368, 29);
            this.btnSelectPI.Name = "btnSelectPI";
            this.btnSelectPI.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPI.TabIndex = 3;
            this.btnSelectPI.Text = "查询";
            this.btnSelectPI.UseVisualStyleBackColor = true;
            this.btnSelectPI.Click += new System.EventHandler(this.btnSelectPI_Click);
            // 
            // txtResultPI
            // 
            this.txtResultPI.Font = new System.Drawing.Font("宋体", 9F);
            this.txtResultPI.Location = new System.Drawing.Point(449, 29);
            this.txtResultPI.Name = "txtResultPI";
            this.txtResultPI.ReadOnly = true;
            this.txtResultPI.Size = new System.Drawing.Size(76, 21);
            this.txtResultPI.TabIndex = 8;
            // 
            // cbxPI
            // 
            this.cbxPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPI.Font = new System.Drawing.Font("宋体", 9F);
            this.cbxPI.FormattingEnabled = true;
            this.cbxPI.Location = new System.Drawing.Point(203, 30);
            this.cbxPI.Name = "cbxPI";
            this.cbxPI.Size = new System.Drawing.Size(72, 20);
            this.cbxPI.TabIndex = 9;
            // 
            // btnTwoBackToMain
            // 
            this.btnTwoBackToMain.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTwoBackToMain.Location = new System.Drawing.Point(422, 340);
            this.btnTwoBackToMain.Name = "btnTwoBackToMain";
            this.btnTwoBackToMain.Size = new System.Drawing.Size(143, 33);
            this.btnTwoBackToMain.TabIndex = 12;
            this.btnTwoBackToMain.Text = "返回";
            this.btnTwoBackToMain.UseVisualStyleBackColor = true;
            this.btnTwoBackToMain.Click += new System.EventHandler(this.btnTwoBackToMain_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pThree);
            this.panel1.Controls.Add(this.pOne);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 414);
            this.panel1.TabIndex = 3;
            // 
            // pThree
            // 
            this.pThree.BackColor = System.Drawing.SystemColors.Control;
            this.pThree.Controls.Add(this.btnThreeBackToMain);
            this.pThree.Controls.Add(this.groupBox7);
            this.pThree.Controls.Add(this.groupBox8);
            this.pThree.Location = new System.Drawing.Point(3, 0);
            this.pThree.Name = "pThree";
            this.pThree.Size = new System.Drawing.Size(607, 402);
            this.pThree.TabIndex = 28;
            this.pThree.Visible = false;
            // 
            // btnThreeBackToMain
            // 
            this.btnThreeBackToMain.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnThreeBackToMain.Location = new System.Drawing.Point(451, 355);
            this.btnThreeBackToMain.Name = "btnThreeBackToMain";
            this.btnThreeBackToMain.Size = new System.Drawing.Size(143, 33);
            this.btnThreeBackToMain.TabIndex = 13;
            this.btnThreeBackToMain.Text = "返回";
            this.btnThreeBackToMain.UseVisualStyleBackColor = true;
            this.btnThreeBackToMain.Click += new System.EventHandler(this.btnThreeBackToMain_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.picfixed);
            this.groupBox7.Controls.Add(this.picWaterimm);
            this.groupBox7.Controls.Add(this.picGasfired);
            this.groupBox7.Controls.Add(this.picSmoke);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(21, 202);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(573, 147);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "第二步：实时监测";
            // 
            // picfixed
            // 
            this.picfixed.Image = ((System.Drawing.Image)(resources.GetObject("picfixed.Image")));
            this.picfixed.Location = new System.Drawing.Point(430, 91);
            this.picfixed.Name = "picfixed";
            this.picfixed.Size = new System.Drawing.Size(50, 50);
            this.picfixed.TabIndex = 10;
            this.picfixed.TabStop = false;
            // 
            // picWaterimm
            // 
            this.picWaterimm.Image = ((System.Drawing.Image)(resources.GetObject("picWaterimm.Image")));
            this.picWaterimm.Location = new System.Drawing.Point(155, 91);
            this.picWaterimm.Name = "picWaterimm";
            this.picWaterimm.Size = new System.Drawing.Size(50, 50);
            this.picWaterimm.TabIndex = 9;
            this.picWaterimm.TabStop = false;
            // 
            // picGasfired
            // 
            this.picGasfired.Image = ((System.Drawing.Image)(resources.GetObject("picGasfired.Image")));
            this.picGasfired.Location = new System.Drawing.Point(430, 21);
            this.picGasfired.Name = "picGasfired";
            this.picGasfired.Size = new System.Drawing.Size(50, 50);
            this.picGasfired.TabIndex = 8;
            this.picGasfired.TabStop = false;
            // 
            // picSmoke
            // 
            this.picSmoke.Image = ((System.Drawing.Image)(resources.GetObject("picSmoke.Image")));
            this.picSmoke.Location = new System.Drawing.Point(155, 21);
            this.picSmoke.Name = "picSmoke";
            this.picSmoke.Size = new System.Drawing.Size(50, 50);
            this.picSmoke.TabIndex = 7;
            this.picSmoke.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(371, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "固定报警";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F);
            this.label8.Location = new System.Drawing.Point(96, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "水浸报警";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F);
            this.label9.Location = new System.Drawing.Point(347, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "可燃气体报警";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F);
            this.label10.Location = new System.Drawing.Point(96, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "烟雾报警";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtFixedHA);
            this.groupBox8.Controls.Add(this.txtWaterimmHA);
            this.groupBox8.Controls.Add(this.txtGasFiredHA);
            this.groupBox8.Controls.Add(this.txtSmokeHA);
            this.groupBox8.Controls.Add(this.btnSaveHA);
            this.groupBox8.Controls.Add(this.btnClearHA);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox8.Location = new System.Drawing.Point(21, 25);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(573, 161);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "第一步：硬件地址映射";
            // 
            // txtFixedHA
            // 
            this.txtFixedHA.Font = new System.Drawing.Font("宋体", 9F);
            this.txtFixedHA.Location = new System.Drawing.Point(430, 71);
            this.txtFixedHA.MaxLength = 2;
            this.txtFixedHA.Name = "txtFixedHA";
            this.txtFixedHA.Size = new System.Drawing.Size(121, 21);
            this.txtFixedHA.TabIndex = 13;
            this.txtFixedHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFixedHA_KeyPress);
            // 
            // txtWaterimmHA
            // 
            this.txtWaterimmHA.Font = new System.Drawing.Font("宋体", 9F);
            this.txtWaterimmHA.Location = new System.Drawing.Point(155, 71);
            this.txtWaterimmHA.MaxLength = 2;
            this.txtWaterimmHA.Name = "txtWaterimmHA";
            this.txtWaterimmHA.Size = new System.Drawing.Size(121, 21);
            this.txtWaterimmHA.TabIndex = 12;
            this.txtWaterimmHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWaterimmHA_KeyPress);
            // 
            // txtGasFiredHA
            // 
            this.txtGasFiredHA.Font = new System.Drawing.Font("宋体", 9F);
            this.txtGasFiredHA.Location = new System.Drawing.Point(430, 29);
            this.txtGasFiredHA.MaxLength = 2;
            this.txtGasFiredHA.Name = "txtGasFiredHA";
            this.txtGasFiredHA.Size = new System.Drawing.Size(121, 21);
            this.txtGasFiredHA.TabIndex = 11;
            this.txtGasFiredHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGasFiredHA_KeyPress);
            // 
            // txtSmokeHA
            // 
            this.txtSmokeHA.Font = new System.Drawing.Font("宋体", 9F);
            this.txtSmokeHA.Location = new System.Drawing.Point(155, 29);
            this.txtSmokeHA.MaxLength = 2;
            this.txtSmokeHA.Name = "txtSmokeHA";
            this.txtSmokeHA.Size = new System.Drawing.Size(121, 21);
            this.txtSmokeHA.TabIndex = 10;
            this.txtSmokeHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSmokeHA_KeyPress);
            // 
            // btnSaveHA
            // 
            this.btnSaveHA.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSaveHA.Location = new System.Drawing.Point(476, 111);
            this.btnSaveHA.Name = "btnSaveHA";
            this.btnSaveHA.Size = new System.Drawing.Size(75, 23);
            this.btnSaveHA.TabIndex = 9;
            this.btnSaveHA.Text = "保存";
            this.btnSaveHA.UseVisualStyleBackColor = true;
            this.btnSaveHA.Click += new System.EventHandler(this.btnSaveHA_Click);
            // 
            // btnClearHA
            // 
            this.btnClearHA.Font = new System.Drawing.Font("宋体", 9F);
            this.btnClearHA.Location = new System.Drawing.Point(325, 111);
            this.btnClearHA.Name = "btnClearHA";
            this.btnClearHA.Size = new System.Drawing.Size(75, 23);
            this.btnClearHA.TabIndex = 8;
            this.btnClearHA.Text = "清空";
            this.btnClearHA.UseVisualStyleBackColor = true;
            this.btnClearHA.Click += new System.EventHandler(this.btnClearHA_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F);
            this.label11.Location = new System.Drawing.Point(323, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "固定报警器地址：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F);
            this.label12.Location = new System.Drawing.Point(48, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "水浸探测器地址：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F);
            this.label13.Location = new System.Drawing.Point(299, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "可燃气体探测器地址：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(48, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "烟雾报警器地址：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 457);
            this.Controls.Add(this.pTwo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZigBee配置工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pOne.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pTwo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pThree.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picfixed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWaterimm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGasfired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmoke)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pOne;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbZCDM;
        private System.Windows.Forms.RadioButton rbZigbeeConfig;
        private System.Windows.Forms.Button btnOWM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOSP;
        private System.Windows.Forms.ComboBox cbxBaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCOMNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pTwo;
        private System.Windows.Forms.Button btnTwoBackToMain;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbxPI;
        private System.Windows.Forms.TextBox txtResultPI;
        private System.Windows.Forms.Button btnSelectPI;
        private System.Windows.Forms.Button btnSettingPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbxCN;
        private System.Windows.Forms.TextBox txtResultCN;
        private System.Windows.Forms.Button btnSelectCN;
        private System.Windows.Forms.Button btnSettingCN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbxND;
        private System.Windows.Forms.TextBox txtResultND;
        private System.Windows.Forms.Button btnSelectNT;
        private System.Windows.Forms.Button btnSettingNT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSettingHA;
        private System.Windows.Forms.TextBox txtResultHA;
        private System.Windows.Forms.Button btnSelectHA;
        private System.Windows.Forms.Button btnSettingHA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pThree;
        private System.Windows.Forms.Button btnThreeBackToMain;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox picfixed;
        private System.Windows.Forms.PictureBox picWaterimm;
        private System.Windows.Forms.PictureBox picGasfired;
        private System.Windows.Forms.PictureBox picSmoke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtFixedHA;
        private System.Windows.Forms.TextBox txtWaterimmHA;
        private System.Windows.Forms.TextBox txtGasFiredHA;
        private System.Windows.Forms.TextBox txtSmokeHA;
        private System.Windows.Forms.Button btnSaveHA;
        private System.Windows.Forms.Button btnClearHA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;


    }
}

