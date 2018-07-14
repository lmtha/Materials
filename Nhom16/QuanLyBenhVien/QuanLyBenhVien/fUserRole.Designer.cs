namespace QuanLyBenhVien
{
    partial class fUserRole
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDropRoleOK = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxDropRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddRoleOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbAddRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDropRoleOK);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(22, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 75);
            this.panel5.TabIndex = 12;
            // 
            // btnDropRoleOK
            // 
            this.btnDropRoleOK.Location = new System.Drawing.Point(77, 45);
            this.btnDropRoleOK.Name = "btnDropRoleOK";
            this.btnDropRoleOK.Size = new System.Drawing.Size(113, 23);
            this.btnDropRoleOK.TabIndex = 4;
            this.btnDropRoleOK.Text = "Chấp nhận";
            this.btnDropRoleOK.UseVisualStyleBackColor = true;
            this.btnDropRoleOK.Click += new System.EventHandler(this.btnDropRoleOK_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbxDropRole);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(7, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(193, 36);
            this.panel6.TabIndex = 6;
            // 
            // cbxDropRole
            // 
            this.cbxDropRole.FormattingEnabled = true;
            this.cbxDropRole.Location = new System.Drawing.Point(70, 8);
            this.cbxDropRole.Name = "cbxDropRole";
            this.cbxDropRole.Size = new System.Drawing.Size(113, 21);
            this.cbxDropRole.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xóa role";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddRoleOK);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 75);
            this.panel1.TabIndex = 13;
            // 
            // btnAddRoleOK
            // 
            this.btnAddRoleOK.Location = new System.Drawing.Point(77, 45);
            this.btnAddRoleOK.Name = "btnAddRoleOK";
            this.btnAddRoleOK.Size = new System.Drawing.Size(113, 23);
            this.btnAddRoleOK.TabIndex = 2;
            this.btnAddRoleOK.Text = "Chấp nhận";
            this.btnAddRoleOK.UseVisualStyleBackColor = true;
            this.btnAddRoleOK.Click += new System.EventHandler(this.btnAddRoleOK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbAddRole);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 36);
            this.panel2.TabIndex = 6;
            // 
            // txbAddRole
            // 
            this.txbAddRole.Location = new System.Drawing.Point(70, 6);
            this.txbAddRole.Name = "txbAddRole";
            this.txbAddRole.Size = new System.Drawing.Size(113, 20);
            this.txbAddRole.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tạo role";
            // 
            // fUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(256, 192);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.MaximizeBox = false;
            this.Name = "fUserRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role";
            this.Load += new System.EventHandler(this.fUserRole_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDropRoleOK;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbxDropRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddRoleOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbAddRole;
        private System.Windows.Forms.Label label1;
    }
}