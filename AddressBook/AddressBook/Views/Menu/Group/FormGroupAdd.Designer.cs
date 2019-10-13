namespace AddressBook
{
    partial class FormGroupAdd
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtGroupMemo = new System.Windows.Forms.TextBox();
            this.lblGroupMemo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGroupName
            // 
            this.lblGroupName.Location = new System.Drawing.Point(44, 50);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(66, 21);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "分组名称";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(127, 50);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(189, 21);
            this.txtGroupName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(241, 240);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtGroupMemo
            // 
            this.txtGroupMemo.Location = new System.Drawing.Point(127, 108);
            this.txtGroupMemo.Multiline = true;
            this.txtGroupMemo.Name = "txtGroupMemo";
            this.txtGroupMemo.Size = new System.Drawing.Size(189, 100);
            this.txtGroupMemo.TabIndex = 4;
            // 
            // lblGroupMemo
            // 
            this.lblGroupMemo.Location = new System.Drawing.Point(44, 111);
            this.lblGroupMemo.Name = "lblGroupMemo";
            this.lblGroupMemo.Size = new System.Drawing.Size(53, 19);
            this.lblGroupMemo.TabIndex = 5;
            this.lblGroupMemo.Text = "备注";
            // 
            // FormGroupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 310);
            this.Controls.Add(this.lblGroupMemo);
            this.Controls.Add(this.txtGroupMemo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblGroupName);
            this.Name = "FormGroupAdd";
            this.Text = "增加分组";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtGroupMemo;
        private System.Windows.Forms.Label lblGroupMemo;
    }
}