namespace WindowsFormsApplication6
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.AdminLabel2 = new System.Windows.Forms.Label();
            this.AdminLabel1 = new System.Windows.Forms.Label();
            this.TxtAdminPassword = new System.Windows.Forms.TextBox();
            this.TxtAdminUserName = new System.Windows.Forms.TextBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.AdminPictureBox2 = new System.Windows.Forms.PictureBox();
            this.CmdAdmincancel = new System.Windows.Forms.Button();
            this.CmdAdminLogin = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdLogin = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(563, 359);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(555, 333);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Admin";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.GroupBox2.Controls.Add(this.AdminPictureBox2);
            this.GroupBox2.Controls.Add(this.LinkLabel2);
            this.GroupBox2.Controls.Add(this.CmdAdmincancel);
            this.GroupBox2.Controls.Add(this.AdminLabel2);
            this.GroupBox2.Controls.Add(this.AdminLabel1);
            this.GroupBox2.Controls.Add(this.CmdAdminLogin);
            this.GroupBox2.Controls.Add(this.TxtAdminPassword);
            this.GroupBox2.Controls.Add(this.TxtAdminUserName);
            this.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.White;
            this.GroupBox2.Location = new System.Drawing.Point(7, -1);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(398, 214);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkLabel2.LinkColor = System.Drawing.Color.RoyalBlue;
            this.LinkLabel2.Location = new System.Drawing.Point(20, 178);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new System.Drawing.Size(96, 14);
            this.LinkLabel2.TabIndex = 19;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "Forget Password";
            this.LinkLabel2.Visible = false;
            this.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Navy;
            // 
            // AdminLabel2
            // 
            this.AdminLabel2.AutoSize = true;
            this.AdminLabel2.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel2.ForeColor = System.Drawing.Color.White;
            this.AdminLabel2.Location = new System.Drawing.Point(175, 86);
            this.AdminLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminLabel2.Name = "AdminLabel2";
            this.AdminLabel2.Size = new System.Drawing.Size(79, 19);
            this.AdminLabel2.TabIndex = 16;
            this.AdminLabel2.Text = "Password :";
            // 
            // AdminLabel1
            // 
            this.AdminLabel1.AutoSize = true;
            this.AdminLabel1.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel1.ForeColor = System.Drawing.Color.White;
            this.AdminLabel1.Location = new System.Drawing.Point(175, 34);
            this.AdminLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminLabel1.Name = "AdminLabel1";
            this.AdminLabel1.Size = new System.Drawing.Size(89, 19);
            this.AdminLabel1.TabIndex = 15;
            this.AdminLabel1.Text = "User Name :";
            // 
            // TxtAdminPassword
            // 
            this.TxtAdminPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdminPassword.Location = new System.Drawing.Point(176, 108);
            this.TxtAdminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdminPassword.Name = "TxtAdminPassword";
            this.TxtAdminPassword.PasswordChar = '*';
            this.TxtAdminPassword.Size = new System.Drawing.Size(200, 23);
            this.TxtAdminPassword.TabIndex = 1;
            // 
            // TxtAdminUserName
            // 
            this.TxtAdminUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAdminUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdminUserName.Location = new System.Drawing.Point(176, 55);
            this.TxtAdminUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdminUserName.Name = "TxtAdminUserName";
            this.TxtAdminUserName.Size = new System.Drawing.Size(200, 23);
            this.TxtAdminUserName.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(555, 333);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = " User";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.GroupBox1.Controls.Add(this.PictureBox2);
            this.GroupBox1.Controls.Add(this.LinkLabel1);
            this.GroupBox1.Controls.Add(this.CmdCancel);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.CmdLogin);
            this.GroupBox1.Controls.Add(this.txtPassword);
            this.GroupBox1.Controls.Add(this.txtUserName);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(7, -1);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(398, 214);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LinkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.LinkLabel1.Location = new System.Drawing.Point(20, 177);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(96, 14);
            this.LinkLabel1.TabIndex = 91;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Forget Password";
            this.LinkLabel1.Visible = false;
            this.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Navy;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(174, 85);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 19);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Password :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(174, 33);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 19);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "User Name :";
            // 
            // txtPassword
            // 
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(175, 107);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(175, 54);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 23);
            this.txtUserName.TabIndex = 0;
            // 
            // AdminPictureBox2
            // 
            this.AdminPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("AdminPictureBox2.Image")));
            this.AdminPictureBox2.Location = new System.Drawing.Point(16, 26);
            this.AdminPictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.AdminPictureBox2.Name = "AdminPictureBox2";
            this.AdminPictureBox2.Size = new System.Drawing.Size(132, 139);
            this.AdminPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminPictureBox2.TabIndex = 20;
            this.AdminPictureBox2.TabStop = false;
            // 
            // CmdAdmincancel
            // 
            this.CmdAdmincancel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdmincancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmdAdmincancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdAdmincancel.Image")));
            this.CmdAdmincancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAdmincancel.Location = new System.Drawing.Point(277, 152);
            this.CmdAdmincancel.Margin = new System.Windows.Forms.Padding(4);
            this.CmdAdmincancel.Name = "CmdAdmincancel";
            this.CmdAdmincancel.Size = new System.Drawing.Size(97, 40);
            this.CmdAdmincancel.TabIndex = 3;
            this.CmdAdmincancel.Text = "   &Cancel";
            this.CmdAdmincancel.UseVisualStyleBackColor = true;
            // 
            // CmdAdminLogin
            // 
            this.CmdAdminLogin.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdminLogin.ForeColor = System.Drawing.Color.Black;
            this.CmdAdminLogin.Image = ((System.Drawing.Image)(resources.GetObject("CmdAdminLogin.Image")));
            this.CmdAdminLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdAdminLogin.Location = new System.Drawing.Point(176, 152);
            this.CmdAdminLogin.Margin = new System.Windows.Forms.Padding(4);
            this.CmdAdminLogin.Name = "CmdAdminLogin";
            this.CmdAdminLogin.Size = new System.Drawing.Size(97, 40);
            this.CmdAdminLogin.TabIndex = 2;
            this.CmdAdminLogin.Text = "    &Login";
            this.CmdAdminLogin.UseVisualStyleBackColor = true;
            this.CmdAdminLogin.Click += new System.EventHandler(this.CmdAdminLogin_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(16, 26);
            this.PictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(132, 139);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 92;
            this.PictureBox2.TabStop = false;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCancel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CmdCancel.Image = ((System.Drawing.Image)(resources.GetObject("CmdCancel.Image")));
            this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdCancel.Location = new System.Drawing.Point(276, 151);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(97, 40);
            this.CmdCancel.TabIndex = 3;
            this.CmdCancel.Text = "   &Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            // 
            // CmdLogin
            // 
            this.CmdLogin.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdLogin.ForeColor = System.Drawing.Color.Black;
            this.CmdLogin.Image = ((System.Drawing.Image)(resources.GetObject("CmdLogin.Image")));
            this.CmdLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdLogin.Location = new System.Drawing.Point(175, 151);
            this.CmdLogin.Margin = new System.Windows.Forms.Padding(4);
            this.CmdLogin.Name = "CmdLogin";
            this.CmdLogin.Size = new System.Drawing.Size(97, 40);
            this.CmdLogin.TabIndex = 2;
            this.CmdLogin.Text = "   &Login";
            this.CmdLogin.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 359);
            this.Controls.Add(this.TabControl1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.PictureBox AdminPictureBox2;
        private System.Windows.Forms.LinkLabel LinkLabel2;
        internal System.Windows.Forms.Button CmdAdmincancel;
        internal System.Windows.Forms.Label AdminLabel2;
        internal System.Windows.Forms.Label AdminLabel1;
        internal System.Windows.Forms.Button CmdAdminLogin;
        internal System.Windows.Forms.TextBox TxtAdminPassword;
        internal System.Windows.Forms.TextBox TxtAdminUserName;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button CmdLogin;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUserName;

    }
}