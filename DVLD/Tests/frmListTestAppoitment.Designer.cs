namespace DVLD.Tests
{
    partial class frmListTestAppoitment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListTestAppoitment));
            this.lblTitle = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.dgvLicenseTestAppointments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAppoitment = new System.Windows.Forms.Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.lblRecordsCountAppoitment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlDrivingLicenseApplication1 = new DVLD.Applications.Local_Driving_License.ctrlDrivingLicenseApplication();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseTestAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(303, 117);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 36);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Sechduel Test";
            // 
            // picture
            // 
            this.picture.Image = global::DVLD.Properties.Resources.examination;
            this.picture.InitialImage = ((System.Drawing.Image)(resources.GetObject("picture.InitialImage")));
            this.picture.Location = new System.Drawing.Point(319, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(186, 102);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 74;
            this.picture.TabStop = false;
            // 
            // dgvLicenseTestAppointments
            // 
            this.dgvLicenseTestAppointments.AllowUserToAddRows = false;
            this.dgvLicenseTestAppointments.AllowUserToDeleteRows = false;
            this.dgvLicenseTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicenseTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLicenseTestAppointments.Location = new System.Drawing.Point(37, 571);
            this.dgvLicenseTestAppointments.Name = "dgvLicenseTestAppointments";
            this.dgvLicenseTestAppointments.ReadOnly = true;
            this.dgvLicenseTestAppointments.Size = new System.Drawing.Size(761, 116);
            this.dgvLicenseTestAppointments.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 79;
            this.label2.Text = "Appoitments: ";
            // 
            // btnAddAppoitment
            // 
            this.btnAddAppoitment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddAppoitment.BackgroundImage = global::DVLD.Properties.Resources.addpeople;
            this.btnAddAppoitment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAppoitment.Location = new System.Drawing.Point(719, 534);
            this.btnAddAppoitment.Name = "btnAddAppoitment";
            this.btnAddAppoitment.Size = new System.Drawing.Size(53, 31);
            this.btnAddAppoitment.TabIndex = 76;
            this.btnAddAppoitment.UseVisualStyleBackColor = true;
            this.btnAddAppoitment.Click += new System.EventHandler(this.btnAddAppoitment_Click);
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
            this.btnclose.Location = new System.Drawing.Point(643, 693);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(155, 53);
            this.btnclose.TabIndex = 83;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblRecordsCountAppoitment
            // 
            this.lblRecordsCountAppoitment.AutoSize = true;
            this.lblRecordsCountAppoitment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountAppoitment.Location = new System.Drawing.Point(121, 693);
            this.lblRecordsCountAppoitment.Name = "lblRecordsCountAppoitment";
            this.lblRecordsCountAppoitment.Size = new System.Drawing.Size(17, 19);
            this.lblRecordsCountAppoitment.TabIndex = 82;
            this.lblRecordsCountAppoitment.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 693);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 81;
            this.label1.Text = "#Records: ";
            // 
            // ctrlDrivingLicenseApplication1
            // 
            this.ctrlDrivingLicenseApplication1.Location = new System.Drawing.Point(37, 156);
            this.ctrlDrivingLicenseApplication1.Name = "ctrlDrivingLicenseApplication1";
            this.ctrlDrivingLicenseApplication1.Size = new System.Drawing.Size(735, 372);
            this.ctrlDrivingLicenseApplication1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeTestToolStripMenuItem.Text = "Take test";
            // 
            // frmListTestAppoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 749);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblRecordsCountAppoitment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLicenseTestAppointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddAppoitment);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.ctrlDrivingLicenseApplication1);
            this.Name = "frmListTestAppoitment";
            this.Text = "frmListTestAppoitment";
            this.Load += new System.EventHandler(this.frmListTestAppoitment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseTestAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Local_Driving_License.ctrlDrivingLicenseApplication ctrlDrivingLicenseApplication1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.DataGridView dgvLicenseTestAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAppoitment;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label lblRecordsCountAppoitment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}