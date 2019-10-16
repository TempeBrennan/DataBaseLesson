using AddressBook.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class FormPwdChange : Form
    {
        private UserInfo _userInfo;

        public FormPwdChange(UserInfo userInfo)
        {
            this._userInfo = userInfo;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.UpdatePassword();
        }

        private bool Check()
        {
            if (this.txtOldPwd.Text != this._userInfo.Password)
            {
                MessageBox.Show("原密码错误");
                this.txtOldPwd.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtNewPwd.Text))
            {
                MessageBox.Show("新密码不能为空");
                this.txtNewPwd.Focus();
                return false;
            }
            if (this.txtNewPwd.Text != this.txtNewPwdAgain.Text)
            {
                MessageBox.Show("两次密码不一致");
                this.txtNewPwdAgain.Focus();
                return false;
            }
            return true;
        }

        private void UpdatePassword()
        {
            if (!this.Check())
            {
                return;
            }

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var sql = $"update [User] set Password = '{this.txtNewPwd.Text}' " +
                    $"where UserName='{this._userInfo.UserName}'";
                var cmd = new SqlCommand(sql, connection);
                var result = cmd.ExecuteNonQuery();
                if (Convert.ToInt32(result) == 1)
                {
                    MessageBox.Show("修改密码成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改密码失败");
                }
            }
        }

        private void FormPwdChange_Load(object sender, EventArgs e)
        {
            this.txtOldPwd.Focus();
        }
    }
}
