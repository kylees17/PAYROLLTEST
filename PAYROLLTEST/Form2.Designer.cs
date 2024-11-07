namespace PAYROLLTEST
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPhicCustom = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTinNo = new System.Windows.Forms.TextBox();
            this.txtSSSnumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHdmfNo = new System.Windows.Forms.TextBox();
            this.txtSSSCustomBased = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPhicNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMonthlyRateBasisDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdpt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtdrate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTypeRate = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonthlyRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDailyRateAmtFrmMonthlyRate = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Deduction Total:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1320, 725);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee List";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(20, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1271, 573);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox5.Controls.Add(this.btn_edit);
            this.groupBox5.Controls.Add(this.btnLoad);
            this.groupBox5.Location = new System.Drawing.Point(847, 621);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 86);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Location = new System.Drawing.Point(219, 25);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(141, 37);
            this.btn_edit.TabIndex = 27;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click_2);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(30, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(147, 37);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1320, 725);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnMenu);
            this.groupBox4.Controls.Add(this.btnNew);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Location = new System.Drawing.Point(175, 616);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(883, 78);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(525, 27);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 37);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(685, 27);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(147, 39);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(358, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(147, 39);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(193, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 39);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtPhicCustom);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtTinNo);
            this.groupBox3.Controls.Add(this.txtSSSnumber);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtHdmfNo);
            this.groupBox3.Controls.Add(this.txtSSSCustomBased);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtPhicNo);
            this.groupBox3.Location = new System.Drawing.Point(30, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1257, 152);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GOVERNMENT AND ATM INFO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(389, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "PHIC CUSTOM BASED:";
            // 
            // txtPhicCustom
            // 
            this.txtPhicCustom.Location = new System.Drawing.Point(576, 42);
            this.txtPhicCustom.Name = "txtPhicCustom";
            this.txtPhicCustom.Size = new System.Drawing.Size(177, 26);
            this.txtPhicCustom.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "PHIC#:";
            // 
            // txtTinNo
            // 
            this.txtTinNo.Location = new System.Drawing.Point(693, 88);
            this.txtTinNo.Name = "txtTinNo";
            this.txtTinNo.Size = new System.Drawing.Size(229, 26);
            this.txtTinNo.TabIndex = 38;
            // 
            // txtSSSnumber
            // 
            this.txtSSSnumber.Location = new System.Drawing.Point(886, 45);
            this.txtSSSnumber.Name = "txtSSSnumber";
            this.txtSSSnumber.Size = new System.Drawing.Size(229, 26);
            this.txtSSSnumber.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(640, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 20);
            this.label20.TabIndex = 39;
            this.label20.Text = "TIN#:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "SSS CUSTOM BASED:";
            // 
            // txtHdmfNo
            // 
            this.txtHdmfNo.Location = new System.Drawing.Point(417, 85);
            this.txtHdmfNo.Name = "txtHdmfNo";
            this.txtHdmfNo.Size = new System.Drawing.Size(198, 26);
            this.txtHdmfNo.TabIndex = 36;
            // 
            // txtSSSCustomBased
            // 
            this.txtSSSCustomBased.Location = new System.Drawing.Point(194, 40);
            this.txtSSSCustomBased.Name = "txtSSSCustomBased";
            this.txtSSSCustomBased.Size = new System.Drawing.Size(177, 26);
            this.txtSSSCustomBased.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 37;
            this.label13.Text = "HDMF#:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(825, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "SSS#:";
            // 
            // txtPhicNo
            // 
            this.txtPhicNo.Location = new System.Drawing.Point(113, 85);
            this.txtPhicNo.Name = "txtPhicNo";
            this.txtPhicNo.Size = new System.Drawing.Size(194, 26);
            this.txtPhicNo.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMonthlyRateBasisDays);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtdpt);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtdrate);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtposition);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtTypeRate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMonthlyRate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEmpID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDailyRateAmtFrmMonthlyRate);
            this.groupBox2.Controls.Add(this.txtfname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(30, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1257, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFO";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMonthlyRateBasisDays
            // 
            this.txtMonthlyRateBasisDays.Location = new System.Drawing.Point(706, 150);
            this.txtMonthlyRateBasisDays.Name = "txtMonthlyRateBasisDays";
            this.txtMonthlyRateBasisDays.Size = new System.Drawing.Size(244, 26);
            this.txtMonthlyRateBasisDays.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "MONTHLY RATE BASIS (DAYS):";
            // 
            // txtdpt
            // 
            this.txtdpt.Location = new System.Drawing.Point(170, 98);
            this.txtdpt.Name = "txtdpt";
            this.txtdpt.Size = new System.Drawing.Size(229, 26);
            this.txtdpt.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(65, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 20);
            this.label21.TabIndex = 31;
            this.label21.Text = "Department:";
            // 
            // txtdrate
            // 
            this.txtdrate.Location = new System.Drawing.Point(142, 194);
            this.txtdrate.Name = "txtdrate";
            this.txtdrate.Size = new System.Drawing.Size(229, 26);
            this.txtdrate.TabIndex = 24;
            this.txtdrate.TextChanged += new System.EventHandler(this.txtdrate_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Daily rate:";
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(499, 98);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(229, 26);
            this.txtposition.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(429, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "Position:";
            // 
            // txtTypeRate
            // 
            this.txtTypeRate.FormattingEnabled = true;
            this.txtTypeRate.Items.AddRange(new object[] {
            "DAILY",
            "MONTHLY"});
            this.txtTypeRate.Location = new System.Drawing.Point(898, 96);
            this.txtTypeRate.Name = "txtTypeRate";
            this.txtTypeRate.Size = new System.Drawing.Size(226, 28);
            this.txtTypeRate.TabIndex = 19;
            this.txtTypeRate.SelectedIndexChanged += new System.EventHandler(this.txtTypeRate_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(782, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Type Of Rate:";
            // 
            // txtMonthlyRate
            // 
            this.txtMonthlyRate.Location = new System.Drawing.Point(142, 149);
            this.txtMonthlyRate.Name = "txtMonthlyRate";
            this.txtMonthlyRate.Size = new System.Drawing.Size(229, 26);
            this.txtMonthlyRate.TabIndex = 10;
            this.txtMonthlyRate.TextChanged += new System.EventHandler(this.txtMonthlyRate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Monthly Rate:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(898, 47);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(229, 26);
            this.txtEmpID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(782, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Employee ID:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(499, 47);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(229, 26);
            this.txtemail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            // 
            // txtDailyRateAmtFrmMonthlyRate
            // 
            this.txtDailyRateAmtFrmMonthlyRate.Location = new System.Drawing.Point(706, 196);
            this.txtDailyRateAmtFrmMonthlyRate.Name = "txtDailyRateAmtFrmMonthlyRate";
            this.txtDailyRateAmtFrmMonthlyRate.Size = new System.Drawing.Size(247, 26);
            this.txtDailyRateAmtFrmMonthlyRate.TabIndex = 5;
            this.txtDailyRateAmtFrmMonthlyRate.TextChanged += new System.EventHandler(this.txtDailyRateAmtFrmMonthlyRate_TextChanged);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(170, 50);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(229, 26);
            this.txtfname.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Daily Rate Amount from Monthly Rate:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name of Employee:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(40, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(86, 34);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(211, 26);
            this.txtcode.TabIndex = 1;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = " ID No.";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1328, 758);
            this.tabControl1.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 759);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDailyRateAmtFrmMonthlyRate;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonthlyRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSSSCustomBased;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtTypeRate;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtdrate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSSSnumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtdpt;
        private System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnLoad;
        internal System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonthlyRateBasisDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTinNo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtHdmfNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPhicNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPhicCustom;
    }
}