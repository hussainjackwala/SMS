namespace SMS
{
    partial class DeleteLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteLogs));
            this.btn_DelLogs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_DelLogs
            // 
            this.btn_DelLogs.BackColor = System.Drawing.Color.White;
            this.btn_DelLogs.BackgroundImage = global::SMS.Properties.Resources.Truncate_Logs;
            this.btn_DelLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_DelLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DelLogs.Location = new System.Drawing.Point(211, 56);
            this.btn_DelLogs.Name = "btn_DelLogs";
            this.btn_DelLogs.Size = new System.Drawing.Size(59, 36);
            this.btn_DelLogs.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btn_DelLogs, "Delete Logs");
            this.btn_DelLogs.UseVisualStyleBackColor = false;
            this.btn_DelLogs.Click += new System.EventHandler(this.btn_DelLogs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Logs :";
            // 
            // DeleteLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMS.Properties.Resources.Main1;
            this.ClientSize = new System.Drawing.Size(464, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DelLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteLogs";
            this.Text = "Delete Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DelLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}