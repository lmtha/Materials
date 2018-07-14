namespace QuanLyBenhVien
{
    partial class fKeToan
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewKeToanDSNV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewKeToanLuongKq = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnKeToanSua = new System.Windows.Forms.Button();
            this.btnKeToanXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbKeToanPhuCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbKeToanLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxKeToanMaNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeToanDSNV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeToanLuongKq)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 390);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dataGridViewKeToanDSNV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(551, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(356, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tính lương cho Nhân Viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Danh sách nhân viên";
            // 
            // dataGridViewKeToanDSNV
            // 
            this.dataGridViewKeToanDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeToanDSNV.Location = new System.Drawing.Point(6, 91);
            this.dataGridViewKeToanDSNV.Name = "dataGridViewKeToanDSNV";
            this.dataGridViewKeToanDSNV.Size = new System.Drawing.Size(539, 267);
            this.dataGridViewKeToanDSNV.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewKeToanLuongKq);
            this.tabPage2.Controls.Add(this.panel10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(551, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lương nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKeToanLuongKq
            // 
            this.dataGridViewKeToanLuongKq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeToanLuongKq.Location = new System.Drawing.Point(15, 194);
            this.dataGridViewKeToanLuongKq.Name = "dataGridViewKeToanLuongKq";
            this.dataGridViewKeToanLuongKq.Size = new System.Drawing.Size(520, 164);
            this.dataGridViewKeToanLuongKq.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnKeToanSua);
            this.panel10.Controls.Add(this.btnKeToanXoa);
            this.panel10.Location = new System.Drawing.Point(103, 103);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(351, 47);
            this.panel10.TabIndex = 12;
            // 
            // btnKeToanSua
            // 
            this.btnKeToanSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeToanSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeToanSua.Location = new System.Drawing.Point(240, 6);
            this.btnKeToanSua.Name = "btnKeToanSua";
            this.btnKeToanSua.Size = new System.Drawing.Size(102, 33);
            this.btnKeToanSua.TabIndex = 8;
            this.btnKeToanSua.Text = "Sửa";
            this.btnKeToanSua.UseVisualStyleBackColor = true;
            this.btnKeToanSua.Click += new System.EventHandler(this.btnKeToanSua_Click);
            // 
            // btnKeToanXoa
            // 
            this.btnKeToanXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeToanXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeToanXoa.Location = new System.Drawing.Point(132, 6);
            this.btnKeToanXoa.Name = "btnKeToanXoa";
            this.btnKeToanXoa.Size = new System.Drawing.Size(102, 33);
            this.btnKeToanXoa.TabIndex = 7;
            this.btnKeToanXoa.Text = "Xóa";
            this.btnKeToanXoa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lương nhân viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(15, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 89);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(270, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 37);
            this.panel5.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(96, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số ngày công";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbKeToanPhuCap);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(270, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 37);
            this.panel4.TabIndex = 3;
            // 
            // txbKeToanPhuCap
            // 
            this.txbKeToanPhuCap.Location = new System.Drawing.Point(96, 8);
            this.txbKeToanPhuCap.Name = "txbKeToanPhuCap";
            this.txbKeToanPhuCap.Size = new System.Drawing.Size(141, 20);
            this.txbKeToanPhuCap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phụ cấp";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbKeToanLuong);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 37);
            this.panel3.TabIndex = 2;
            // 
            // txbKeToanLuong
            // 
            this.txbKeToanLuong.Location = new System.Drawing.Point(108, 7);
            this.txbKeToanLuong.Name = "txbKeToanLuong";
            this.txbKeToanLuong.Size = new System.Drawing.Size(140, 20);
            this.txbKeToanLuong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lương cơ bản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxKeToanMaNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 37);
            this.panel1.TabIndex = 1;
            // 
            // cbxKeToanMaNV
            // 
            this.cbxKeToanMaNV.FormattingEnabled = true;
            this.cbxKeToanMaNV.Location = new System.Drawing.Point(108, 7);
            this.cbxKeToanMaNV.Name = "cbxKeToanMaNV";
            this.cbxKeToanMaNV.Size = new System.Drawing.Size(140, 21);
            this.cbxKeToanMaNV.TabIndex = 4;
            this.cbxKeToanMaNV.SelectedIndexChanged += new System.EventHandler(this.cbxKeToanMaNV_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(219, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Xem thông báo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fKeToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 414);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "fKeToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kế toán";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeToanDSNV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeToanLuongKq)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewKeToanDSNV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbKeToanPhuCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbKeToanLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxKeToanMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewKeToanLuongKq;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnKeToanSua;
        private System.Windows.Forms.Button btnKeToanXoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}