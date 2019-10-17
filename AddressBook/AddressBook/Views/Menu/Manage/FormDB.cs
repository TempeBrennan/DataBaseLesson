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
    public partial class FormDB : Form
    {
        private string _saveBackupPath;
        private string _restoreBackupPath;

        public FormDB()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this._saveBackupPath))
            {
                MessageBox.Show("请先选择备份路径", "提示");
                return;
            }

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var sql = $"backup database AddressList to disk='{this._saveBackupPath}'";
                    var cmd = new SqlCommand(sql, connection);
                    this.Cursor = Cursors.WaitCursor;
                    var result = cmd.ExecuteNonQuery();
                    MessageBox.Show("备份成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }

        private void btnBackupPath_Click(object sender, EventArgs e)
        {
            this.sfdgBackup.FilterIndex = 1;
            this.sfdgBackup.FileName = "";
            this.sfdgBackup.Filter = "Bak Files (*.bak)|*.bak";
            if (this.sfdgBackup.ShowDialog() == DialogResult.OK)
            {
                this._saveBackupPath = this.sfdgBackup.FileName;
                this.txtBackup.Text = this._saveBackupPath;
                this.txtBackup.ReadOnly = true;
            }
        }

        private void btnRestorePath_Click(object sender, EventArgs e)
        {
            this.ofdlgRestore.FilterIndex = 1;
            this.ofdlgRestore.FileName = "";
            this.ofdlgRestore.Filter = "Bak Files (*.bak)|*.bak";
            if (this.ofdlgRestore.ShowDialog() == DialogResult.OK)
            {
                this._restoreBackupPath = this.ofdlgRestore.FileName;
                this.txtRestore.Text = this._restoreBackupPath;
                this.txtRestore.ReadOnly = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this._restoreBackupPath))
            {
                MessageBox.Show("请先选择恢复路径", "提示");
                return;
            }

            using (var connection = new SqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    var sql =
                        $"alter database AddressList set offline with rollback immediate;" +
                        $"use master;" +
                        $"restore database AddressList from disk='{this._restoreBackupPath}' with replace;" +
                        $"alter database AddressList set online with rollback immediate";

                    var cmd = new SqlCommand(sql, connection);
                    this.Cursor = Cursors.WaitCursor;
                    var result = cmd.ExecuteNonQuery();
                    MessageBox.Show("恢复成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                }
            }
        }
    }
}
