namespace DVLD.Applications.Release
{
    partial class frmManageDetainedLicneses
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
            this.cbisRelease = new System.Windows.Forms.ComboBox();
            this.dgvDetainedLicense = new System.Windows.Forms.DataGridView();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbfilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.lblRecordsCountUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releasedDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicense)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbisRelease
            // 
            this.cbisRelease.FormattingEnabled = true;
            this.cbisRelease.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbisRelease.Location = new System.Drawing.Point(278, 159);
            this.cbisRelease.Name = "cbisRelease";
            this.cbisRelease.Size = new System.Drawing.Size(121, 21);
            this.cbisRelease.TabIndex = 25;
            this.cbisRelease.SelectedIndexChanged += new System.EventHandler(this.cbisRelease_SelectedIndexChanged);
            // 
            // dgvDetainedLicense
            // 
            this.dgvDetainedLicense.AllowUserToAddRows = false;
            this.dgvDetainedLicense.AllowUserToDeleteRows = false;
            this.dgvDetainedLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicense.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDetainedLicense.Location = new System.Drawing.Point(5, 186);
            this.dgvDetainedLicense.Name = "dgvDetainedLicense";
            this.dgvDetainedLicense.ReadOnly = true;
            this.dgvDetainedLicense.Size = new System.Drawing.Size(783, 291);
            this.dgvDetainedLicense.TabIndex = 24;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(278, 160);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(137, 20);
            this.txtFilterValue.TabIndex = 22;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbfilter
            // 
            this.cbfilter.FormattingEnabled = true;
            this.cbfilter.Location = new System.Drawing.Point(102, 159);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(161, 21);
            this.cbfilter.TabIndex = 21;
            this.cbfilter.SelectedIndexChanged += new System.EventHandler(this.cbfilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Filter By: ";
            // 
            // btnDetain
            // 
            this.btnDetain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDetain.BackgroundImage = global::DVLD.Properties.Resources.addpeople;
            this.btnDetain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetain.Location = new System.Drawing.Point(705, 114);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(71, 66);
            this.btnDetain.TabIndex = 26;
            this.btnDetain.UseVisualStyleBackColor = true;
            // 
            // btnRelease
            // 
            this.btnRelease.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRelease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelease.Location = new System.Drawing.Point(621, 114);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(71, 66);
            this.btnRelease.TabIndex = 27;
            this.btnRelease.UseVisualStyleBackColor = true;
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
            this.btnclose.Location = new System.Drawing.Point(621, 480);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(155, 53);
            this.btnclose.TabIndex = 30;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblRecordsCountUser
            // 
            this.lblRecordsCountUser.AutoSize = true;
            this.lblRecordsCountUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountUser.Location = new System.Drawing.Point(121, 480);
            this.lblRecordsCountUser.Name = "lblRecordsCountUser";
            this.lblRecordsCountUser.Size = new System.Drawing.Size(17, 19);
            this.lblRecordsCountUser.TabIndex = 29;
            this.lblRecordsCountUser.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "#Records: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.releasedDetainedLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 114);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // releasedDetainedLicenseToolStripMenuItem
            // 
            this.releasedDetainedLicenseToolStripMenuItem.Name = "releasedDetainedLicenseToolStripMenuItem";
            this.releasedDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.releasedDetainedLicenseToolStripMenuItem.Text = "Released Detained License ";
            this.releasedDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releasedDetainedLicenseToolStripMenuItem_Click);
            // 
            // frmManageDetainedLicneses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblRecordsCountUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.cbisRelease);
            this.Controls.Add(this.dgvDetainedLicense);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbfilter);
            this.Controls.Add(this.label2);
            this.Name = "frmManageDetainedLicneses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detained Licneses";
            this.Load += new System.EventHandler(this.frmManageDetainedLicneses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicense)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbisRelease;
        private System.Windows.Forms.DataGridView dgvDetainedLicense;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbfilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Button btnRelease;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label lblRecordsCountUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releasedDetainedLicenseToolStripMenuItem;
    }
}