namespace 物品借用程式
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_send_ck = new System.Windows.Forms.Button();
            this.cbox_lend_name = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_num = new System.Windows.Forms.TextBox();
            this.cbox_ltem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_stuid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbox_idcard = new System.Windows.Forms.ComboBox();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbox_company = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_send_ck);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cbox_company);
            this.groupBox1.Controls.Add(this.cbox_idcard);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbox_lend_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTime1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbox_num);
            this.groupBox1.Controls.Add(this.cbox_ltem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbox_mail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbox_phone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbox_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbox_stuid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1849, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "物品借用登記";
            // 
            // button_send_ck
            // 
            this.button_send_ck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_send_ck.Location = new System.Drawing.Point(1731, 27);
            this.button_send_ck.Name = "button_send_ck";
            this.button_send_ck.Size = new System.Drawing.Size(86, 72);
            this.button_send_ck.TabIndex = 19;
            this.button_send_ck.Text = "送出 申請";
            this.button_send_ck.UseVisualStyleBackColor = true;
            this.button_send_ck.Click += new System.EventHandler(this.button_send_ck_Click);
            // 
            // cbox_lend_name
            // 
            this.cbox_lend_name.FormattingEnabled = true;
            this.cbox_lend_name.Items.AddRange(new object[] {
            "亭羽",
            "尚佑",
            "玉閔",
            "品毅",
            "韻雯",
            "正祺",
            "煥培",
            "安妮",
            "浚豪",
            "宥森",
            "益桓",
            "孝汶",
            "碧珊",
            "妤柔",
            "育綺",
            "郁晴",
            "旭淳",
            "芳豪",
            "威均",
            "汶燕",
            "巧梅",
            "志偉"});
            this.cbox_lend_name.Location = new System.Drawing.Point(1431, 68);
            this.cbox_lend_name.Name = "cbox_lend_name";
            this.cbox_lend_name.Size = new System.Drawing.Size(125, 34);
            this.cbox_lend_name.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1453, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "借出人";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1238, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "預計歸還日期";
            // 
            // dateTime1
            // 
            this.dateTime1.Location = new System.Drawing.Point(1216, 68);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(200, 35);
            this.dateTime1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1130, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "個數";
            // 
            // tbox_num
            // 
            this.tbox_num.Location = new System.Drawing.Point(1120, 68);
            this.tbox_num.Name = "tbox_num";
            this.tbox_num.Size = new System.Drawing.Size(80, 35);
            this.tbox_num.TabIndex = 13;
            this.tbox_num.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // cbox_ltem
            // 
            this.cbox_ltem.FormattingEnabled = true;
            this.cbox_ltem.Location = new System.Drawing.Point(938, 69);
            this.cbox_ltem.Name = "cbox_ltem";
            this.cbox_ltem.Size = new System.Drawing.Size(167, 34);
            this.cbox_ltem.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(952, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "借用物品名稱";
            // 
            // tbox_mail
            // 
            this.tbox_mail.Location = new System.Drawing.Point(653, 69);
            this.tbox_mail.Name = "tbox_mail";
            this.tbox_mail.Size = new System.Drawing.Size(267, 35);
            this.tbox_mail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "信箱";
            // 
            // tbox_phone
            // 
            this.tbox_phone.Location = new System.Drawing.Point(463, 70);
            this.tbox_phone.Name = "tbox_phone";
            this.tbox_phone.Size = new System.Drawing.Size(177, 35);
            this.tbox_phone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "電話";
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(323, 70);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(125, 35);
            this.tbox_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名";
            // 
            // tbox_stuid
            // 
            this.tbox_stuid.Location = new System.Drawing.Point(174, 70);
            this.tbox_stuid.Name = "tbox_stuid";
            this.tbox_stuid.Size = new System.Drawing.Size(132, 35);
            this.tbox_stuid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "學號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "單位";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(22, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1852, 763);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "未歸還借用物品名單";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1840, 679);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "單位";
            this.columnHeader0.Width = 140;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "學號";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "電話";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "信箱";
            this.columnHeader4.Width = 270;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "借用物品名稱";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "個數";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "借出時間";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "預計歸還時間";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "借出人";
            this.columnHeader9.Width = 120;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(1721, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 28);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "保留資料";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1600, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 26);
            this.label10.TabIndex = 21;
            this.label10.Text = "證件";
            // 
            // cbox_idcard
            // 
            this.cbox_idcard.FormattingEnabled = true;
            this.cbox_idcard.Items.AddRange(new object[] {
            "學生證",
            "健保卡",
            "身分證",
            "駕照"});
            this.cbox_idcard.Location = new System.Drawing.Point(1565, 68);
            this.cbox_idcard.Name = "cbox_idcard";
            this.cbox_idcard.Size = new System.Drawing.Size(125, 34);
            this.cbox_idcard.TabIndex = 22;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "證件";
            this.columnHeader10.Width = 120;
            // 
            // cbox_company
            // 
            this.cbox_company.FormattingEnabled = true;
            this.cbox_company.Location = new System.Drawing.Point(6, 69);
            this.cbox_company.Name = "cbox_company";
            this.cbox_company.Size = new System.Drawing.Size(152, 34);
            this.cbox_company.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1646, 945);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "刪除資料";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(1715, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 48);
            this.button3.TabIndex = 1;
            this.button3.Text = "搜尋";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1575, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 34);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1317, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 34);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "朝陽學生會 物品借用程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_stuid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_num;
        private System.Windows.Forms.ComboBox cbox_ltem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_send_ck;
        private System.Windows.Forms.ComboBox cbox_lend_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbox_idcard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox cbox_company;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
    }
}

