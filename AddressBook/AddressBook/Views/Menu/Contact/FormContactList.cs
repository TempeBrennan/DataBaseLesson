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
    public partial class FormContactList : Form
    {
        private SqlDataAdapter _adapter;
        private DataSet _dataSet;

        public FormContactList()
        {
            InitializeComponent();
        }

        private void Fill()
        {
            var sql = $"select Contact.Id,Name,Phone,Email,QQ,GroupName " +
                $"from Contact,ContactGroup " +
                $"where Contact.GroupId=ContactGroup.Id ";

            if (this.cboCondition.Text == "姓名")
            {
                sql += $"and Name like '%{this.txtSearch.Text}%' ";
            }
            else
            {
                sql += $"and Phone like '%{this.txtSearch.Text}%' ";
            }
            sql += "order by Contact.Id";

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                this._adapter = new SqlDataAdapter(sql, connection);
                this._dataSet = new DataSet();
                this._adapter.Fill(this._dataSet);
                this.dgvContactList.DataSource = this._dataSet.Tables[0];
            }
        }

        private void Delete()
        {
            var id = Convert.ToInt32(this.dgvContactList.CurrentRow.Cells[0].Value.ToString());
            if (id < 0)
            {
                return;
            }
            if (MessageBox.Show("确认删除吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                != DialogResult.Yes)
            {
                return;
            }

            var sql = $"delete from Contact where Id={id}";
            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(sql, connection);
                var result = cmd.ExecuteNonQuery();
                if (Convert.ToInt32(result) == 1)
                {
                    MessageBox.Show("删除成功");
                    this.Fill();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void FormContactList_Load(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new FormContactAdd();
            form.ShowDialog();
            this.Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void Modify()
        {
            var id = (int)this.dgvContactList.CurrentRow.Cells[0].Value;
            if (id < 0)
            {
                return;
            }

            var form = new FormContactDetail(id);
            form.ShowDialog();
            this.Fill();
        }

        private void dgvContactList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Modify();
        }
    }
}
