namespace QuanLyBenhVien
{
    partial class ChinhSuaQuyen
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
            this.comboOldPriv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboNewPrivs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboOldObj = new System.Windows.Forms.ComboBox();
            this.comboNewObj = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkQuyen = new System.Windows.Forms.CheckBox();
            this.checkDoiTuong = new System.Windows.Forms.CheckBox();
            this.checkGrant = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.CbxTrenCot = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxTrenCotQuyen = new System.Windows.Forms.ComboBox();
            this.btnTrenCot = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxTrenCotLoadColumn = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxTrenCotLoadTable = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTrenCotLoadUser = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quyền cũ";
            // 
            // comboOldPriv
            // 
            this.comboOldPriv.FormattingEnabled = true;
            this.comboOldPriv.Location = new System.Drawing.Point(105, 99);
            this.comboOldPriv.Name = "comboOldPriv";
            this.comboOldPriv.Size = new System.Drawing.Size(121, 21);
            this.comboOldPriv.TabIndex = 1;
            this.comboOldPriv.SelectedIndexChanged += new System.EventHandler(this.comboOldPriv_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quyền mới";
            // 
            // comboNewPrivs
            // 
            this.comboNewPrivs.Enabled = false;
            this.comboNewPrivs.FormattingEnabled = true;
            this.comboNewPrivs.Location = new System.Drawing.Point(327, 96);
            this.comboNewPrivs.Name = "comboNewPrivs";
            this.comboNewPrivs.Size = new System.Drawing.Size(121, 21);
            this.comboNewPrivs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đối tượng cũ";
            // 
            // comboOldObj
            // 
            this.comboOldObj.FormattingEnabled = true;
            this.comboOldObj.Location = new System.Drawing.Point(105, 140);
            this.comboOldObj.Name = "comboOldObj";
            this.comboOldObj.Size = new System.Drawing.Size(121, 21);
            this.comboOldObj.TabIndex = 5;
            this.comboOldObj.SelectedIndexChanged += new System.EventHandler(this.comboOldObj_SelectedIndexChanged);
            // 
            // comboNewObj
            // 
            this.comboNewObj.Enabled = false;
            this.comboNewObj.FormattingEnabled = true;
            this.comboNewObj.Location = new System.Drawing.Point(327, 137);
            this.comboNewObj.Name = "comboNewObj";
            this.comboNewObj.Size = new System.Drawing.Size(121, 21);
            this.comboNewObj.TabIndex = 6;
            this.comboNewObj.SelectedIndexChanged += new System.EventHandler(this.comboNewObj_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đối tượng mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grant Option";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "User/role:";
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(186, 14);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(121, 21);
            this.comboUser.TabIndex = 10;
            this.comboUser.SelectedIndexChanged += new System.EventHandler(this.comboUser_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 180);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "with Grant Option";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(327, 180);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // checkQuyen
            // 
            this.checkQuyen.AutoSize = true;
            this.checkQuyen.Location = new System.Drawing.Point(135, 58);
            this.checkQuyen.Name = "checkQuyen";
            this.checkQuyen.Size = new System.Drawing.Size(57, 17);
            this.checkQuyen.TabIndex = 17;
            this.checkQuyen.Text = "Quyền";
            this.checkQuyen.UseVisualStyleBackColor = true;
            this.checkQuyen.CheckedChanged += new System.EventHandler(this.checkQuyen_CheckedChanged);
            // 
            // checkDoiTuong
            // 
            this.checkDoiTuong.AutoSize = true;
            this.checkDoiTuong.Location = new System.Drawing.Point(216, 58);
            this.checkDoiTuong.Name = "checkDoiTuong";
            this.checkDoiTuong.Size = new System.Drawing.Size(72, 17);
            this.checkDoiTuong.TabIndex = 18;
            this.checkDoiTuong.Text = "Đối tượng";
            this.checkDoiTuong.UseVisualStyleBackColor = true;
            this.checkDoiTuong.CheckedChanged += new System.EventHandler(this.checkDoiTuong_CheckedChanged);
            // 
            // checkGrant
            // 
            this.checkGrant.AutoSize = true;
            this.checkGrant.Location = new System.Drawing.Point(310, 58);
            this.checkGrant.Name = "checkGrant";
            this.checkGrant.Size = new System.Drawing.Size(84, 17);
            this.checkGrant.TabIndex = 19;
            this.checkGrant.Text = "Grant option";
            this.checkGrant.UseVisualStyleBackColor = true;
            this.checkGrant.CheckedChanged += new System.EventHandler(this.checkGrant_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 315);
            this.tabControl1.TabIndex = 23;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboUser);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.checkGrant);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.checkQuyen);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.checkDoiTuong);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboOldPriv);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboNewObj);
            this.tabPage1.Controls.Add(this.comboNewPrivs);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboOldObj);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trên bảng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.CbxTrenCot);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa role cho user";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CbxTrenCot
            // 
            this.CbxTrenCot.FormattingEnabled = true;
            this.CbxTrenCot.Location = new System.Drawing.Point(162, 114);
            this.CbxTrenCot.Name = "CbxTrenCot";
            this.CbxTrenCot.Size = new System.Drawing.Size(121, 21);
            this.CbxTrenCot.TabIndex = 15;
            this.CbxTrenCot.SelectedIndexChanged += new System.EventHandler(this.CbxTrenCot_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "role mới:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(162, 68);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "role cũ:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(163, 26);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "User/role:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.cbxTrenCotQuyen);
            this.tabPage3.Controls.Add(this.btnTrenCot);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.cbxTrenCotLoadColumn);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.cbxTrenCotLoadTable);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cbxTrenCotLoadUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(454, 289);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sửa trên cột";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Quyền";
            // 
            // cbxTrenCotQuyen
            // 
            this.cbxTrenCotQuyen.FormattingEnabled = true;
            this.cbxTrenCotQuyen.Items.AddRange(new object[] {
            "INSERT",
            "UPDATE"});
            this.cbxTrenCotQuyen.Location = new System.Drawing.Point(163, 62);
            this.cbxTrenCotQuyen.Name = "cbxTrenCotQuyen";
            this.cbxTrenCotQuyen.Size = new System.Drawing.Size(121, 21);
            this.cbxTrenCotQuyen.TabIndex = 7;
            this.cbxTrenCotQuyen.SelectedIndexChanged += new System.EventHandler(this.cbxTrenCotQuyen_SelectedIndexChanged);
            // 
            // btnTrenCot
            // 
            this.btnTrenCot.Location = new System.Drawing.Point(163, 201);
            this.btnTrenCot.Name = "btnTrenCot";
            this.btnTrenCot.Size = new System.Drawing.Size(89, 30);
            this.btnTrenCot.TabIndex = 6;
            this.btnTrenCot.Text = "OK";
            this.btnTrenCot.UseVisualStyleBackColor = true;
            this.btnTrenCot.Click += new System.EventHandler(this.btnTrenCot_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(111, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Column";
            // 
            // cbxTrenCotLoadColumn
            // 
            this.cbxTrenCotLoadColumn.FormattingEnabled = true;
            this.cbxTrenCotLoadColumn.Location = new System.Drawing.Point(163, 147);
            this.cbxTrenCotLoadColumn.Name = "cbxTrenCotLoadColumn";
            this.cbxTrenCotLoadColumn.Size = new System.Drawing.Size(121, 21);
            this.cbxTrenCotLoadColumn.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(119, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Table";
            // 
            // cbxTrenCotLoadTable
            // 
            this.cbxTrenCotLoadTable.FormattingEnabled = true;
            this.cbxTrenCotLoadTable.Location = new System.Drawing.Point(163, 106);
            this.cbxTrenCotLoadTable.Name = "cbxTrenCotLoadTable";
            this.cbxTrenCotLoadTable.Size = new System.Drawing.Size(121, 21);
            this.cbxTrenCotLoadTable.TabIndex = 2;
            this.cbxTrenCotLoadTable.SelectedIndexChanged += new System.EventHandler(this.cbxTrenCotLoadTable_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "User/Role";
            // 
            // cbxTrenCotLoadUser
            // 
            this.cbxTrenCotLoadUser.FormattingEnabled = true;
            this.cbxTrenCotLoadUser.Location = new System.Drawing.Point(163, 22);
            this.cbxTrenCotLoadUser.Name = "cbxTrenCotLoadUser";
            this.cbxTrenCotLoadUser.Size = new System.Drawing.Size(121, 21);
            this.cbxTrenCotLoadUser.TabIndex = 0;
            // 
            // ChinhSuaQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 315);
            this.Controls.Add(this.tabControl1);
            this.Name = "ChinhSuaQuyen";
            this.Text = "fUserAlter";
            this.Load += new System.EventHandler(this.ChinhSuaQuyen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboOldPriv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboNewPrivs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboOldObj;
        private System.Windows.Forms.ComboBox comboNewObj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkQuyen;
        private System.Windows.Forms.CheckBox checkDoiTuong;
        private System.Windows.Forms.CheckBox checkGrant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CbxTrenCot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbxTrenCotLoadUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxTrenCotLoadTable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxTrenCotLoadColumn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxTrenCotQuyen;
        private System.Windows.Forms.Button btnTrenCot;
    }
}