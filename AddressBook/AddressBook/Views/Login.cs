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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text) || string.IsNullOrEmpty(this.txtUserPassword.Text))
            {
                MessageBox.Show("用户名和密码不能为空");
                this.txtUserName.Focus();
                return;
            }

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var sql = $"SELECT count(*) FROM [User] where UserName='{this.txtUserName.Text}' and Password='{this.txtUserPassword.Text}'";
                    var command = new SqlCommand(sql, connection);
                    //1. ExecuteScalar 返回执行结果的第一行第一列
                    //var result = command.ExecuteScalar();
                    //if (Convert.ToUInt32(result) == 1)
                    //{
                    //    MessageBox.Show("登陆成功！");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("登陆失败！");
                    //}

                    //2. 调用一次Read, dr保存当前一行的内容，在调用一次向下移动一行。
                    var dr = command.ExecuteReader();
                    var result = dr.Read();

                    // 这样取得当前行某一列的值
                    //var name = dr["UserName"].ToString();
                    if (result)
                    {
                        //MessageBox.Show("登陆成功！");
                        this.Hide();
                        var mainForm = new MainForm(new ViewModels.UserInfo()
                        {
                            UserName = this.txtUserName.Text.Trim(),
                            Password = this.txtUserPassword.Text.Trim()
                        });
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("登陆失败！");
                        this.txtUserName.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
