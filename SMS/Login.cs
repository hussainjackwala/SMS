using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Data.OleDb;
using EncrDecAlgo ;
using System.Configuration;
using System.IO;

namespace SMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbDataAdapter adpt = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            try
            {




                if (txtLoginName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter Login Name", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }
                else if (txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter Login Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    //con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB\\Lectures.accmdb";
                    con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=rdshmhadminff1c28c;Data Source=" + Application.StartupPath + "\\DB\\SMSALERT.accdb";
                    OleDbCommand cmd = new OleDbCommand();

                    cmd.CommandText = "select * from users where LoginName=? and LoginPassword=?";
                    cmd.Parameters.AddWithValue("v_LoginName", txtLoginName.Text.Trim());
                    cmd.Parameters.AddWithValue("v_LoginPassword", CryptorEngine.Encrypt(txtPassword.Text.Trim(), true));
                    adpt.SelectCommand = cmd;
                    cmd.Connection = con;
                    adpt.Fill(ds, "lecture");
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid User/Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLoginName.Text = "";
                        txtPassword.Text = "";

                    }

                    else
                    {
                        Common.CommonFuncVar.LoginName = ds.Tables[0].Rows[0]["LoginName"].ToString();
                        AdminPanel admpnl = new AdminPanel();
                        admpnl.Show();
                        this.Close();

                    }


                }



             
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Dispose();
                con = null;
                ds.Dispose();
                ds = null;
                adpt.Dispose();
                adpt = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

       

        private void txtLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbDataAdapter adpt = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            if (e.KeyChar == (char)Keys.Enter)
            {

                try
                {




                    if (txtLoginName.Text == string.Empty)
                    {
                        MessageBox.Show("Enter Login Name", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    else if (txtPassword.Text == string.Empty)
                    {
                        MessageBox.Show("Enter Login Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        //con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB\\Lectures.accmdb";
                        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=rdshmhadminff1c28c;Data Source=" + Application.StartupPath + "\\DB\\SMSALERT.accdb";
                        OleDbCommand cmd = new OleDbCommand();

                        cmd.CommandText = "select * from users where LoginName=? and LoginPassword=?";
                        cmd.Parameters.AddWithValue("v_LoginName", txtLoginName.Text);
                        cmd.Parameters.AddWithValue("v_LoginPassword", CryptorEngine.Encrypt(txtPassword.Text, true));
                        adpt.SelectCommand = cmd;
                        cmd.Connection = con;
                        adpt.Fill(ds, "SMS");
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Invalid User/Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            txtLoginName.Text = "";
                            txtPassword.Text = "";
                        }

                        else
                        {
                            Common.CommonFuncVar.LoginName = ds.Tables[0].Rows[0]["LoginName"].ToString();
                            AdminPanel admpnl = new AdminPanel();
                            admpnl.Show();
                            this.Close();

                        }


                    }


                }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Dispose();
                    con = null;
                    ds.Dispose();
                    ds = null;
                    adpt.Dispose();
                    adpt = null;
                }

            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
       
       
        {
            OleDbConnection con = new OleDbConnection();
            OleDbDataAdapter adpt = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            if (e.KeyChar == (char)Keys.Enter)
            {

                try
                {




                    if (txtLoginName.Text == string.Empty)
                    {
                        MessageBox.Show("Enter Login Name", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    }
                    else if (txtPassword.Text == string.Empty)
                    {
                        MessageBox.Show("Enter Login Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        //con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DB\\Lectures.accmdb";
                        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=rdshmhadminff1c28c;Data Source=" + Application.StartupPath + "\\DB\\SMSALERT.accdb";
                        OleDbCommand cmd = new OleDbCommand();

                        cmd.CommandText = "select * from users where LoginName=? and LoginPassword=?";
                        cmd.Parameters.AddWithValue("v_LoginName", txtLoginName.Text);
                        cmd.Parameters.AddWithValue("v_LoginPassword", CryptorEngine.Encrypt(txtPassword.Text, true));
                        adpt.SelectCommand = cmd;
                        cmd.Connection = con;
                        adpt.Fill(ds, "SMS");
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Invalid User/Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            txtLoginName.Text = "";
                            txtPassword.Text = "";
                        }

                        else
                        {
                            Common.CommonFuncVar.LoginName = ds.Tables[0].Rows[0]["LoginName"].ToString();
                            AdminPanel admpnl = new AdminPanel();
                            admpnl.Show();
                            this.Close();

                        }


                    }


                }



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Dispose();
                    con = null;
                    ds.Dispose();
                    ds = null;
                    adpt.Dispose();
                    adpt = null;
                }



                  

    }

}

        private void Login_Load(object sender, EventArgs e)
        {

        }



     



    }
}
