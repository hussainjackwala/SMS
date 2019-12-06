namespace SMS
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmailContentConfiguration = new System.Windows.Forms.Button();
            this.btn_SMSMobileNoConfig = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btn_DeleteRecords = new System.Windows.Forms.Button();
            this.btn_SMSTimeConfig = new System.Windows.Forms.Button();
            this.btn_SMTPConfiguration = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDBLoc = new System.Windows.Forms.Button();
            this.btnChanegPass = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnEmailContentConfiguration);
            this.panel1.Controls.Add(this.btn_SMSMobileNoConfig);
            this.panel1.Controls.Add(this.btnSendEmail);
            this.panel1.Controls.Add(this.btn_DeleteRecords);
            this.panel1.Controls.Add(this.btn_SMSTimeConfig);
            this.panel1.Controls.Add(this.btn_SMTPConfiguration);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDBLoc);
            this.panel1.Controls.Add(this.btnChanegPass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 566);
            this.panel1.TabIndex = 0;
            // 
            // btnEmailContentConfiguration
            // 
            this.btnEmailContentConfiguration.BackColor = System.Drawing.Color.White;
            this.btnEmailContentConfiguration.BackgroundImage = global::SMS.Properties.Resources.EmailContent;
            this.btnEmailContentConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmailContentConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailContentConfiguration.Location = new System.Drawing.Point(31, 219);
            this.btnEmailContentConfiguration.Name = "btnEmailContentConfiguration";
            this.btnEmailContentConfiguration.Size = new System.Drawing.Size(55, 29);
            this.btnEmailContentConfiguration.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnEmailContentConfiguration, "Email Content Configuration");
            this.btnEmailContentConfiguration.UseVisualStyleBackColor = false;
            this.btnEmailContentConfiguration.Click += new System.EventHandler(this.btnEmailContentConfiguration_Click);
            // 
            // btn_SMSMobileNoConfig
            // 
            this.btn_SMSMobileNoConfig.BackColor = System.Drawing.Color.White;
            this.btn_SMSMobileNoConfig.BackgroundImage = global::SMS.Properties.Resources.MobileNo;
            this.btn_SMSMobileNoConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SMSMobileNoConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SMSMobileNoConfig.Location = new System.Drawing.Point(31, 335);
            this.btn_SMSMobileNoConfig.Name = "btn_SMSMobileNoConfig";
            this.btn_SMSMobileNoConfig.Size = new System.Drawing.Size(55, 29);
            this.btn_SMSMobileNoConfig.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_SMSMobileNoConfig, "SMS Mobile No Configuration");
            this.btn_SMSMobileNoConfig.UseVisualStyleBackColor = false;
            this.btn_SMSMobileNoConfig.Click += new System.EventHandler(this.btn_SMSMobileNoConfig_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.White;
            this.btnSendEmail.BackgroundImage = global::SMS.Properties.Resources.EMAIL;
            this.btnSendEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Location = new System.Drawing.Point(31, 451);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(55, 29);
            this.btnSendEmail.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSendEmail, "Send Email");
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btn_DeleteRecords
            // 
            this.btn_DeleteRecords.BackColor = System.Drawing.Color.White;
            this.btn_DeleteRecords.BackgroundImage = global::SMS.Properties.Resources.delete_records;
            this.btn_DeleteRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DeleteRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteRecords.Location = new System.Drawing.Point(31, 393);
            this.btn_DeleteRecords.Name = "btn_DeleteRecords";
            this.btn_DeleteRecords.Size = new System.Drawing.Size(55, 29);
            this.btn_DeleteRecords.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_DeleteRecords, "Delete Logs");
            this.btn_DeleteRecords.UseVisualStyleBackColor = false;
            this.btn_DeleteRecords.Click += new System.EventHandler(this.btn_DeleteRecords_Click);
            // 
            // btn_SMSTimeConfig
            // 
            this.btn_SMSTimeConfig.BackColor = System.Drawing.Color.White;
            this.btn_SMSTimeConfig.BackgroundImage = global::SMS.Properties.Resources.TimeConfiguration;
            this.btn_SMSTimeConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SMSTimeConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SMSTimeConfig.Location = new System.Drawing.Point(31, 277);
            this.btn_SMSTimeConfig.Name = "btn_SMSTimeConfig";
            this.btn_SMSTimeConfig.Size = new System.Drawing.Size(55, 29);
            this.btn_SMSTimeConfig.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_SMSTimeConfig, "SMS Time Configuration");
            this.btn_SMSTimeConfig.UseVisualStyleBackColor = false;
            this.btn_SMSTimeConfig.Click += new System.EventHandler(this.btn_SMSTimeConfig_Click);
            // 
            // btn_SMTPConfiguration
            // 
            this.btn_SMTPConfiguration.BackColor = System.Drawing.Color.White;
            this.btn_SMTPConfiguration.BackgroundImage = global::SMS.Properties.Resources.SMTPServer;
            this.btn_SMTPConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SMTPConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SMTPConfiguration.Location = new System.Drawing.Point(31, 161);
            this.btn_SMTPConfiguration.Name = "btn_SMTPConfiguration";
            this.btn_SMTPConfiguration.Size = new System.Drawing.Size(55, 29);
            this.btn_SMTPConfiguration.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_SMTPConfiguration, "SMTP Configuration");
            this.btn_SMTPConfiguration.UseVisualStyleBackColor = false;
            this.btn_SMTPConfiguration.Click += new System.EventHandler(this.btn_SMTPConfiguration_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = global::SMS.Properties.Resources.Exitapplication;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(31, 509);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 29);
            this.btnExit.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnExit, "Application Exit");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDBLoc
            // 
            this.btnDBLoc.BackColor = System.Drawing.Color.White;
            this.btnDBLoc.BackgroundImage = global::SMS.Properties.Resources.database;
            this.btnDBLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDBLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBLoc.Location = new System.Drawing.Point(31, 103);
            this.btnDBLoc.Name = "btnDBLoc";
            this.btnDBLoc.Size = new System.Drawing.Size(55, 29);
            this.btnDBLoc.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnDBLoc, "Shrink and Copy DB");
            this.btnDBLoc.UseVisualStyleBackColor = false;
            this.btnDBLoc.Click += new System.EventHandler(this.btnDBLoc_Click);
            // 
            // btnChanegPass
            // 
            this.btnChanegPass.BackColor = System.Drawing.Color.White;
            this.btnChanegPass.BackgroundImage = global::SMS.Properties.Resources.changeuserpassword;
            this.btnChanegPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChanegPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChanegPass.Location = new System.Drawing.Point(31, 28);
            this.btnChanegPass.Name = "btnChanegPass";
            this.btnChanegPass.Size = new System.Drawing.Size(55, 29);
            this.btnChanegPass.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnChanegPass, "Change User  password");
            this.btnChanegPass.UseVisualStyleBackColor = false;
            this.btnChanegPass.Visible = false;
            this.btnChanegPass.Click += new System.EventHandler(this.btnChanegPass_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SMS.Properties.Resources.logo1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(115, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 566);
            this.panel2.TabIndex = 1;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChanegPass;
        private System.Windows.Forms.Button btnDBLoc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SMTPConfiguration;
        private System.Windows.Forms.Button btn_SMSTimeConfig;
        private System.Windows.Forms.Button btn_DeleteRecords;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btn_SMSMobileNoConfig;
        private System.Windows.Forms.Button btnEmailContentConfiguration;
    }
}