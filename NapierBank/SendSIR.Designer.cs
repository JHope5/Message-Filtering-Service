namespace NapierBank
{
    partial class SendSIR
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstIncident = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSortCode1 = new System.Windows.Forms.TextBox();
            this.txtSortCode3 = new System.Windows.Forms.TextBox();
            this.txtSortCode2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(323, 157);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 38);
            this.txtEmail.TabIndex = 0;
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(309, 312);
            this.dpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(399, 38);
            this.dpDate.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(61, 909);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(296, 98);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstIncident
            // 
            this.lstIncident.FormattingEnabled = true;
            this.lstIncident.ItemHeight = 31;
            this.lstIncident.Items.AddRange(new object[] {
            "Theft",
            "Staff Attack",
            "ATM Theft",
            "Raid",
            "Customer Attack",
            "Staff Abuse",
            "Bomb Threat",
            "Terrorism",
            "Suspicious Incident",
            "Intelligence",
            "Cash Loss"});
            this.lstIncident.Location = new System.Drawing.Point(309, 382);
            this.lstIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstIncident.Name = "lstIncident";
            this.lstIncident.Size = new System.Drawing.Size(399, 221);
            this.lstIncident.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(309, 630);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(399, 242);
            this.txtMessage.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Your Email Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date of Incident:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nature of Incident:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(842, 71);
            this.label4.TabIndex = 11;
            this.label4.Text = "Send Significant Incident Report";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(424, 909);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(296, 98);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Message Body:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sort Code:";
            // 
            // txtSortCode1
            // 
            this.txtSortCode1.Location = new System.Drawing.Point(323, 238);
            this.txtSortCode1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSortCode1.Name = "txtSortCode1";
            this.txtSortCode1.Size = new System.Drawing.Size(81, 38);
            this.txtSortCode1.TabIndex = 15;
            // 
            // txtSortCode3
            // 
            this.txtSortCode3.Location = new System.Drawing.Point(584, 238);
            this.txtSortCode3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSortCode3.Name = "txtSortCode3";
            this.txtSortCode3.Size = new System.Drawing.Size(81, 38);
            this.txtSortCode3.TabIndex = 16;
            // 
            // txtSortCode2
            // 
            this.txtSortCode2.Location = new System.Drawing.Point(453, 238);
            this.txtSortCode2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSortCode2.Name = "txtSortCode2";
            this.txtSortCode2.Size = new System.Drawing.Size(81, 38);
            this.txtSortCode2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "-";
            // 
            // SendSIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(869, 1040);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSortCode2);
            this.Controls.Add(this.txtSortCode3);
            this.Controls.Add(this.txtSortCode1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lstIncident);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.txtEmail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SendSIR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendSIR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstIncident;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSortCode1;
        private System.Windows.Forms.TextBox txtSortCode3;
        private System.Windows.Forms.TextBox txtSortCode2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}