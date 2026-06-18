namespace DVLD.Tests
{
    partial class frmTakeTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.rbPass = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbFail = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlsechdueldTest1 = new DVLD.Tests.Controlls.ctrlsechdueldTest();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(36, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "Notes :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "Result :";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(117, 492);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(346, 84);
            this.rtbNotes.TabIndex = 80;
            this.rtbNotes.Text = "";
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPass.CheckedState.BorderThickness = 0;
            this.rbPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbPass.CheckedState.InnerOffset = -4;
            this.rbPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbPass.Location = new System.Drawing.Point(117, 455);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(60, 23);
            this.rbPass.TabIndex = 81;
            this.rbPass.Text = "Pass";
            this.rbPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPass.UncheckedState.BorderThickness = 2;
            this.rbPass.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPass.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFail.CheckedState.BorderThickness = 0;
            this.rbFail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFail.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFail.CheckedState.InnerOffset = -4;
            this.rbFail.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.rbFail.Location = new System.Drawing.Point(194, 455);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(52, 23);
            this.rbFail.TabIndex = 82;
            this.rbFail.Text = "Fail";
            this.rbFail.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFail.UncheckedState.BorderThickness = 2;
            this.rbFail.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFail.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
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
            this.btnsave.Location = new System.Drawing.Point(409, 583);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(155, 34);
            this.btnsave.TabIndex = 84;
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
            this.btnclose.Location = new System.Drawing.Point(248, 583);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(155, 34);
            this.btnclose.TabIndex = 83;
            this.btnclose.Text = "Close";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ctrlsechdueldTest1
            // 
            this.ctrlsechdueldTest1.Location = new System.Drawing.Point(34, 12);
            this.ctrlsechdueldTest1.Name = "ctrlsechdueldTest1";
            this.ctrlsechdueldTest1.Size = new System.Drawing.Size(465, 443);
            this.ctrlsechdueldTest1.TabIndex = 85;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMessage.ForeColor = System.Drawing.Color.Red;
            this.lblUserMessage.Location = new System.Drawing.Point(252, 458);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(196, 20);
            this.lblUserMessage.TabIndex = 86;
            this.lblUserMessage.Text = "you cannot change Result";
            this.lblUserMessage.Visible = false;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 627);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.ctrlsechdueldTest1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private Guna.UI2.WinForms.Guna2RadioButton rbPass;
        private Guna.UI2.WinForms.Guna2RadioButton rbFail;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Controlls.ctrlsechdueldTest ctrlsechdueldTest1;
        private System.Windows.Forms.Label lblUserMessage;
    }
}