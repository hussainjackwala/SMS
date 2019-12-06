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
using System.Text.RegularExpressions;
namespace SMS
{
    public partial class SMSAlertTimeConfiguration : Form
    {
        public SMSAlertTimeConfiguration()
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
                    cmd.CommandText = "delete from SMSConfiguration";
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = "insert into SMSCONFIGURATION  (SMSMinutes) values(?)";
                    cmd.Parameters.AddWithValue("v_ServerName", txtTime.Text.Trim());

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    objTrans.Commit();
                    MessageBox.Show("SMS configuration has been done successfully");




                }






            }

            catch (Exception ex)
            {

                if (objTrans != null)
                {
                    objTrans.Rollback();
                }


                MessageBox.Show(ex.Message.ToString(), "SMSTimeConfiguration", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(txtTime.Text.Trim()))
            {

                IsOk = false;
                MessageBox.Show("Please enter Time in Minutes");

            }
            else
            {
                string s = txtTime.Text.Trim();
                string strPattern = "^[0-9]+$";

                if (Regex.IsMatch(s, strPattern) == false)
                {
                    MessageBox.Show("Numveri value is allowed");

                    txtTime.Focus();
                    IsOk = false;


                }

            }


            return IsOk;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SMSAlertTimeConfiguration_Load(object sender, EventArgs e)
        {
            try
            {

                DataSet ds_tmp = GetSMSTimeConfig();
                bool isexist = Common.CommonFuncVar.IsValidateDS(ds_tmp);
                if (isexist == true)
                {
                    txtTime.Text = ds_tmp.Tables[0].Rows[0]["SMSMinutes"].ToString();


                }

            }
            catch (Exception ex)
            {



                MessageBox.Show(ex.Message.ToString(), "SMSTimeConfiguration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private DataSet GetSMSTimeConfig()
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
                cmd.CommandText = "select *  from  SMSConfiguration";
                adpt.SelectCommand = cmd;
                adpt.Fill(ds_tmp, "SMSAlertNoConfiguration");














            }

            catch (Exception ex)
            {



                MessageBox.Show(ex.Message.ToString(), "SMSTimeConfiguration", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
