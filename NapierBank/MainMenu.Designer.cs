namespace NapierBank
{
    partial class MainMenu
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
            this.btnSendTweet = new System.Windows.Forms.Button();
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnSendSIR = new System.Windows.Forms.Button();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendTweet
            // 
            this.btnSendTweet.Location = new System.Drawing.Point(135, 244);
            this.btnSendTweet.Name = "btnSendTweet";
            this.btnSendTweet.Size = new System.Drawing.Size(282, 94);
            this.btnSendTweet.TabIndex = 0;
            this.btnSendTweet.Text = "Send Tweet";
            this.btnSendTweet.UseVisualStyleBackColor = true;
            this.btnSendTweet.Click += new System.EventHandler(this.btnSendTweet_Click);
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(505, 244);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(282, 94);
            this.btnSendSMS.TabIndex = 1;
            this.btnSendSMS.Text = "Send SMS";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(135, 384);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(282, 94);
            this.btnSendEmail.TabIndex = 2;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnSendSIR
            // 
            this.btnSendSIR.Location = new System.Drawing.Point(505, 384);
            this.btnSendSIR.Name = "btnSendSIR";
            this.btnSendSIR.Size = new System.Drawing.Size(282, 94);
            this.btnSendSIR.TabIndex = 3;
            this.btnSendSIR.Text = "Send Significant Incident Report";
            this.btnSendSIR.UseVisualStyleBackColor = true;
            this.btnSendSIR.Click += new System.EventHandler(this.btnSendSIR_Click);
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.Location = new System.Drawing.Point(135, 543);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(282, 94);
            this.btnViewMessages.TabIndex = 4;
            this.btnViewMessages.Text = "View Messages";
            this.btnViewMessages.UseVisualStyleBackColor = true;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(505, 543);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(282, 94);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(968, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "Napier Bank Message Filtering Service";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 55);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select one of the options below";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 746);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnSendSIR);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnSendSMS);
            this.Controls.Add(this.btnSendTweet);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendTweet;
        private System.Windows.Forms.Button btnSendSMS;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnSendSIR;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

