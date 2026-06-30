namespace DVLD.Applications.ReplaceLostOrDamagedLicense
{
    partial class frmReplecmentLicense
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
            this.grReplacement = new System.Windows.Forms.GroupBox();
            this.rbDamagedL = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbLostL = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnIssueReplacement = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.llblShowHistory = new System.Windows.Forms.LinkLabel();
            this.llblShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblRLAppID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.ctrlLicenseInfoWithFilter2 = new DVLD.Licenses.Control.ctrlLicenseInfoWithFilter();
            this.grReplacement.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grReplacement
            // 
            this.grReplacement.Controls.Add(this.rbDamagedL);
            this.grReplacement.Controls.Add(this.rbLostL);
            this.grReplacement.Location = new System.Drawing.Point(426, 56);
            this.grReplacement.Name = "grReplacement";
            this.grReplacement.Size = new System.Drawing.Size(238, 75);
            this.grReplacement.TabIndex = 98;
            this.grReplacement.TabStop = false;
            this.grReplacement.Text = "Replacement for :";
            // 
            // rbDamagedL
            // 
            this.rbDamagedL.AutoSize = true;
            this.rbDamagedL.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDamagedL.CheckedState.BorderThickness = 0;
            this.rbDamagedL.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDamagedL.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDamagedL.CheckedState.InnerOffset = -4;
            this.rbDamagedL.Location = new System.Drawing.Point(9, 19);
            this.rbDamagedL.Name = "rbDamagedL";
            this.rbDamagedL.Size = new System.Drawing.Size(111, 17);
            this.rbDamagedL.TabIndex = 1;
            this.rbDamagedL.Text = "Damaged License";
            this.rbDamagedL.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDamagedL.UncheckedState.BorderThickness = 2;
            this.rbDamagedL.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDamagedL.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbDamagedL.CheckedChanged += new System.EventHandler(this.rbDamagedL_CheckedChanged);
            // 
            // rbLostL
            // 
            this.rbLostL.AutoSize = true;
            this.rbLostL.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLostL.CheckedState.BorderThickness = 0;
            this.rbLostL.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLostL.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbLostL.CheckedState.InnerOffset = -4;
            this.rbLostL.Location = new System.Drawing.Point(9, 42);
            this.rbLostL.Name = "rbLostL";
            this.rbLostL.Size = new System.Drawing.Size(85, 17);
            this.rbLostL.TabIndex = 0;
            this.rbLostL.Text = "Lost License";
            this.rbLostL.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbLostL.UncheckedState.BorderThickness = 2;
            this.rbLostL.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLostL.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLostL.CheckedChanged += new System.EventHandler(this.rbLostL_CheckedChanged);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.BorderRadius = 10;
            this.btnIssueReplacement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssueReplacement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssueReplacement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssueReplacement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssueReplacement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReplacement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssueReplacement.Location = new System.Drawing.Point(570, 527);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(155, 34);
            this.btnIssueReplacement.TabIndex = 97;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
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
            this.btnclose.Location = new System.Drawing.Point(409, 527);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(155, 34);
            this.btnclose.TabIndex = 96;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // llblShowHistory
            // 
            this.llblShowHistory.AutoSize = true;
            this.llblShowHistory.Enabled = false;
            this.llblShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowHistory.Location = new System.Drawing.Point(25, 515);
            this.llblShowHistory.Name = "llblShowHistory";
            this.llblShowHistory.Size = new System.Drawing.Size(135, 16);
            this.llblShowHistory.TabIndex = 95;
            this.llblShowHistory.TabStop = true;
            this.llblShowHistory.Text = "Show License History";
            this.llblShowHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowHistory_LinkClicked);
            // 
            // llblShowNewLicenseInfo
            // 
            this.llblShowNewLicenseInfo.AutoSize = true;
            this.llblShowNewLicenseInfo.Enabled = false;
            this.llblShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblShowNewLicenseInfo.Location = new System.Drawing.Point(166, 515);
            this.llblShowNewLicenseInfo.Name = "llblShowNewLicenseInfo";
            this.llblShowNewLicenseInfo.Size = new System.Drawing.Size(144, 16);
            this.llblShowNewLicenseInfo.TabIndex = 94;
            this.llblShowNewLicenseInfo.TabStop = true;
            this.llblShowNewLicenseInfo.Text = "Show New License Info";
            this.llblShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblShowNewLicenseInfo_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAppDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblOldLicenseID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblReplacedLicenseID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblAppFees);
            this.groupBox1.Controls.Add(this.lblRLAppID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 117);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info for License Replacement";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.ForeColor = System.Drawing.Color.Black;
            this.lblAppDate.Location = new System.Drawing.Point(133, 61);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(21, 19);
            this.lblAppDate.TabIndex = 82;
            this.lblAppDate.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 81;
            this.label4.Text = "Application Date :";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(345, 89);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(21, 19);
            this.lblCreatedBy.TabIndex = 80;
            this.lblCreatedBy.Text = "??";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(256, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 19);
            this.label15.TabIndex = 79;
            this.label15.Text = "Created By :";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseID.Location = new System.Drawing.Point(363, 61);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(21, 19);
            this.lblOldLicenseID.TabIndex = 78;
            this.lblOldLicenseID.Text = "??";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(256, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 19);
            this.label13.TabIndex = 77;
            this.label13.Text = "Old LicenseID :";
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(396, 31);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(21, 19);
            this.lblReplacedLicenseID.TabIndex = 75;
            this.lblReplacedLicenseID.Text = "??";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(256, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 19);
            this.label11.TabIndex = 73;
            this.label11.Text = "Replaced LicenseID :";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.ForeColor = System.Drawing.Color.Black;
            this.lblAppFees.Location = new System.Drawing.Point(131, 89);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(21, 19);
            this.lblAppFees.TabIndex = 68;
            this.lblAppFees.Text = "??";
            // 
            // lblRLAppID
            // 
            this.lblRLAppID.AutoSize = true;
            this.lblRLAppID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLAppID.ForeColor = System.Drawing.Color.Black;
            this.lblRLAppID.Location = new System.Drawing.Point(131, 31);
            this.lblRLAppID.Name = "lblRLAppID";
            this.lblRLAppID.Size = new System.Drawing.Size(21, 19);
            this.lblRLAppID.TabIndex = 66;
            this.lblRLAppID.Text = "??";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Application Fees :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "R.L.ApplicationID :";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(12, 9);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(302, 36);
            this.lblTitel.TabIndex = 99;
            this.lblTitel.Text = "License Replacement";
            // 
            // ctrlLicenseInfoWithFilter2
            // 
            this.ctrlLicenseInfoWithFilter2.FilterEnabled = true;
            this.ctrlLicenseInfoWithFilter2.Location = new System.Drawing.Point(26, 56);
            this.ctrlLicenseInfoWithFilter2.Name = "ctrlLicenseInfoWithFilter2";
            this.ctrlLicenseInfoWithFilter2.Size = new System.Drawing.Size(699, 333);
            this.ctrlLicenseInfoWithFilter2.TabIndex = 93;
            this.ctrlLicenseInfoWithFilter2.OnLicenseSelected += new System.Action<int>(this.ctrlLicenseInfoWithFilter2_OnLicenseSelected);
            this.ctrlLicenseInfoWithFilter2.Load += new System.EventHandler(this.ctrlLicenseInfoWithFilter2_Load);
            // 
            // frmReplecmentLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 577);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.grReplacement);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.llblShowHistory);
            this.Controls.Add(this.llblShowNewLicenseInfo);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReplecmentLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replecement License";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grReplacement.ResumeLayout(false);
            this.grReplacement.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grReplacement;
        private Guna.UI2.WinForms.Guna2RadioButton rbDamagedL;
        private Guna.UI2.WinForms.Guna2RadioButton rbLostL;
        private Guna.UI2.WinForms.Guna2Button btnIssueReplacement;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.LinkLabel llblShowHistory;
        private System.Windows.Forms.LinkLabel llblShowNewLicenseInfo;
        private Licenses.Control.ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblRLAppID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitel;
    }
}