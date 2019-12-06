using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SMS
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter adpt = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        DataSet ds = new DataSet();

        private void btnChangePass_Click(object sender, EventArgs e)
        {
          
            try
            {
               
                if (ds.Tables[0].Rows.Count == 0)
                {
                 


                }

                else
                {

                    if (txtOldPass.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Enter Old password", "ChangePassword", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (txtNewPass.Text.Trim()==string.Empty)
                    {
                        MessageBox.Show("Enter New Password", "ChangePassword", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else if (txtConfirmPass.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Enter Confirm Password", "ChangePassword", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        if (txtOldPass.Text.Trim().ToString().Equals(EncrDecAlgo.CryptorEngine.Decrypt(ds.Tables[0].Rows[0]["LoginPassword"].ToString(), true)))
                        {
                            if (txtNewPass.Text.Trim() == txtConfirmPass.Text.Trim())
                            {
                                cmd.CommandText = "Update users set LoginPassword=?";
                                cmd.Parameters.AddWithValue("v_Password", EncrDecAlgo.CryptorEngine.Encrypt(txtNewPass.Text.Trim(), true));
                                con.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Password has been Changed Successfully", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                cmd.Parameters.Clear();
                                con.Close();
                                txtOldPass.Text = "";
                                txtNewPass.Text = "";
                                txtConfirmPass.Text = "";
                               
                            }
                            else
                            {
                                MessageBox.Show("New Password and Confirm password is not matched", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Old Password is incorrect", "change password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                }







            }
            catch (Exception ex)
            {
                //new ApplicationException(ex.Message, ex.InnerException);

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
              
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=rdshmhadminff1c28c;Data Source=" + Application.StartupPath + "\\DB\\SMSALERT.accdb";

                cmd.CommandText = "select * from users ";

                adpt.SelectCommand = cmd;
                cmd.Connection = con;
                adpt.Fill(ds, "SMS");
                if (ds.Tables[0].Rows.Count == 0)
                {



                }
                if (Common.CommonFuncVar.IsValidateDS(ds) == true)
                {
                    txtLoginName.Text = ds.Tables[0].Rows[0]["LoginName"].ToString();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            con.Dispose();
            adpt.Dispose();
             cmd.Dispose();
             ds.Dispose();

        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            con.Dispose();
            adpt.Dispose();
            cmd.Dispose();
            ds.Dispose();
        }
    }
}
