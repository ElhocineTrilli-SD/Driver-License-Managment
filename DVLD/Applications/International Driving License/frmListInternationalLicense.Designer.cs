namespace DVLD.Applications.International_Driving_License
{
    partial class frmListInternationalLicense
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
            this.dgvInter_License = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbfilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbUsers = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInter_License)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInter_License
            // 
            this.dgvInter_License.AllowUserToAddRows = false;
            this.dgvInter_License.AllowUserToDeleteRows = false;
            this.dgvInter_License.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInter_License.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvInter_License.Location = new System.Drawing.Point(12, 190);
            this.dgvInter_License.Name = "dgvInter_License";
            this.dgvInter_License.ReadOnly = true;
            this.dgvInter_License.Size = new System.Drawing.Size(825, 291);
            this.dgvInter_License.TabIndex = 34;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(344, 106);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.showPersonInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.personinfo;
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Details";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(343, 34);
            this.toolStripMenuItem1.Text = "Show License Details";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(282, 162);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(137, 20);
            this.txtFilterValue.TabIndex = 32;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbfilter
            // 
            this.cbfilter.FormattingEnabled = true;
            this.cbfilter.Location = new System.Drawing.Point(115, 162);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(161, 21);
            this.cbfilter.TabIndex = 31;
            this.cbfilter.SelectedIndexChanged += new System.EventHandler(this.cbfilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Filter By: ";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.BackgroundImage = global::DVLD.Properties.Resources.addpeople;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(722, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 66);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(202, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "International License Applications";
            // 
            // pbUsers
            // 
            this.pbUsers.Image = global::DVLD.Properties.Resources.open_enrollment__1_;
            this.pbUsers.ImageRotate = 0F;
            this.pbUsers.Location = new System.Drawing.Point(12, 12);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUsers.Size = new System.Drawing.Size(184, 113);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsers.TabIndex = 28;
            this.pbUsers.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::DVLD.Properties.Resources.earth;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(115, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(68, 31);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 35;
            this.guna2PictureBox1.TabStop = false;
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
            this.btnclose.Location = new System.Drawing.Point(638, 487);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(155, 53);
            this.btnclose.TabIndex = 38;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(101, 487);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(17, 19);
            this.lblRecordsCount.TabIndex = 37;
            this.lblRecordsCount.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "#Records: ";
            // 
            // cbIsActive
            // 
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(282, 162);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 21);
            this.cbIsActive.TabIndex = 39;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // frmListInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 545);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dgvInter_License);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbfilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbUsers);
            this.Name = "frmListInternationalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International License";
            this.Load += new System.EventHandler(this.frmListInternationalLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInter_License)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInter_License;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbfilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUsers;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}