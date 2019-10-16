using AddressBook.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class MainForm : Form
    {
        private UserInfo _userInfo;
        public MainForm(UserInfo userInfo)
        {
            this._userInfo = userInfo;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tsslblUserName.Text = "欢迎" + this._userInfo.UserName + "使用通讯录";
            this.tsslblDate.Text = "当前日期：" + DateTime.Now.ToLongDateString();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsbtnContactList_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbtnGroupList_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbtnPwd_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiGroupList_Click(object sender, EventArgs e)
        {
            var form = new FormGroupList();
            form.ShowDialog();
        }

        private void tsmiGroupAdd_Click(object sender, EventArgs e)
        {
            var form = new FormGroupAdd();
            form.ShowDialog();
        }

        private void tsmiContactList_Click(object sender, EventArgs e)
        {
            var form = new FormContactList();
            form.ShowDialog();
        }

        private void tsmiContactAdd_Click(object sender, EventArgs e)
        {
            var form = new FormContactAdd();
            form.ShowDialog();
        }

        private void tsmiPwd_Click(object sender, EventArgs e)
        {
            var form = new FormPwdChange(this._userInfo);
            form.ShowDialog();
        }

        private void tsmiDatabase_Click(object sender, EventArgs e)
        {
            var form = new FormDB();
            form.ShowDialog();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            var form = new FormAbout();
            form.ShowDialog();
        }
    }
}
