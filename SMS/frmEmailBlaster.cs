using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.IO;

namespace SMS
{
    public partial class frmEmailBlaster : Form
    {
        OleDbConnection CN;
        DataTable myDataSet = null;
        DataSet ds_mail = null;
        string varFileName="";
        String spath = Application.StartupPath + "\\EmailLog.txt";
        [DllImport("ODBCCP32.DLL")]
        
        private static extern int SQLConfigDataSource(int hwndParent, int fRequest, string lpszDriver, string lpszAttributes);

        public frmEmailBlaster()
        {
            InitializeComponent();
        }

        private void frmEmailBlaster_Load(object sender, EventArgs e)
        {

            string varConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + Application.StartupPath + @"\db\SMSAlert.accdb';Jet OLEDB:Database Password='rdshmhadminff1c28c';";

            CN = new OleDbConnection();
            CN.ConnectionString = varConnectionString;

            //'===============CREAT DSN
            CreateDSN();
            //'====================CREATE DSN


            ds_mail = GetEmailContent();



        }

        private void CreateDSN()
        {
            int ii = 0;
            char cc = (char)ii;

            //string sDriver = "Microsoft Access Driver (*.mdb,*.accdb)";
            string sDriver = "Microsoft Access Driver (*.mdb, *.accdb)";
            System.Text.StringBuilder sAttributes = new System.Text.StringBuilder();
            int ODBC_ADD_SYS_DSN = 4;
            long intResult;

            sAttributes.Append("DSN=SMSAlert");
            sAttributes.Append("\0");
            sAttributes.Append("DBQ=");
            sAttributes.Append(Application.StartupPath);
            sAttributes.Append(@"\db\SMSAlert.accdb");
            //sAttributes.Append("\0");

            // sAttributes.Append("\0");

            //SQLConfigDataSource(

            intResult = SQLConfigDataSource(0, ODBC_ADD_SYS_DSN, sDriver, sAttributes.ToString());


            sAttributes = null;
        } 

      
      


        private void StartEmailBlaster()
        {
          
            lblStatus.Text = "Start Fetching Records!";
            Application.DoEvents();
            string varFilePath = Application.StartupPath + "\\"  ;
            varFileName = "send_email.json"; 
            string STR = "";
            

            try
            {
                STR = System.IO.File.ReadAllText(varFilePath + "" + varFileName);
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
                return;
            }

            try
            {
                myDataSet = JsonConvert.DeserializeObject<DataTable>(STR);
                myDataSet.Columns.Add("Status", typeof(string));
                lblStatus.Text = "Fetched Successfully";
                btn_SendEmail.Enabled = true;
                DG1.DataSource = myDataSet;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
                WriteErrorLog(spath, ex.Message + "   " + ex.ToString());
                btn_SendEmail.Enabled = false ;
                return;
            }



         
        }

        private string SendEmailAndImportData(DataTable DBDataTable, string varFileName)
        {
            string varReturn = "OK";
            try
            {
                //int varMaxTransID = GetMaxSMSTransId(varFileName);
                //DataRow[] varDataRow = DBDataTable.Select("TransID > " + GetMaxSMSTransId(varFileName));
                DataRow[] varDataRow = DBDataTable.Select("ID <> '' ");
               // DG1.DataSource = varDataRow.CopyToDataTable();

                OleDbCommand DBCommand;
                string SQLString = "";

                for (int x = 0; x < varDataRow.Length; x++)
                {

                    DG1.Rows[x].Selected = true;


               
                        lblStatus.Text = "Sending (" + (x + 1) + " / " + varDataRow.Length + ") Email Text To  Mr/Miss : " + varDataRow[x]["name"].ToString() + ". Email : " + varDataRow[x]["Email"].ToString();
                        Application.DoEvents();

                        if (SendEmail(varDataRow[x]["Email"].ToString(), varDataRow[x]["attachment"].ToString()) == true)
                        {
                            DG1[4, x].Value = "Success";
                            SQLString = "insert into EmailLog (ID,FileName,EmployeeName,email,attachment,Status,StatusMsg,SendDateTime) values(" + varDataRow[x]["ID"].ToString() + ",'" + varFileName + "','" + varDataRow[x]["name"].ToString() + "','" + varDataRow[x]["Email"].ToString() + "','" + varDataRow[x]["attachment"].ToString() + "',1,'Success','" + DateTime.Now + "')";
                        }
                        else
                        {
                            DG1[4, x].Value = "Failed";
                            SQLString = "insert into EmailLog (ID,FileName,EmployeeName,email,attachment,Status,StatusMsg,SendDateTime) values(" + varDataRow[x]["ID"].ToString() + ",'" + varFileName + "','" + varDataRow[x]["name"].ToString() + "','" + varDataRow[x]["Email"].ToString() + "','" + varDataRow[x]["attachment"].ToString() + "',0,'Failure','" + DateTime.Now + "')";
                        }

                        Application.DoEvents();

                        DBCommand = new OleDbCommand(SQLString, CN);

                        try
                        {
                            CN.Open();
                        }
                        catch (Exception ex)
                        {
                        string smsg = ex.Message;

                        WriteErrorLog(spath, ex.Message + "   " + ex.ToString());
                    }

                        DBCommand.ExecuteNonQuery();
                        DBCommand.Connection.Close();

                        try
                        {
                            CN.Close();
                        }
                        catch (Exception ex)
                        {

                        string smsg = ex.Message;
                        WriteErrorLog(spath, ex.Message + "   " + ex.ToString());
                    }

                }


            }
            catch (Exception ex)
            {
                varReturn = ex.Message.ToString();
                WriteErrorLog(spath, ex.Message + "   " + ex.ToString());
            }


            return varReturn;
        }

