namespace DVLD.Users
{
    partial class frmManageUsers
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilterValueUser = new System.Windows.Forms.TextBox();
            this.cbfilterUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCountUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.pbUsers = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(310, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Manage Users";
            // 
            // txtFilterValueUser
            // 
            this.txtFilterValueUser.Location = new System.Drawing.Point(277, 172);
            this.txtFilterValueUser.Name = "txtFilterValueUser";
            this.txtFilterValueUser.Size = new System.Drawing.Size(137, 20);
            this.txtFilterValueUser.TabIndex = 14;
            this.txtFilterValueUser.Visible = false;
            this.txtFilterValueUser.TextChanged += new System.EventHandler(this.txtFilterValueUser_TextChanged);
            this.txtFilterValueUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValueUser_KeyPress);
            // 
            // cbfilterUsers
            // 
            this.cbfilterUsers.FormattingEnabled = true;
            this.cbfilterUsers.Location = new System.Drawing.Point(110, 172);
            this.cbfilterUsers.Name = "cbfilterUsers";
            this.cbfilterUsers.Size = new System.Drawing.Size(161, 21);
            this.cbfilterUsers.TabIndex = 13;
            this.cbfilterUsers.SelectedIndexChanged += new System.EventHandler(this.cbfilterUsers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter By: ";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvUser.Location = new System.Drawing.Point(27, 200);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.Size = new System.Drawing.Size(761, 291);
            this.dgvUser.TabIndex = 16;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.deleteToolStripMenuItem2,
            this.phoneCallToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(186, 184);
            // 
            // showDetailsToolStripMenuItem1
            // 
            this.showDetailsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.showDetailsToolStripMenuItem1.Image = global::DVLD.Properties.Resources.open_enrollment__1_;
            this.showDetailsToolStripMenuItem1.Name = "showDetailsToolStripMenuItem1";
            this.showDetailsToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.showDetailsToolStripMenuItem1.Text = "Show Details";
            this.showDetailsToolStripMenuItem1.Click += new System.EventHandler(this.showDetailsToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 6);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editToolStripMenuItem1.Image = global::DVLD.Properties.Resources.addpeople;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.editToolStripMenuItem1.Text = "Add New User";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.deleteToolStripMenuItem1.Text = "Edit";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(185, 24);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.phoneCallToolStripMenuItem.Text = "Change Password";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem1
            // 
            this.phoneCallToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.phoneCallToolStripMenuItem1.Name = "phoneCallToolStripMenuItem1";
            this.phoneCallToolStripMenuItem1.Size = new System.Drawing.Size(185, 24);
            this.phoneCallToolStripMenuItem1.Text = "Phone call";
            this.phoneCallToolStripMenuItem1.Click += new System.EventHandler(this.phoneCallToolStripMenuItem1_Click);
            // 
            // lblRecordsCountUser
            // 
            this.lblRecordsCountUser.AutoSize = true;
            this.lblRecordsCountUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountUser.Location = new System.Drawing.Point(111, 509);
            this.lblRecordsCountUser.Name = "lblRecordsCountUser";
            this.lblRecordsCountUser.Size = new System.Drawing.Size(17, 19);
            this.lblRecordsCountUser.TabIndex = 18;
            this.lblRecordsCountUser.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "#Records: ";
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
            this.btnclose.Location = new System.Drawing.Point(633, 509);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(155, 53);
            this.btnclose.TabIndex = 19;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(277, 171);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 21);
            this.cbIsActive.TabIndex = 20;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.BackgroundImage = global::DVLD.Properties.Resources.addpeople;
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.Location = new System.Drawing.Point(717, 128);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(71, 66);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // pbUsers
            // 
            this.pbUsers.Image = global::DVLD.Properties.Resources.Manage_People;
            this.pbUsers.ImageRotate = 0F;
            this.pbUsers.Location = new System.Drawing.Point(316, 12);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUsers.Size = new System.Drawing.Size(184, 113);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsers.TabIndex = 9;
            this.pbUsers.TabStop = false;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 576);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblRecordsCountUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.txtFilterValueUser);
            this.Controls.Add(this.cbfilterUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbUsers);
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtFilterValueUser;
        private System.Windows.Forms.ComboBox cbfilterUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblRecordsCountUser;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbIsActive;
    }
}