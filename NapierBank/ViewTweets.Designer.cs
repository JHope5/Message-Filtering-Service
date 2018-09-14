namespace NapierBank
{
    partial class ViewTweets
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
            this.lblTweets = new System.Windows.Forms.Label();
            this.btnViewTrending = new System.Windows.Forms.Button();
            this.btnViewMentions = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTweets
            // 
            this.lblTweets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTweets.Location = new System.Drawing.Point(12, 9);
            this.lblTweets.Name = "lblTweets";
            this.lblTweets.Size = new System.Drawing.Size(1047, 548);
            this.lblTweets.TabIndex = 0;
            // 
            // btnViewTrending
            // 
            this.btnViewTrending.Location = new System.Drawing.Point(60, 579);
            this.btnViewTrending.Name = "btnViewTrending";
            this.btnViewTrending.Size = new System.Drawing.Size(206, 89);
            this.btnViewTrending.TabIndex = 1;
            this.btnViewTrending.Text = "View Trending";
            this.btnViewTrending.UseVisualStyleBackColor = true;
            this.btnViewTrending.Click += new System.EventHandler(this.btnViewTrending_Click);
            // 
            // btnViewMentions
            // 
            this.btnViewMentions.Location = new System.Drawing.Point(374, 579);
            this.btnViewMentions.Name = "btnViewMentions";
            this.btnViewMentions.Size = new System.Drawing.Size(206, 89);
            this.btnViewMentions.TabIndex = 2;
            this.btnViewMentions.Text = "View Mentions";
            this.btnViewMentions.UseVisualStyleBackColor = true;
            this.btnViewMentions.Click += new System.EventHandler(this.btnViewMentions_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(694, 579);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(206, 89);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewTweets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 692);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewMentions);
            this.Controls.Add(this.btnViewTrending);
            this.Controls.Add(this.lblTweets);
            this.Name = "ViewTweets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTweet";
            this.Load += new System.EventHandler(this.ViewTweets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTweets;
        private System.Windows.Forms.Button btnViewTrending;
        private System.Windows.Forms.Button btnViewMentions;
        private System.Windows.Forms.Button btnBack;
    }
}