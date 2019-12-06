using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SMS
{
    public partial class DeleteLogs : Form
    {
        public DeleteLogs()
        {
            InitializeComponent();
        }

        private void btn_DelLogs_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
               
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=rdshmhadminff1c28c;Data Source=" + Application.StartupPath + "\\DB\\SMSALERT.accdb";

                cmd.CommandText = "delete from   smsalertlog ";
                con.Open();
                cmd.Connection = con;
                
                cmd.ExecuteNonQuery();

                cmd.CommandText = "delete from   Emaillog ";
               
               

                cmd.ExecuteNonQuery();


                MessageBox.Show("SMS and Email  logs has been deleted successfully");



            }

            catch (Exception ex  )
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd.Dispose();
                    cmd = null;
                con.Dispose();
                con = null;

                }
            }
        
    }
}