        private bool SendEmail(string varEmailTo, string varAttachment)
        {

            DataSet DSEmailConfig = GetEmailConfiguration();


            try
            {
                
            System.Net.ServicePointManager.ServerCertificateValidationCallback = ((ser, certificate, chain, sslPolicyErrors) => true);

            SmtpClient Smtp_Server = new SmtpClient();

            MailMessage e_mail = new MailMessage();

            Smtp_Server.UseDefaultCredentials = false;

            Smtp_Server.Credentials = new System.Net.NetworkCredential(DSEmailConfig.Tables[0].Rows[0]["UserName"].ToString(), EncrDecAlgo.CryptorEngine.Decrypt(DSEmailConfig.Tables[0].Rows[0]["User_Password"].ToString(), true));

            Smtp_Server.Port = int.Parse(DSEmailConfig.Tables[0].Rows[0]["Port_No"].ToString());

            Smtp_Server.EnableSsl = bool.Parse(DSEmailConfig.Tables[0].Rows[0]["ISSSL"].ToString());

            Smtp_Server.Host = DSEmailConfig.Tables[0].Rows[0]["Server_Name"].ToString();

            //e_mail = new MailMessage();

            e_mail.From = new MailAddress(DSEmailConfig.Tables[0].Rows[0]["display_Email"].ToString(), DSEmailConfig.Tables[0].Rows[0]["display_UserName"].ToString());

            e_mail.To.Add(varEmailTo);

            e_mail.IsBodyHtml = true;
                string EmailSubject = "";
                string EmailHeader = "";
              
                string EmailBody = "";
                string EmailFooter = "";
                bool isok = Common.CommonFuncVar.IsValidateDS (ds_mail);
                if (isok==true)
                {
                    EmailSubject = ds_mail.Tables[0].Rows[0]["EmailSubject"].ToString();
                    EmailHeader= ds_mail.Tables[0].Rows[0]["EmailHeader"].ToString();
                    EmailBody = ds_mail.Tables[0].Rows[0]["EmailBody"].ToString();
                    EmailFooter = ds_mail.Tables[0].Rows[0]["EmailFooter"].ToString();


                }

                e_mail.Subject = EmailSubject; //"Email From My System" ;

            e_mail.Body = EmailHeader + "<br>" + EmailBody + "<br><hr>" + EmailFooter ; //"This is system generated Email." + "<br><br>" + "Please detach the attahed file." ;

            System.Net.Mail.Attachment attachment;

            attachment = new System.Net.Mail.Attachment(varAttachment);

            e_mail.Attachments.Add(attachment);


            Smtp_Server.Send(e_mail);

            e_mail.Dispose();

            Smtp_Server = null;

            return true;
         
            }
            catch (Exception ex)
            {
                string smsg=ex.Message;
                WriteErrorLog(spath, ex.Message + "      " + ex.ToString());
             return false;
            }


        }
        
        private DataSet GetEmailConfiguration()
        {

            OleDbDataAdapter DBAdapter;
            DataSet DBDataSet;


            DBAdapter = new OleDbDataAdapter("select Server_Name, Port_No , UserName , User_Password ,Display_UserName,Display_Email, ISSSL from SMTPConfiguration" , CN);
            DBDataSet = new DataSet();

            DBAdapter.Fill(DBDataSet);


            return DBDataSet;

            // Follow up with this Case ID
            //Case #38263509
        }

        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Start Sending Email!";
            string varImportData = SendEmailAndImportData(myDataSet, varFileName);
            if (varImportData != "OK")
            {
                btn_SendEmail.Enabled = false;
                lblStatus.Text = varImportData;
                return;
            }
            else
            {
                lblStatus.Text = "Email Blasting Completed Successfully!";
                btn_SendEmail.Enabled = false;
            }
        }

        private void btn_Fetch_Click(object sender, EventArgs e)
        {
            DG1.DataSource = null;
            StartEmailBlaster();
        }

        private void WriteErrorLog(string spath,String LogsMessage)
        {
            System.IO.StreamWriter myStreamWriter = null;
            try
            {
             
                if (!(File.Exists(spath) == true))
                {
                    myStreamWriter = File.CreateText(spath);
                    myStreamWriter.WriteLine(System.DateTime.Now + "   " +  LogsMessage);
                                    
                }
                else
                {
                    myStreamWriter = File.AppendText(spath);
                    myStreamWriter.WriteLine("------------------------------------------------");
                    myStreamWriter.WriteLine(System.DateTime.Now + "   " + LogsMessage);
                                   
                }

            }
            catch ( Exception ex)
            {
                string Msg = ex.Message;
            }
            finally
            {
                if (!(myStreamWriter == null))
                {
                    myStreamWriter.Flush();
                    myStreamWriter.Close();
                }

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private DataSet GetEmailContent()
        {

            OleDbDataAdapter DBAdapter;
            DataSet DBDataSet;


            DBAdapter = new OleDbDataAdapter("select *  from EmailContent", CN);
            DBDataSet = new DataSet();

            DBAdapter.Fill(DBDataSet);


            return DBDataSet;

            // Follow up with this Case ID
            //Case #38263509
        }


       
    }
}
