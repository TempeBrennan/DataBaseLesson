namespace AddressBook
{
    partial class FormDB
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
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.lblBackup = new System.Windows.Forms.Label();
            this.lblRestore = new System.Windows.Forms.Label();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.btnRestorePath = new System.Windows.Forms.Button();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.sfdgBackup = new System.Windows.Forms.SaveFileDialog();
            this.ofdlgRestore = new System.Windows.Forms.OpenFileDialog();
            this.grpBackup.SuspendLayout();
            this.grpRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnBackup);
            this.grpBackup.Controls.Add(this.btnBackupPath);
            this.grpBackup.Controls.Add(this.txtBackup);
            this.grpBackup.Controls.Add(this.lblBackup);
            this.grpBackup.Location = new System.Drawing.Point(28, 30);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(532, 121);
            this.grpBackup.TabIndex = 0;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "备份数据库";
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.btnRestorePath);
            this.grpRestore.Controls.Add(this.txtRestore);
            this.grpRestore.Controls.Add(this.lblRestore);
            this.grpRestore.Location = new System.Drawing.Point(28, 196);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(532, 121);
            this.grpRestore.TabIndex = 1;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "恢复数据库";
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(30, 39);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(53, 12);
            this.lblBackup.TabIndex = 0;
            this.lblBackup.Text = "备份路径";
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Location = new System.Drawing.Point(30, 44);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(53, 12);
            this.lblRestore.TabIndex = 1;
            this.lblRestore.Text = "恢复路径";
            // 
            // txtBackup
            // 
            this.txtBackup.Location = new System.Drawing.Point(89, 39);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.Size = new System.Drawing.Size(328, 21);
            this.txtBackup.TabIndex = 1;
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.Location = new System.Drawing.Point(435, 37);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(75, 23);
            this.btnBackupPath.TabIndex = 2;
            this.btnBackupPath.Text = "选择";
            this.btnBackupPath.UseVisualStyleBackColor = true;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // btnRestorePath
            // 
            this.btnRestorePath.Location = new System.Drawing.Point(435, 42);
            this.btnRestorePath.Name = "btnRestorePath";
            this.btnRestorePath.Size = new System.Drawing.Size(75, 23);
            this.btnRestorePath.TabIndex = 4;
            this.btnRestorePath.Text = "选择";
            this.btnRestorePath.UseVisualStyleBackColor = true;
            this.btnRestorePath.Click += new System.EventHandler(this.btnRestorePath_Click);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(89, 44);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(328, 21);
            this.txtRestore.TabIndex = 3;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(32, 78);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(478, 25);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "备份数据库";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(32, 81);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(478, 25);
            this.btnRestore.TabIndex = 5;
            this.btnRestore.Text = "恢复数据库";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // ofdlgRestore
            // 
            this.ofdlgRestore.FileName = "openFileDialog1";
            // 
            // FormDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 352);
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.grpBackup);
            this.Name = "FormDB";
            this.Text = "数据库备份与恢复";
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBackupPath;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRestorePath;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.SaveFileDialog sfdgBackup;
        private System.Windows.Forms.OpenFileDialog ofdlgRestore;
    }
}