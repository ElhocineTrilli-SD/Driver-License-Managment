using System.Windows.Forms;

namespace DVLD.Applications.International_Driving_License
{
    partial class frmNewInternationalLicenseApplication
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
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.llblShowHistory = new System.Windows.Forms.LinkLabel();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gbDetainInfo = new System.Windows.Forms.GroupBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.lbl__LicenseID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblIAppID = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlLicenseInfoWithFilter1 = new DVLD.Licenses.Control.ctrlLicenseInfoWithFilter();
            this.gbDetainInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.btnclose.Location = new System.Drawing.Point(447, 496);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(155, 42);
            this.btnclose.TabIndex = 112;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // llblShowHistory
            // 
            this.llblShowHistory.AutoSize = true;
            this.llblShowHistory.Enabled = false;
            this.llblShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowHistory.Location = new System.Drawing.Point(19, 493);
            this.llblShowHistory.Name = "llblShowHistory";
            this.llblShowHistory.Size = new System.Drawing.Size(135, 16);
            this.llblShowHistory.TabIndex = 111;
            this.llblShowHistory.TabStop = true;
            this.llblShowHistory.Text = "Show License History";
            this.llblShowHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowHistory_LinkClicked);
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Enabled = false;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(166, 493);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(114, 16);
            this.llblShowLicenseInfo.TabIndex = 110;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowLicenseInfo_LinkClicked);
            // 
            // gbDetainInfo
            // 
            this.gbDetainInfo.Controls.Add(this.lblCreatedBy);
            this.gbDetainInfo.Controls.Add(this.label7);
            this.gbDetainInfo.Controls.Add(this.lblExpirationDate);
            this.gbDetainInfo.Controls.Add(this.label5);
            this.gbDetainInfo.Controls.Add(this.lblFees);
            this.gbDetainInfo.Controls.Add(this.lblIssueDate);
            this.gbDetainInfo.Controls.Add(this.label1);
            this.gbDetainInfo.Controls.Add(this.lblLocalLicenseID);
            this.gbDetainInfo.Controls.Add(this.lbl__LicenseID);
            this.gbDetainInfo.Controls.Add(this.label3);
            this.gbDetainInfo.Controls.Add(this.label4);
            this.gbDetainInfo.Controls.Add(this.lblAppDate);
            this.gbDetainInfo.Controls.Add(this.label15);
            this.gbDetainInfo.Controls.Add(this.lblIAppID);
            this.gbDetainInfo.Controls.Add(this.label18);
            this.gbDetainInfo.Controls.Add(this.label19);
            this.gbDetainInfo.Location = new System.Drawing.Point(12, 319);
            this.gbDetainInfo.Name = "gbDetainInfo";
            this.gbDetainInfo.Size = new System.Drawing.Size(690, 171);
            this.gbDetainInfo.TabIndex = 109;
            this.gbDetainInfo.TabStop = false;
            this.gbDetainInfo.Text = "Detain Info";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(495, 134);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(21, 19);
            this.lblCreatedBy.TabIndex = 117;
            this.lblCreatedBy.Text = "??";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(390, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 116;
            this.label7.Text = "Created By :";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDate.Location = new System.Drawing.Point(530, 101);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(21, 19);
            this.lblExpirationDate.TabIndex = 115;
            this.lblExpirationDate.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(390, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 114;
            this.label5.Text = "Expiration Date :";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Black;
            this.lblFees.Location = new System.Drawing.Point(76, 134);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(21, 19);
            this.lblFees.TabIndex = 113;
            this.lblFees.Text = "??";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDate.Location = new System.Drawing.Point(119, 101);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(21, 19);
            this.lblIssueDate.TabIndex = 112;
            this.lblIssueDate.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 111;
            this.label1.Text = " Fees :";
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLocalLicenseID.Location = new System.Drawing.Point(532, 66);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(21, 19);
            this.lblLocalLicenseID.TabIndex = 110;
            this.lblLocalLicenseID.Text = "??";
            // 
            // lbl__LicenseID
            // 
            this.lbl__LicenseID.AutoSize = true;
            this.lbl__LicenseID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl__LicenseID.ForeColor = System.Drawing.Color.Black;
            this.lbl__LicenseID.Location = new System.Drawing.Point(503, 31);
            this.lbl__LicenseID.Name = "lbl__LicenseID";
            this.lbl__LicenseID.Size = new System.Drawing.Size(23, 19);
            this.lbl__LicenseID.TabIndex = 109;
            this.lbl__LicenseID.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(402, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 108;
            this.label3.Text = "I.License ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(390, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 107;
            this.label4.Text = "Local License ID :";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.ForeColor = System.Drawing.Color.Black;
            this.lblAppDate.Location = new System.Drawing.Point(153, 66);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(21, 19);
            this.lblAppDate.TabIndex = 106;
            this.lblAppDate.Text = "??";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(23, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 19);
            this.label15.TabIndex = 105;
            this.label15.Text = "Issue Date :";
            // 
            // lblIAppID
            // 
            this.lblIAppID.AutoSize = true;
            this.lblIAppID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblIAppID.ForeColor = System.Drawing.Color.Black;
            this.lblIAppID.Location = new System.Drawing.Point(153, 31);
            this.lblIAppID.Name = "lblIAppID";
            this.lblIAppID.Size = new System.Drawing.Size(23, 19);
            this.lblIAppID.TabIndex = 104;
            this.lblIAppID.Text = "??";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(6, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 19);
            this.label18.TabIndex = 102;
            this.label18.Text = "I.L ApplicationID :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(4, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 19);
            this.label19.TabIndex = 101;
            this.label19.Text = "Application Date :";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(453, 12);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(301, 36);
            this.lblTitel.TabIndex = 114;
            this.lblTitel.Text = "International License";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(631, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 36);
            this.label2.TabIndex = 115;
            this.label2.Text = "Application";
            // 
            // btnIssue
            // 
            this.btnIssue.BorderRadius = 10;
            this.btnIssue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssue.Enabled = false;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIssue.Location = new System.Drawing.Point(625, 496);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(155, 42);
            this.btnIssue.TabIndex = 113;
            this.btnIssue.Text = "Issue";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(699, 311);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 108;
            this.ctrlLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmNewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.llblShowHistory);
            this.Controls.Add(this.llblShowLicenseInfo);
            this.Controls.Add(this.gbDetainInfo);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.Name = "frmNewInternationalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New International License Application";
            this.Load += new System.EventHandler(this.frmNewInternationalLicenseApplication_Load);
            this.gbDetainInfo.ResumeLayout(false);
            this.gbDetainInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnIssue;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.LinkLabel llblShowHistory;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.GroupBox gbDetainInfo;
        private Label lblCreatedBy;
        private System.Windows.Forms.Label lblLocalLicense_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocalLicenseID;
        private System.Windows.Forms.Label lbl__LicenseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblIAppID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private Licenses.Control.ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label label2;
    }
}