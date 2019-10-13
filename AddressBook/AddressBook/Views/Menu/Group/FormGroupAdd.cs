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
    public partial class FormGroupAdd : Form
    {
        public FormGroupAdd()
        {
            InitializeComponent();
        }

        private bool CheckGroupName(string groupName)
        {
            if (string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("分组名称不能为空");
                this.txtGroupName.Focus();
                return false;
            }

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var sql = $"select count(*) from ContactGroup where GroupName='{groupName}'";
                var cmd = new SqlCommand(sql, connection);
                var result = cmd.ExecuteScalar();
                if (Convert.ToInt32(result) > 0)
                {
                    MessageBox.Show("分组名称重复");
                    return false;
                }
            }
            return true;
        }

        private void InsertGroup()
        {
            var groupName = this.txtGroupName.Text;
            var memo = this.txtGroupMemo.Text;
            if (!this.CheckGroupName(groupName))
            {
                return;
            }

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var sql = $"insert into ContactGroup values('{groupName}','{memo}')";
                var cmd = new SqlCommand(sql, connection);
                var result = cmd.ExecuteNonQuery();
                if (Convert.ToInt32(result) == 1)
                {
                    MessageBox.Show("添加分组成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加分组失败");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.InsertGroup();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
