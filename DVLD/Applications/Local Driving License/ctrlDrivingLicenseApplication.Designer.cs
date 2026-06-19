namespace DVLD.Applications.Local_Driving_License
{
    partial class ctrlDrivingLicenseApplication
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grDrivingLicenseA = new System.Windows.Forms.GroupBox();
            this.lblPassedTest = new System.Windows.Forms.Label();
            this.txtAppliedforL = new System.Windows.Forms.Label();
            this.txtDLApplicationID = new System.Windows.Forms.Label();
            this.llblShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblPassedTe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.userControl_ApplicationBasic1 = new DVLD.Applications.controlls.UserControl_ApplicationBasic();
            this.grDrivingLicenseA.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDrivingLicenseA
            // 
            this.grDrivingLicenseA.Controls.Add(this.lblPassedTest);
            this.grDrivingLicenseA.Controls.Add(this.txtAppliedforL);
            this.grDrivingLicenseA.Controls.Add(this.txtDLApplicationID);
            this.grDrivingLicenseA.Controls.Add(this.llblShowLicenseInfo);
            this.grDrivingLicenseA.Controls.Add(this.lblPassedTe);
            this.grDrivingLicenseA.Controls.Add(this.label1);
            this.grDrivingLicenseA.Controls.Add(this.lblUserID);
            this.grDrivingLicenseA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grDrivingLicenseA.Location = new System.Drawing.Point(3, 3);
            this.grDrivingLicenseA.Name = "grDrivingLicenseA";
            this.grDrivingLicenseA.Size = new System.Drawing.Size(770, 131);
            this.grDrivingLicenseA.TabIndex = 0;
            this.grDrivingLicenseA.TabStop = false;
            this.grDrivingLicenseA.Text = " Driving License Application Info";
            this.grDrivingLicenseA.Enter += new System.EventHandler(this.grDrivingLicenseA_Enter);
            // 
            // lblPassedTest
            // 
            this.lblPassedTest.AutoSize = true;
            this.lblPassedTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPassedTest.ForeColor = System.Drawing.Color.Black;
            this.lblPassedTest.Location = new System.Drawing.Point(480, 78);
            this.lblPassedTest.Name = "lblPassedTest";
            this.lblPassedTest.Size = new System.Drawing.Size(34, 19);
            this.lblPassedTest.TabIndex = 54;
            this.lblPassedTest.Text = "0/0";
            // 
            // txtAppliedforL
            // 
            this.txtAppliedforL.AutoSize = true;
            this.txtAppliedforL.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtAppliedforL.ForeColor = System.Drawing.Color.Black;
            this.txtAppliedforL.Location = new System.Drawing.Point(480, 40);
            this.txtAppliedforL.Name = "txtAppliedforL";
            this.txtAppliedforL.Size = new System.Drawing.Size(23, 19);
            this.txtAppliedforL.TabIndex = 53;
            this.txtAppliedforL.Text = "??";
            // 
            // txtDLApplicationID
            // 
            this.txtDLApplicationID.AutoSize = true;
            this.txtDLApplicationID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtDLApplicationID.ForeColor = System.Drawing.Color.Red;
            this.txtDLApplicationID.Location = new System.Drawing.Point(173, 40);
            this.txtDLApplicationID.Name = "txtDLApplicationID";
            this.txtDLApplicationID.Size = new System.Drawing.Size(23, 19);
            this.txtDLApplicationID.TabIndex = 52;
            this.txtDLApplicationID.Text = "??";
            // 
            // llblShowLicenseInfo
            // 
            this.llblShowLicenseInfo.AutoSize = true;
            this.llblShowLicenseInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.llblShowLicenseInfo.Location = new System.Drawing.Point(64, 78);
            this.llblShowLicenseInfo.Name = "llblShowLicenseInfo";
            this.llblShowLicenseInfo.Size = new System.Drawing.Size(145, 19);
            this.llblShowLicenseInfo.TabIndex = 51;
            this.llblShowLicenseInfo.TabStop = true;
            this.llblShowLicenseInfo.Text = "Show License Info";
            this.llblShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblPassedTe
            // 
            this.lblPassedTe.AutoSize = true;
            this.lblPassedTe.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPassedTe.Location = new System.Drawing.Point(363, 78);
            this.lblPassedTe.Name = "lblPassedTe";
            this.lblPassedTe.Size = new System.Drawing.Size(111, 19);
            this.lblPassedTe.TabIndex = 50;
            this.lblPassedTe.Text = "Passed Tests :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(314, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Applied for License :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(15, 40);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(152, 19);
            this.lblUserID.TabIndex = 48;
            this.lblUserID.Text = "D.L.Application ID :";
            // 
            // userControl_ApplicationBasic1
            // 
            this.userControl_ApplicationBasic1.Location = new System.Drawing.Point(3, 141);
            this.userControl_ApplicationBasic1.Name = "userControl_ApplicationBasic1";
            this.userControl_ApplicationBasic1.Size = new System.Drawing.Size(790, 248);
            this.userControl_ApplicationBasic1.TabIndex = 1;
            this.userControl_ApplicationBasic1.Load += new System.EventHandler(this.userControl_ApplicationBasic1_Load);
            // 
            // ctrlDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl_ApplicationBasic1);
            this.Controls.Add(this.grDrivingLicenseA);
            this.Name = "ctrlDrivingLicenseApplication";
            this.Size = new System.Drawing.Size(785, 389);
            this.Load += new System.EventHandler(this.ctrlDrivingLicenseApplication_Load);
            this.grDrivingLicenseA.ResumeLayout(false);
            this.grDrivingLicenseA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDrivingLicenseA;
        private System.Windows.Forms.LinkLabel llblShowLicenseInfo;
        private System.Windows.Forms.Label lblPassedTe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPassedTest;
        private System.Windows.Forms.Label txtAppliedforL;
        private System.Windows.Forms.Label txtDLApplicationID;
        private controlls.UserControl_ApplicationBasic userControl_ApplicationBasic1;
    }
}
