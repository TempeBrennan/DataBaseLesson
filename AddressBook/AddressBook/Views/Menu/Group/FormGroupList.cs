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
    public partial class FormGroupList : Form
    {
        private SqlDataAdapter _adapter;
        private DataSet _dataSet;

        public FormGroupList()
        {
            InitializeComponent();
        }

        private void Fill()
        {
            var sql = $"select Id,GroupName,Memo from ContactGroup order by Id desc";
            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                this._adapter = new SqlDataAdapter(sql, connection);
                this._dataSet = new DataSet();
                this._adapter.Fill(this._dataSet);
                this.dgvGroupList.DataSource = this._dataSet.Tables[0];
            }
        }

        private void FormGroupList_Load(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new FormGroupAdd();
            dialog.ShowDialog();
            this.Fill();
        }

        private bool CheckCanDeleteGroup(int id)
        {
            if (MessageBox.Show("确认删除吗？", "询问", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return false;
            }

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var sql = $"select count(*) from Contact where GroupId={id}";
                var cmd = new SqlCommand(sql, connection);
                var result = cmd.ExecuteScalar();
                if (Convert.ToInt32(result) > 0)
                {
                    MessageBox.Show("分组存在联系人，暂不允许被删除");
                    return false;
                }
            }
            return true;
        }

        private void DeleteGroup()
        {
            var id = (int)this.dgvGroupList.CurrentRow.Cells[0].Value;
            if (!CheckCanDeleteGroup(id))
            {
                return;
            }

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var sql = $"delete from ContactGroup where Id={id}";
                var cmd = new SqlCommand(sql, connection);
                var result = cmd.ExecuteNonQuery();
                if (Convert.ToInt32(result) == 1)
                {
                    MessageBox.Show("删除分组成功");
                    this.Fill();
                }
                else
                {
                    MessageBox.Show("删除分组失败");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteGroup();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void Modify()
        {
            var dialog = new FormGroupDetail((int)this.dgvGroupList.CurrentRow.Cells[0].Value);
            dialog.ShowDialog();
            this.Fill();
        }

        private void dgvGroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Modify();
        }
    }
}
