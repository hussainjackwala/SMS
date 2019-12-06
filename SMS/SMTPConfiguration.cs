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
    public partial class SMTPConfiguration : Form
    {
        public SMTPConfiguration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection();

            OleDbTransaction objTrans = null;

            OleDbCommand cmd = new OleDbCommand();
            try

            {
                if (Validation() == true)
                {
                    int SSL = 0;
                    if (ChkSSL.Checked == true)
                    {
                        SSL = 1;
                    }
                    con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=rdshmhadminff1c28c;Data Source=" + Application.StartupPath + "\\DB\\SMSALERT.accdb";
                    con.Open();
                    objTrans = con.BeginTransaction();
                    cmd.Connection = con;
                    cmd.Transaction = objTrans;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from SMTPConfiguration";
                    cmd.ExecuteNonQuery();

                   
                    cmd.CommandText = "insert into SMTPCONFIGURATION  (Server_Name,Port_No,UserName,User_Password,Display_UserName,Display_Email,ISSSL) values(?,?,?,?,?,?,?)";
                    cmd.Parameters.AddWithValue("v_ServerName", txtServerName.Text.Trim());
                    cmd.Parameters.AddWithValue("v_PortNo", txtPortNo.Text.Trim());
                    cmd.Parameters.AddWithValue("v_UserName", txtUserEmail.Text.Trim());
                   
                    cmd.Parameters.AddWithValue("v_Password", EncrDecAlgo.CryptorEngine.Encrypt( txtUserPassword.Text.Trim(),true));
                    cmd.Parameters.AddWithValue("v_DisplayName", txtDispayUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("v_DisplayEmail", txtSenderEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("v_SSL", SSL);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    objTrans.Commit();
                    MessageBox.Show("SMTP configuration has been done successfully");




                }






            }

            catch (Exception ex)
            {
                if (objTrans != null)
                {
                    objTrans.Rollback();
                }

                
                MessageBox.Show(ex.Message.ToString(),"SMTPConfiguration",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {

                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }

                cmd.Dispose();



            }


        }


        private DataSet GetSMTPConfiguration()
        {
            DataSet ds_tmp = new DataSet();

            OleDbConnection con = new OleDbConnection();

         

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter adpt = new OleDbDataAdapter();
            try

            {
               
                    con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=rdshmhadminff1c28c;Data Source=" + Application.StartupPath + "\\DB\\SMSALERT.accdb";
                    con.Open();
                 
                    cmd.Connection = con;
                 
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select *  from SMTPConfiguration";
                adpt.SelectCommand = cmd;
                    adpt.Fill(ds_tmp, "SMTPConfiguration");

                   
                  
                



             






            }

            catch (Exception ex)
            {
                


                MessageBox.Show(ex.Message.ToString(), "SMTPConfiguration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                cmd.Dispose();
                cmd = null;
                adpt.Dispose();
                adpt = null;




            }
            return ds_tmp;


        }
        private bool Validation()
        {
            bool IsOk = true;
            if (string.IsNullOrEmpty(txtServerName.Text.Trim()))
            {

                IsOk = false;
                MessageBox.Show("Please enter server name");
                
            }

            else if (string.IsNullOrEmpty(txtPortNo.Text.Trim()))
            {
                IsOk = false;
                MessageBox.Show("Please enter Port");
                
            }

            else if (string.IsNullOrEmpty(txtUserEmail.Text.Trim()))
            {
                IsOk = false;
                MessageBox.Show("Please enter user email");
                
            }
            else if (string.IsNullOrEmpty(txtUserPassword.Text.Trim()))
            {
                IsOk = false;
                MessageBox.Show("Please enter user password");
                
            }
            else if (string.IsNullOrEmpty(txtDispayUserName.Text.Trim()))
            {
                IsOk = false;
                MessageBox.Show("Please enter From Name");

            }
            else if (string.IsNullOrEmpty(txtSenderEmail.Text.Trim()))
            {
                IsOk = false;
                MessageBox.Show("Please enter Sender Email");

            }

            return IsOk;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SMTPConfiguration_Load(object sender, EventArgs e)
        {
            try
            {

                DataSet ds_tmp = GetSMTPConfiguration();
                bool isexist = Common.CommonFuncVar.IsValidateDS(ds_tmp);
                if (isexist==true)
                {
                    txtServerName.Text = ds_tmp.Tables[0].Rows[0]["Server_Name"].ToString();
                    txtPortNo.Text = ds_tmp.Tables[0].Rows[0]["Port_No"].ToString();
                    txtUserEmail.Text= ds_tmp.Tables[0].Rows[0]["UserName"].ToString();
                    txtUserPassword.Text= EncrDecAlgo.CryptorEngine.Decrypt(ds_tmp.Tables[0].Rows[0]["User_Password"].ToString(), true);
                    txtDispayUserName.Text = ds_tmp.Tables[0].Rows[0]["Display_UserName"].ToString();

                    txtSenderEmail.Text = ds_tmp.Tables[0].Rows[0]["Display_Email"].ToString();

                    ChkSSL.Checked =bool.Parse( ds_tmp.Tables[0].Rows[0]["ISSSL"].ToString());
                }

            }
            catch (Exception ex)
            {



                MessageBox.Show(ex.Message.ToString(), "SMTPConfiguration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
