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
    public partial class FormGroupDetail : Form
    {
        private int _id;
        public FormGroupDetail(int id)
        {
            this._id = id;
            InitializeComponent();
        }

        private void FormGroupDetail_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var sql = $"select * from ContactGroup where Id={this._id}";
                var cmd = new SqlCommand(sql, connection);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.txtId.Text = reader["Id"].ToString();
                    this.txtGroupName.Text = reader["GroupName"].ToString();
                    this.txtGroupMemo.Text = reader["Memo"].ToString();
                }
                reader.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckGroup()
        {
            if (string.IsNullOrEmpty(this.txtGroupName.Text))
            {
                MessageBox.Show("分组名称不能为空");
                this.txtGroupName.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckGroup())
            {
                return;
            }

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var sql = $"update ContactGroup " +
                    $"set GroupName='{this.txtGroupName.Text}',Memo='{this.txtGroupMemo.Text}'" +
                    $"where Id={this._id}";
                var cmd = new SqlCommand(sql, connection);
                var result = cmd.ExecuteNonQuery();
                if (Convert.ToInt32(result) == 1)
                {
                    MessageBox.Show("更新成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("更新失败");
                }
            }
        }
    }
}
