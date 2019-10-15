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

        private void FormContactList_Load(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Fill();
        }
    }
}
