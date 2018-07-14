namespace QuanLyBenhVien
{
    partial class fKyThuatVien
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
            this.dataGridViewThuocDSBN = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxXetNg = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKTVXacNhan = new System.Windows.Forms.Button();
            this.txbKTVMoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxKTVTenBN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuocDSBN)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 354);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridViewThuocDSBN);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách bệnh nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Xem bệnh nhân";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewThuocDSBN
            // 
            this.dataGridViewThuocDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThuocDSBN.Location = new System.Drawing.Point(3, 88);
            this.dataGridViewThuocDSBN.Name = "dataGridViewThuocDSBN";
            this.dataGridViewThuocDSBN.Size = new System.Drawing.Size(408, 202);
            this.dataGridViewThuocDSBN.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Danh sách bệnh nhân";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.checkBoxXetNg);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chuẩn đoán";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // checkBoxXetNg
            // 
            this.checkBoxXetNg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxXetNg.Location = new System.Drawing.Point(51, 49);
            this.checkBoxXetNg.Name = "checkBoxXetNg";
            this.checkBoxXetNg.Size = new System.Drawing.Size(147, 25);
            this.checkBoxXetNg.TabIndex = 5;
            this.checkBoxXetNg.Text = "Xét nghiệm";
            this.checkBoxXetNg.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKTVXacNhan);
            this.panel2.Controls.Add(this.txbKTVMoTa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(51, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 82);
            this.panel2.TabIndex = 5;
            // 
            // btnKTVXacNhan
            // 
            this.btnKTVXacNhan.Location = new System.Drawing.Point(249, 56);
            this.btnKTVXacNhan.Name = "btnKTVXacNhan";
            this.btnKTVXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnKTVXacNhan.TabIndex = 4;
            this.btnKTVXacNhan.Text = "Xác nhận";
            this.btnKTVXacNhan.UseVisualStyleBackColor = true;
            this.btnKTVXacNhan.Click += new System.EventHandler(this.btnKTVXacNhan_Click);
            // 
            // txbKTVMoTa
            // 
            this.txbKTVMoTa.Location = new System.Drawing.Point(113, 3);
            this.txbKTVMoTa.Multiline = true;
            this.txbKTVMoTa.Name = "txbKTVMoTa";
            this.txbKTVMoTa.Size = new System.Drawing.Size(211, 50);
            this.txbKTVMoTa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxKTVTenBN);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(51, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 37);
            this.panel4.TabIndex = 4;
            // 
            // cbxKTVTenBN
            // 
            this.cbxKTVTenBN.FormattingEnabled = true;
            this.cbxKTVTenBN.Location = new System.Drawing.Point(113, 9);
            this.cbxKTVTenBN.Name = "cbxKTVTenBN";
            this.cbxKTVTenBN.Size = new System.Drawing.Size(208, 21);
            this.cbxKTVTenBN.TabIndex = 1;
            this.cbxKTVTenBN.SelectedIndexChanged += new System.EventHandler(this.cbxKTVTenBN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phiếu khám";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Xem lương";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xem thông báo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fKyThuatVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 367);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "fKyThuatVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kỹ thuật viên";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuocDSBN)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewThuocDSBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxXetNg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxKTVTenBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKTVXacNhan;
        private System.Windows.Forms.TextBox txbKTVMoTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}