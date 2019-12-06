namespace SMS
{
    partial class DBLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBLocation));
            this.FolderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProgesss = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopyDb = new System.Windows.Forms.Button();
            this.txtDBPath = new System.Windows.Forms.TextBox();
            this.btnDBPath = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderBrowse
            // 
            this.FolderBrowse.HelpRequest += new System.EventHandler(this.FolderBrowse_HelpRequest);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::SMS.Properties.Resources.Main;
            this.panel1.Controls.Add(this.lblProgesss);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCopyDb);
            this.panel1.Controls.Add(this.txtDBPath);
            this.panel1.Controls.Add(this.btnDBPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 98);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblProgesss
            // 
            this.lblProgesss.AutoSize = true;
            this.lblProgesss.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgesss.ForeColor = System.Drawing.Color.Red;
            this.lblProgesss.Location = new System.Drawing.Point(240, 54);
            this.lblProgesss.Name = "lblProgesss";
            this.lblProgesss.Size = new System.Drawing.Size(442, 22);
            this.lblProgesss.TabIndex = 16;
            this.lblProgesss.Text = "Please Wait Task is in Process it may take few minutes";
            this.lblProgesss.Visible = false;
            this.lblProgesss.Click += new System.EventHandler(this.lblProgesss_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::SMS.Properties.Resources.closed;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(182, 54);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 23);
            this.btnClose.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter  path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCopyDb
            // 
            this.btnCopyDb.BackColor = System.Drawing.Color.White;
            this.btnCopyDb.BackgroundImage = global::SMS.Properties.Resources.databackup;
            this.btnCopyDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCopyDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyDb.ForeColor = System.Drawing.Color.White;
            this.btnCopyDb.Location = new System.Drawing.Point(131, 54);
            this.btnCopyDb.Name = "btnCopyDb";
            this.btnCopyDb.Size = new System.Drawing.Size(45, 23);
            this.btnCopyDb.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCopyDb, "Shrink and Copy DB");
            this.btnCopyDb.UseVisualStyleBackColor = false;
            this.btnCopyDb.Click += new System.EventHandler(this.btnCopyDb_Click);
            // 
            // txtDBPath
            // 
            this.txtDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBPath.Location = new System.Drawing.Point(131, 24);
            this.txtDBPath.MaxLength = 255;
            this.txtDBPath.Name = "txtDBPath";
            this.txtDBPath.ReadOnly = true;
            this.txtDBPath.Size = new System.Drawing.Size(542, 20);
            this.txtDBPath.TabIndex = 0;
            this.txtDBPath.TextChanged += new System.EventHandler(this.txtDBPath_TextChanged);
            // 
            // btnDBPath
            // 
            this.btnDBPath.BackColor = System.Drawing.Color.White;
            this.btnDBPath.BackgroundImage = global::SMS.Properties.Resources.textfilepath;
            this.btnDBPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDBPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDBPath.ForeColor = System.Drawing.Color.White;
            this.btnDBPath.Location = new System.Drawing.Point(681, 24);
            this.btnDBPath.Name = "btnDBPath";
            this.btnDBPath.Size = new System.Drawing.Size(33, 23);
            this.btnDBPath.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnDBPath, "Provide Database Path");
            this.btnDBPath.UseVisualStyleBackColor = false;
            this.btnDBPath.Click += new System.EventHandler(this.btnDBPath_Click);
            // 
            // DBLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 110);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shrink and Copy DB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopyDb;
        private System.Windows.Forms.TextBox txtDBPath;
        private System.Windows.Forms.Button btnDBPath;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProgesss;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}