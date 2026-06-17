namespace DVLD.Tests
{
    partial class frmSechduelTest
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
            this.ctrlSechduelTest1 = new DVLD.Tests.Controlls.ctrlSechduelTest();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BorderRadius = 10;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(172, 585);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(163, 39);
            this.btnclose.TabIndex = 78;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ctrlSechduelTest1
            // 
            this.ctrlSechduelTest1.Location = new System.Drawing.Point(32, 2);
            this.ctrlSechduelTest1.Name = "ctrlSechduelTest1";
            this.ctrlSechduelTest1.Size = new System.Drawing.Size(467, 567);
            this.ctrlSechduelTest1.TabIndex = 79;
            this.ctrlSechduelTest1.TestTypeID = DVLD_BUSINESS.clsTestType.enTestType.VisionTest;
            // 
            // frmSechduelTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 636);
            this.Controls.Add(this.ctrlSechduelTest1);
            this.Controls.Add(this.btnclose);
            this.Name = "frmSechduelTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sechduel Test";
            this.Load += new System.EventHandler(this.frmSechduelTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Controlls.ctrlSechduelTest ctrlSechduelTest1;
    }
}