using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace SMS
{
    public partial class DBLocation : Form
    {
        public DBLocation()
        {
            InitializeComponent();
        }

        private void btnDBPath_Click(object sender, EventArgs e)
        {
            var file = GetFile();
            if (file != string.Empty)
            {
                
                    txtDBPath.Text = file;
                
            }
        }

        private string GetFile()
        {
            try
            {
             

                if (FolderBrowse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    return FolderBrowse.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopyDb_Click(object sender, EventArgs e)
        {
            try
            {
                btnClose.Enabled = false;
                btnCopyDb.Enabled = false;
                btnDBPath.Enabled = false;
              
                if (txtDBPath.Text.Trim() != string.Empty)
                {
                    lblProgesss.Visible = true;
                    Application.DoEvents();


                    string File_Path;
                    string compact_file;
                    File_Path = Application.StartupPath + "\\DB\\SMS.accdb"; //Application.StartupPath  + "\\DB\\Lectures.mdb"; 
                    compact_file = Application.StartupPath + "\\DB\\SMS1.accdb";// Application.StartupPath + "\\DB\\Lectures1.mdb";
                    if (File.Exists(File_Path))
                    {

                     

                        Microsoft.Office.Interop.Access.Dao.DBEngine abc = new Microsoft.Office.Interop.Access.Dao.DBEngine();

                        abc.CompactDatabase(File_Path, compact_file);
                    }



                 





                    if (File.Exists(compact_file))
                    {
                        File.Delete(File_Path);
                        File.Move(compact_file, File_Path);
                    }

                


                    if (Directory.Exists(txtDBPath.Text.Trim()))
                    {
                        if (File.Exists(Application.StartupPath + @"\DB\SMS.accdb"))
                        {

                            File.Copy(Application.StartupPath + @"\DB\SMS.accdb", txtDBPath.Text.Trim() + @"\SMS.accdb", true);
                            MessageBox.Show("File has been copied sucessfully", "DBLocation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(txtDBPath.Text.Trim());
                        if (File.Exists(Application.StartupPath + @"\DB\SMS.accdb"))
                        {

                            File.Copy(Application.StartupPath + @"\DB\SMS.accdb", txtDBPath.Text.Trim() + @"\SMS.accdb", true);
                            MessageBox.Show("File has been copied sucessfully", "DBLocation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }



                }

                else
                {
                    MessageBox.Show("Select a proper path.", "DBLocation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lblProgesss.Visible = false;
                btnClose.Enabled = true;
                btnCopyDb.Enabled = true;
                btnDBPath.Enabled = true;
                txtDBPath.Text = "";
            }
        }

        private void lblProgesss_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDBPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void FolderBrowse_HelpRequest(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
