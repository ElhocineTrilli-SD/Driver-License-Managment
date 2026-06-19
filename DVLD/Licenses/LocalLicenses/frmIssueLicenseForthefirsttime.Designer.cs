namespace DVLD.Licenses.LocalLicenses
{
    partial class frmIssueLicenseForthefirsttime
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
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlDrivingLicenseApplication1 = new DVLD.Applications.Local_Driving_License.ctrlDrivingLicenseApplication();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BorderRadius = 10;
            this.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.Location = new System.Drawing.Point(633, 525);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(155, 53);
            this.btnsave.TabIndex = 25;
            this.btnsave.Text = "Issue";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.BorderRadius = 10;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclose.Location = new System.Drawing.Point(466, 525);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(155, 53);
            this.btnclose.TabIndex = 24;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ctrlDrivingLicenseApplication1
            // 
            this.ctrlDrivingLicenseApplication1.Location = new System.Drawing.Point(3, 3);
            this.ctrlDrivingLicenseApplication1.Name = "ctrlDrivingLicenseApplication1";
            this.ctrlDrivingLicenseApplication1.Size = new System.Drawing.Size(785, 389);
            this.ctrlDrivingLicenseApplication1.TabIndex = 26;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(87, 398);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(549, 106);
            this.txtNotes.TabIndex = 82;
            this.txtNotes.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Notes :";
            // 
            // frmIssueLicenseForthefirsttime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlDrivingLicenseApplication1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Name = "frmIssueLicenseForthefirsttime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue License For the first time";
            this.Load += new System.EventHandler(this.frmIssueLicenseForthefirsttime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnsave;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Applications.Local_Driving_License.ctrlDrivingLicenseApplication ctrlDrivingLicenseApplication1;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label label2;
    }
}