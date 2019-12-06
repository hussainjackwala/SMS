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
    public partial class EmailContent : Form
    {
        public EmailContent()
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
                   
                    con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=rdshmhadminff1c28c;Data Source=" + Application.StartupPath + "\\DB\\SMSALERT.accdb";
                    con.Open();
                    objTrans = con.BeginTransaction();
                    cmd.Connection = con;
                    cmd.Transaction = objTrans;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from EmailContent";
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = "insert into EmailContent  (EmailSubject,EmailHeader,EmailBody,EmailFooter) values(?,?,?,?)";
                    cmd.Parameters.AddWithValue("v_EmailSubject", txtEmailSubject.Text.Trim());
                    cmd.Parameters.AddWithValue("v_EmailHeader", txtEmailHeader.Text.Trim());
                    cmd.Parameters.AddWithValue("v_EmailBody", txtEmailBody.Text.Trim());

                    cmd.Parameters.AddWithValue("v_EmailFooter", txtEmailFooter.Text.Trim());
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    objTrans.Commit();
                    MessageBox.Show("Email Content configuration has been done successfully");




                }






            }

            catch (Exception ex)
            {
                if (objTrans != null)
                {
                    objTrans.Rollback();
                }


                MessageBox.Show(ex.Message.ToString(), "EmailConetentConfiguration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                cmd.Dispose();



            }

        }


        private bool Validation()
        {
            bool IsOk = true;
            if (string.IsNullOrEmpty(txtEmailSubject.Text.Trim()))
            {

                IsOk = false;
                MessageBox.Show("Please enter Email Subject");

            }

            else if (string.IsNullOrEmpty(txtEmailHeader.Text.Trim()))
            {
                IsOk = false;
                MessageBox.Show("Please enter Email Header");

            }

            else if (string.IsNullOrEmpty(txtEmailBody.Text.Trim()))
            {
                IsOk = false;
                MessageBox.Show("Please enter Email Body");

            }
            else if (string.IsNullOrEmpty(txtEmailFooter.Text.Trim()))
            {
                IsOk = false;
                MessageBox.Show("Please enter Email Footer");

            }

            return IsOk;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataSet GetEmailContent()
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
                cmd.CommandText = "select *  from  EmailContent";
                adpt.SelectCommand = cmd;
                adpt.Fill(ds_tmp, "EmailContentConfiguration");














            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message.ToString(), "EmailContentConfiguration", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void EmailContent_Load(object sender, EventArgs e)
        {
            try
            {

                DataSet ds_tmp = GetEmailContent();
                bool isexist = Common.CommonFuncVar.IsValidateDS(ds_tmp);
                if (isexist == true)
                {
                    txtEmailSubject.Text = ds_tmp.Tables[0].Rows[0]["EmailSubject"].ToString();
                    txtEmailHeader.Text = ds_tmp.Tables[0].Rows[0]["EmailHeader"].ToString();
                    txtEmailBody.Text = ds_tmp.Tables[0].Rows[0]["EmailBody"].ToString();
                    txtEmailFooter.Text = ds_tmp.Tables[0].Rows[0]["EmailFooter"].ToString();
                  
                }

            }
            catch (Exception ex)
            {



                MessageBox.Show(ex.Message.ToString(), "EmailContentConfiguration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
