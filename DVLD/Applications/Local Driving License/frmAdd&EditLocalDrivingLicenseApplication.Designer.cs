namespace DVLD.Applications.Local_Driving_License
{
    partial class frmAdd_EditLocalDrivingLicenseApplication
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
            this.tbAInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.personInfoWithFilter11 = new DVLD.People.Controlls.PersonInfoWithFilter1();
            this.tApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtAFees = new System.Windows.Forms.Label();
            this.txtAUser = new System.Windows.Forms.Label();
            this.txtADate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApplicationID = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.tbAInfo.SuspendLayout();
            this.tbPersonalInfo.SuspendLayout();
            this.tApplicationInfo.SuspendLayout();
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
            this.btnsave.Location = new System.Drawing.Point(799, 537);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(155, 53);
            this.btnsave.TabIndex = 24;
            this.btnsave.Text = "Save";
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
            this.btnclose.Location = new System.Drawing.Point(628, 537);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(155, 53);
            this.btnclose.TabIndex = 23;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // tbAInfo
            // 
            this.tbAInfo.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbAInfo.Controls.Add(this.tbPersonalInfo);
            this.tbAInfo.Controls.Add(this.tApplicationInfo);
            this.tbAInfo.ItemSize = new System.Drawing.Size(180, 40);
            this.tbAInfo.Location = new System.Drawing.Point(12, 94);
            this.tbAInfo.Name = "tbAInfo";
            this.tbAInfo.SelectedIndex = 0;
            this.tbAInfo.Size = new System.Drawing.Size(886, 437);
            this.tbAInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbAInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbAInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbAInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbAInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbAInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbAInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbAInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbAInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tbAInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbAInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbAInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tbAInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbAInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbAInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbAInfo.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbAInfo.TabIndex = 22;
            this.tbAInfo.TabMenuBackColor = System.Drawing.Color.MidnightBlue;
            // 
            // tbPersonalInfo
            // 
            this.tbPersonalInfo.Controls.Add(this.btnNext);
            this.tbPersonalInfo.Controls.Add(this.personInfoWithFilter11);
            this.tbPersonalInfo.Location = new System.Drawing.Point(184, 4);
            this.tbPersonalInfo.Name = "tbPersonalInfo";
            this.tbPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonalInfo.Size = new System.Drawing.Size(698, 429);
            this.tbPersonalInfo.TabIndex = 0;
            this.tbPersonalInfo.Text = "PersonalInfo";
            this.tbPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 10;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(522, 382);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(155, 41);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // personInfoWithFilter11
            // 
            this.personInfoWithFilter11.FilterEnabled = true;
            this.personInfoWithFilter11.Location = new System.Drawing.Point(3, 3);
            this.personInfoWithFilter11.Name = "personInfoWithFilter11";
            this.personInfoWithFilter11.ShowAddPerson = true;
            this.personInfoWithFilter11.Size = new System.Drawing.Size(695, 370);
            this.personInfoWithFilter11.TabIndex = 0;
            this.personInfoWithFilter11.OnPersonSelected += new System.Action<int>(this.personInfoWithFilter11_OnPersonSelected);
            // 
            // tApplicationInfo
            // 
            this.tApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tApplicationInfo.Controls.Add(this.txtAFees);
            this.tApplicationInfo.Controls.Add(this.txtAUser);
            this.tApplicationInfo.Controls.Add(this.txtADate);
            this.tApplicationInfo.Controls.Add(this.label4);
            this.tApplicationInfo.Controls.Add(this.label3);
            this.tApplicationInfo.Controls.Add(this.label2);
            this.tApplicationInfo.Controls.Add(this.label1);
            this.tApplicationInfo.Controls.Add(this.txtApplicationID);
            this.tApplicationInfo.Controls.Add(this.lblUserID);
            this.tApplicationInfo.Location = new System.Drawing.Point(184, 4);
            this.tApplicationInfo.Name = "tApplicationInfo";
            this.tApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tApplicationInfo.Size = new System.Drawing.Size(698, 429);
            this.tApplicationInfo.TabIndex = 1;
            this.tApplicationInfo.Text = "Application Info";
            this.tApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.cbLicenseClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLicenseClass.ItemHeight = 30;
            this.cbLicenseClass.Location = new System.Drawing.Point(192, 146);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(228, 36);
            this.cbLicenseClass.TabIndex = 62;
            // 
            // txtAFees
            // 
            this.txtAFees.AutoSize = true;
            this.txtAFees.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtAFees.ForeColor = System.Drawing.Color.Black;
            this.txtAFees.Location = new System.Drawing.Point(188, 204);
            this.txtAFees.Name = "txtAFees";
            this.txtAFees.Size = new System.Drawing.Size(23, 19);
            this.txtAFees.TabIndex = 61;
            this.txtAFees.Text = "??";
            // 
            // txtAUser
            // 
            this.txtAUser.AutoSize = true;
            this.txtAUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtAUser.ForeColor = System.Drawing.Color.Black;
            this.txtAUser.Location = new System.Drawing.Point(188, 237);
            this.txtAUser.Name = "txtAUser";
            this.txtAUser.Size = new System.Drawing.Size(23, 19);
            this.txtAUser.TabIndex = 60;
            this.txtAUser.Text = "??";
            // 
            // txtADate
            // 
            this.txtADate.AutoSize = true;
            this.txtADate.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtADate.ForeColor = System.Drawing.Color.Black;
            this.txtADate.Location = new System.Drawing.Point(185, 109);
            this.txtADate.Name = "txtADate";
            this.txtADate.Size = new System.Drawing.Size(23, 19);
            this.txtADate.TabIndex = 59;
            this.txtADate.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(69, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 58;
            this.label4.Text = "Created By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Application Fees :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(55, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "License Class :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Application Date :";
            // 
            // txtApplicationID
            // 
            this.txtApplicationID.AutoSize = true;
            this.txtApplicationID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtApplicationID.ForeColor = System.Drawing.Color.Red;
            this.txtApplicationID.Location = new System.Drawing.Point(185, 72);
            this.txtApplicationID.Name = "txtApplicationID";
            this.txtApplicationID.Size = new System.Drawing.Size(23, 19);
            this.txtApplicationID.TabIndex = 50;
            this.txtApplicationID.Text = "??";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Location = new System.Drawing.Point(16, 72);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(152, 19);
            this.lblUserID.TabIndex = 47;
            this.lblUserID.Text = "D.L.Application ID :";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(253, 25);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(0, 36);
            this.lblTitel.TabIndex = 26;
            // 
            // frmAdd_EditLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 602);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.tbAInfo);
            this.Name = "frmAdd_EditLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Local Driving License Application";
            this.Activated += new System.EventHandler(this.frmAdd_EditLocalDrivingLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmAdd_EditLocalDrivingLicenseApplication_Load);
            this.tbAInfo.ResumeLayout(false);
            this.tbPersonalInfo.ResumeLayout(false);
            this.tApplicationInfo.ResumeLayout(false);
            this.tApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnsave;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2TabControl tbAInfo;
        private System.Windows.Forms.TabPage tbPersonalInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private People.Controlls.PersonInfoWithFilter1 personInfoWithFilter11;
        private System.Windows.Forms.TabPage tApplicationInfo;
        private System.Windows.Forms.Label txtApplicationID;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtAFees;
        private System.Windows.Forms.Label txtAUser;
        private System.Windows.Forms.Label txtADate;
        private System.Windows.Forms.Label lblTitel;
        private Guna.UI2.WinForms.Guna2ComboBox cbLicenseClass;
    }
}