namespace QuanLyBenhVien
{
    partial class fUserDelete
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
            this.btnUserDeleteOK = new System.Windows.Forms.Button();
            this.checkBoxUserDeleteCascade = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxUserDelete = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnUserDeleteOK);
            this.panel5.Controls.Add(this.checkBoxUserDeleteCascade);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(12, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 91);
            this.panel5.TabIndex = 11;
            // 
            // btnUserDeleteOK
            // 
            this.btnUserDeleteOK.Location = new System.Drawing.Point(77, 61);
            this.btnUserDeleteOK.Name = "btnUserDeleteOK";
            this.btnUserDeleteOK.Size = new System.Drawing.Size(113, 23);
            this.btnUserDeleteOK.TabIndex = 12;
            this.btnUserDeleteOK.Text = "Chấp nhận";
            this.btnUserDeleteOK.UseVisualStyleBackColor = true;
            this.btnUserDeleteOK.Click += new System.EventHandler(this.btnUserDeleteOK_Click);
            // 
            // checkBoxUserDeleteCascade
            // 
            this.checkBoxUserDeleteCascade.AutoSize = true;
            this.checkBoxUserDeleteCascade.Location = new System.Drawing.Point(77, 42);
            this.checkBoxUserDeleteCascade.Name = "checkBoxUserDeleteCascade";
            this.checkBoxUserDeleteCascade.Size = new System.Drawing.Size(68, 17);
            this.checkBoxUserDeleteCascade.TabIndex = 7;
            this.checkBoxUserDeleteCascade.Text = "Cascade";
            this.checkBoxUserDeleteCascade.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbxUserDelete);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(7, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(193, 36);
            this.panel6.TabIndex = 6;
            // 
            // cbxUserDelete
            // 
            this.cbxUserDelete.FormattingEnabled = true;
            this.cbxUserDelete.Location = new System.Drawing.Point(70, 8);
            this.cbxUserDelete.Name = "cbxUserDelete";
            this.cbxUserDelete.Size = new System.Drawing.Size(113, 21);
            this.cbxUserDelete.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên user";
            // 
            // fUserDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(228, 117);
            this.Controls.Add(this.panel5);
            this.MaximizeBox = false;
            this.Name = "fUserDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa user";
            this.Load += new System.EventHandler(this.fUserDelete_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBoxUserDeleteCascade;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbxUserDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUserDeleteOK;
    }
}