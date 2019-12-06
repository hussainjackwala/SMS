using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Diagnostics;
namespace SMS
{
    public partial class AdminPanel : Form
    {
       //SplashSceen sp = new SplashSceen();
        public AdminPanel()
        {
            InitializeComponent();
           
        }

        

       

        private void btnChanegPass_Click(object sender, EventArgs e)
        {
            try
            {

                ChangePassword chngpass = new ChangePassword();

                chngpass.ShowDialog();
            }

            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDBLoc_Click(object sender, EventArgs e)
        {
            try
            {

                DBLocation dbloc = new DBLocation();

                dbloc.ShowDialog();
            }

            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((File.Exists(spath)) == true)
                {

                    File.WriteAllText(spath, string.Empty);


                    Application.Exit();




                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        String spath = Application.StartupPath + "\\FN.txt";
        private void AdminPanel_Load(object sender, EventArgs e)
        {

           
            System.IO.StreamWriter myStreamWriter = null;
            try
            {
                Process[] p = System.Diagnostics.Process.GetProcessesByName("htas");

                if (p.Length > 0)
                {



                    if (!(File.Exists(spath)) == true)
                    {
                        myStreamWriter = File.CreateText(spath);
                        myStreamWriter.Write("");

                        myStreamWriter.Flush();
                        myStreamWriter.Close();

                        Application.Exit();




                    }


                    else
                    {
                        String STR = File.ReadAllText(spath);



                        if (STR.Length > 0)
                        {
                            if (STR != "1")
                            {

                                Application.Exit();
                            }



                        }
                        else
                        {
                            Application.Exit();

                        }
                    }


                }
                else
                {
                    Application.Exit();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //System.Threading.Thread.Sleep(2000);
            //WindowState = FormWindowState.Maximized;
            //sp.Close();
            //Login log = new Login();

            //log.ShowDialog();


        }

        private void btn_SMTPConfiguration_Click(object sender, EventArgs e)
        {
            try
            {
                SMTPConfiguration dellog = new SMTPConfiguration();
                dellog.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_SMSTimeConfig_Click(object sender, EventArgs e)
        {
            try
            { 
            SMSAlertTimeConfiguration smslert = new SMSAlertTimeConfiguration();
            smslert.ShowDialog();
            }
        catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DeleteRecords_Click(object sender, EventArgs e)
        {
            try
            { 
            DeleteLogs dellog = new DeleteLogs();
            dellog.ShowDialog();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
               frmEmailBlaster   Email = new  frmEmailBlaster();
                Email.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_SMSMobileNoConfig_Click(object sender, EventArgs e)
        {
            try
            {
                SMSAlertConfig AlertConfig = new SMSAlertConfig();
                AlertConfig.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmailContentConfiguration_Click(object sender, EventArgs e)
        {
            try
            {
                EmailContent MailContent = new EmailContent();
                MailContent.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if ((File.Exists(spath)) == true)
                {

                    File.WriteAllText(spath, string.Empty);


                    Application.Exit();




                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            //try
            //{
            //    if ((File.Exists(spath)) == true)
            //    {

            //        File.WriteAllText(spath, string.Empty);


            //        Application.Exit();




            //    }

            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    
    }
}
