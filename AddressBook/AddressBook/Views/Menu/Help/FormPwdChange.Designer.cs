namespace AddressBook
{
    partial class FormPwdChange
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
            this.lblNewPwdAgain = new System.Windows.Forms.Label();
            this.txtNewPwdAgain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNewPwdAgain
            // 
            this.lblNewPwdAgain.AutoSize = true;
            this.lblNewPwdAgain.Location = new System.Drawing.Point(46, 179);
            this.lblNewPwdAgain.Name = "lblNewPwdAgain";
            this.lblNewPwdAgain.Size = new System.Drawing.Size(65, 12);
            this.lblNewPwdAgain.TabIndex = 0;
            this.lblNewPwdAgain.Text = "新密码确认";
            // 
            // txtNewPwdAgain
            // 
            this.txtNewPwdAgain.Location = new System.Drawing.Point(144, 176);
            this.txtNewPwdAgain.Name = "txtNewPwdAgain";
            this.txtNewPwdAgain.PasswordChar = '*';
            this.txtNewPwdAgain.Size = new System.Drawing.Size(152, 21);
            this.txtNewPwdAgain.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(67, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(189, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.Location = new System.Drawing.Point(46, 50);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(53, 12);
            this.lblOldPwd.TabIndex = 4;
            this.lblOldPwd.Text = "原始密码";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(46, 115);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(41, 12);
            this.lblNewPwd.TabIndex = 5;
            this.lblNewPwd.Text = "新密码";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(144, 115);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(152, 21);
            this.txtNewPwd.TabIndex = 6;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(144, 50);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(152, 21);
            this.txtOldPwd.TabIndex = 7;
            // 
            // FormPwdChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 319);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblOldPwd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPwdAgain);
            this.Controls.Add(this.lblNewPwdAgain);
            this.Name = "FormPwdChange";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FormPwdChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewPwdAgain;
        private System.Windows.Forms.TextBox txtNewPwdAgain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOldPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
    }
}