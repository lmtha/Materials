namespace QuanLyBenhVien
{
    partial class fUserManage
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUserPrivileges = new System.Windows.Forms.Button();
            this.btnUserAlter = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserRole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(28, 40);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(93, 82);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Thêm user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUserPrivileges
            // 
            this.btnUserPrivileges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserPrivileges.Location = new System.Drawing.Point(156, 163);
            this.btnUserPrivileges.Name = "btnUserPrivileges";
            this.btnUserPrivileges.Size = new System.Drawing.Size(93, 83);
            this.btnUserPrivileges.TabIndex = 5;
            this.btnUserPrivileges.Text = "Quyền";
            this.btnUserPrivileges.UseVisualStyleBackColor = true;
            this.btnUserPrivileges.Click += new System.EventHandler(this.btnUserPrivileges_Click);
            // 
            // btnUserAlter
            // 
            this.btnUserAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAlter.Location = new System.Drawing.Point(285, 40);
            this.btnUserAlter.Name = "btnUserAlter";
            this.btnUserAlter.Size = new System.Drawing.Size(105, 82);
            this.btnUserAlter.TabIndex = 3;
            this.btnUserAlter.Text = "Hiệu chỉnh user/role";
            this.btnUserAlter.UseVisualStyleBackColor = true;
            this.btnUserAlter.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDelete.Location = new System.Drawing.Point(156, 40);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(93, 82);
            this.btnUserDelete.TabIndex = 2;
            this.btnUserDelete.Text = "Xóa user";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserRole
            // 
            this.btnUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRole.Location = new System.Drawing.Point(28, 163);
            this.btnUserRole.Name = "btnUserRole";
            this.btnUserRole.Size = new System.Drawing.Size(93, 83);
            this.btnUserRole.TabIndex = 4;
            this.btnUserRole.Text = "Thêm/Xóa role";
            this.btnUserRole.UseVisualStyleBackColor = true;
            this.btnUserRole.Click += new System.EventHandler(this.btnUserRole_Click);
            // 
            // fUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 330);
            this.Controls.Add(this.btnUserRole);
            this.Controls.Add(this.btnUserAlter);
            this.Controls.Add(this.btnUserDelete);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnUserPrivileges);
            this.MaximizeBox = false;
            this.Name = "fUserManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý user";
            this.Load += new System.EventHandler(this.fUserManage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUserPrivileges;
        private System.Windows.Forms.Button btnUserAlter;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserRole;
    }
}