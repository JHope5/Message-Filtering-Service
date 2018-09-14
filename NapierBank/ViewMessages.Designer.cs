namespace NapierBank
{
    partial class ViewMessages
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
            this.btnViewTweets = new System.Windows.Forms.Button();
            this.btnViewSMSTexts = new System.Windows.Forms.Button();
            this.btnViewEmails = new System.Windows.Forms.Button();
            this.btnViewSIRs = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewTweets
            // 
            this.btnViewTweets.Location = new System.Drawing.Point(89, 207);
            this.btnViewTweets.Name = "btnViewTweets";
            this.btnViewTweets.Size = new System.Drawing.Size(256, 109);
            this.btnViewTweets.TabIndex = 0;
            this.btnViewTweets.Text = "View Tweets";
            this.btnViewTweets.UseVisualStyleBackColor = true;
            this.btnViewTweets.Click += new System.EventHandler(this.btnViewTweets_Click);
            // 
            // btnViewSMSTexts
            // 
            this.btnViewSMSTexts.Location = new System.Drawing.Point(504, 197);
            this.btnViewSMSTexts.Name = "btnViewSMSTexts";
            this.btnViewSMSTexts.Size = new System.Drawing.Size(256, 119);
            this.btnViewSMSTexts.TabIndex = 1;
            this.btnViewSMSTexts.Text = "View SMS Text Messages";
            this.btnViewSMSTexts.UseVisualStyleBackColor = true;
            this.btnViewSMSTexts.Click += new System.EventHandler(this.btnViewSMSTexts_Click);
            // 
            // btnViewEmails
            // 
            this.btnViewEmails.Location = new System.Drawing.Point(89, 412);
            this.btnViewEmails.Name = "btnViewEmails";
            this.btnViewEmails.Size = new System.Drawing.Size(256, 119);
            this.btnViewEmails.TabIndex = 2;
            this.btnViewEmails.Text = "View Email Messages";
            this.btnViewEmails.UseVisualStyleBackColor = true;
            this.btnViewEmails.Click += new System.EventHandler(this.btnViewEmails_Click);
            // 
            // btnViewSIRs
            // 
            this.btnViewSIRs.Location = new System.Drawing.Point(504, 412);
            this.btnViewSIRs.Name = "btnViewSIRs";
            this.btnViewSIRs.Size = new System.Drawing.Size(256, 119);
            this.btnViewSIRs.TabIndex = 3;
            this.btnViewSIRs.Text = "View Significant Incident Reports";
            this.btnViewSIRs.UseVisualStyleBackColor = true;
            this.btnViewSIRs.Click += new System.EventHandler(this.btnViewSIRs_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(283, 565);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(256, 119);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select an option below";
            // 
            // ViewMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewSIRs);
            this.Controls.Add(this.btnViewEmails);
            this.Controls.Add(this.btnViewSMSTexts);
            this.Controls.Add(this.btnViewTweets);
            this.Name = "ViewMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Messages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewTweets;
        private System.Windows.Forms.Button btnViewSMSTexts;
        private System.Windows.Forms.Button btnViewEmails;
        private System.Windows.Forms.Button btnViewSIRs;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}