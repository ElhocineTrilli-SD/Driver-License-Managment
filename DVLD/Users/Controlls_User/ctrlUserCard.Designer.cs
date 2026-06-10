namespace DVLD.Users.Controlls_User
{
    partial class ctrlUserCard
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
            this.personInfoCard11 = new DVLD.PersonInfoCard1();
            this.gbUserinfo = new System.Windows.Forms.GroupBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.txtIsActive = new System.Windows.Forms.Label();
            this.gbUserinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // personInfoCard11
            // 
            this.personInfoCard11.Location = new System.Drawing.Point(3, 3);
            this.personInfoCard11.Name = "personInfoCard11";
            this.personInfoCard11.Size = new System.Drawing.Size(630, 283);
            this.personInfoCard11.TabIndex = 0;
            // 
            // gbUserinfo
            // 
            this.gbUserinfo.Controls.Add(this.txtIsActive);
            this.gbUserinfo.Controls.Add(this.txtUserName);
            this.gbUserinfo.Controls.Add(this.txtUserID);
            this.gbUserinfo.Controls.Add(this.lblUserID);
            this.gbUserinfo.Controls.Add(this.label7);
            this.gbUserinfo.Controls.Add(this.lblUsername);
            this.gbUserinfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbUserinfo.Location = new System.Drawing.Point(3, 292);
            this.gbUserinfo.Name = "gbUserinfo";
            this.gbUserinfo.Size = new System.Drawing.Size(630, 95);
            this.gbUserinfo.TabIndex = 1;
            this.gbUserinfo.TabStop = false;
            this.gbUserinfo.Text = "Login Information";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(16, 47);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(72, 19);
            this.lblUserID.TabIndex = 50;
            this.lblUserID.Text = "User ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(455, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "Is Active :";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(189, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 19);
            this.lblUsername.TabIndex = 48;
            this.lblUsername.Text = "User Name :";
            // 
            // txtUserID
            // 
            this.txtUserID.AutoSize = true;
            this.txtUserID.Location = new System.Drawing.Point(94, 47);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(27, 19);
            this.txtUserID.TabIndex = 51;
            this.txtUserID.Text = "???";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(306, 47);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(27, 19);
            this.txtUserName.TabIndex = 52;
            this.txtUserName.Text = "???";
            // 
            // txtIsActive
            // 
            this.txtIsActive.AutoSize = true;
            this.txtIsActive.Location = new System.Drawing.Point(552, 47);
            this.txtIsActive.Name = "txtIsActive";
            this.txtIsActive.Size = new System.Drawing.Size(27, 19);
            this.txtIsActive.TabIndex = 53;
            this.txtIsActive.Text = "???";
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbUserinfo);
            this.Controls.Add(this.personInfoCard11);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(638, 396);
            this.gbUserinfo.ResumeLayout(false);
            this.gbUserinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInfoCard1 personInfoCard11;
        private System.Windows.Forms.GroupBox gbUserinfo;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label txtIsActive;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label txtUserID;
    }
}
