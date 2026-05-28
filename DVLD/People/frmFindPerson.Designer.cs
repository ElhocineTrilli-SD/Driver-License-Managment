namespace DVLD.People
{
    partial class frmFindPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.personInfoWithFilter11 = new DVLD.People.Controlls.PersonInfoWithFilter1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(255, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Person";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(487, 449);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(148, 34);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // personInfoWithFilter11
            // 
            this.personInfoWithFilter11.FilterEnabled = true;
            this.personInfoWithFilter11.Location = new System.Drawing.Point(12, 66);
            this.personInfoWithFilter11.Name = "personInfoWithFilter11";
            this.personInfoWithFilter11.ShowAddPerson = true;
            this.personInfoWithFilter11.Size = new System.Drawing.Size(637, 377);
            this.personInfoWithFilter11.TabIndex = 3;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 505);
            this.Controls.Add(this.personInfoWithFilter11);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Name = "frmFindPerson";
            this.Text = "frmFindPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonInfoCard1 PersonInfoCard1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Controlls.PersonInfoWithFilter1 personInfoWithFilter11;
    }
}