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
    public partial class FormContactAdd : Form
    {
        public FormContactAdd()
        {
            InitializeComponent();
        }

        private void FillComboDataSource()
        {
            var sql = $"select * from ContactGroup";

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var adapter = new SqlDataAdapter(sql, connection);
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                this.cboGroup.DataSource = dataSet.Tables[0];
            }
        }

        private void FormContactAdd_Load(object sender, EventArgs e)
        {
            this.FillComboDataSource();
        }

        private bool Check(string name, string phone, string email, string qq, string officePhone, string homePhone)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("姓名不能为空");
                this.txtName.Focus();
                return false;
            }

            if (!Utility.CheckMobilePhone(phone))
            {
                MessageBox.Show("手机号码不正确");
                this.txtPhone.Focus();
                return false;
            }

            if (!Utility.CheckEmail(email))
            {
                MessageBox.Show("电子邮箱不正确");
                this.txtEmail.Focus();
                return false;
            }

            if (!Utility.CheckQQ(qq))
            {
                MessageBox.Show("QQ号码不正确");
                this.txtQQ.Focus();
                return false;
            }

            if (!Utility.CheckPhone(officePhone))
            {
                MessageBox.Show("办公号码不正确");
                this.txtOfficePhone.Focus();
                return false;
            }

            if (!Utility.CheckPhone(homePhone))
            {
                MessageBox.Show("家庭电话号码不正确");
                this.txtHomePhone.Focus();
                return false;
            }

            return true;
        }

        private void Insert()
        {
            var name = this.txtName.Text;
            var phone = this.txtPhone.Text;
            var email = this.txtEmail.Text;
            var qq = this.txtQQ.Text;
            var officePhone = this.txtOfficePhone.Text;
            var homePhone = this.txtHomePhone.Text;
            var workUnit = this.txtWorkUnit.Text;
            var homeAddress = this.txtHomeAddress.Text;
            var memo = this.txtMemo.Text;
            var groupId = Convert.ToInt32(this.cboGroup.SelectedValue);

            if (!this.Check(name, phone, email, qq, officePhone, homePhone))
            {
                return;
            }

            var sql = $"insert into Contact " +
                $"values('{name}','{phone}','{email}','{qq}','{workUnit}','{officePhone}'," +
                $"'{homeAddress}','{homePhone}','{memo}',{groupId})";

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                connection.Open();
                var cmd = new SqlCommand(sql, connection);
                var result = cmd.ExecuteNonQuery();
                if (Convert.ToInt32(result) == 1)
                {
                    MessageBox.Show("插入成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("插入失败");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Insert();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
