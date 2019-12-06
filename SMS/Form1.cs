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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + "\\DB\\SMSALERT.accdb;Jet OLEDB:Database Password='FMHusain@990';";

                con.Open();

                Microsoft.Office.Interop.Access.Dao.DBEngine abc = new Microsoft.Office.Interop.Access.Dao.DBEngine();
               
                abc.CompactDatabase( Application.StartupPath + "\\DB\\SMSALERT.accdb",  Application.StartupPath + "\\DB\\SMSALERT2.accdb");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        
        

        }
    }
}
