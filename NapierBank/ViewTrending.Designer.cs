namespace NapierBank
{
    partial class ViewTrending
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
            this.lblHashtags = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHashtags
            // 
            this.lblHashtags.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHashtags.Location = new System.Drawing.Point(12, 9);
            this.lblHashtags.Name = "lblHashtags";
            this.lblHashtags.Size = new System.Drawing.Size(1047, 548);
            this.lblHashtags.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(385, 586);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(245, 106);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewTrending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 726);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHashtags);
            this.Name = "ViewTrending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTrending";
            this.Load += new System.EventHandler(this.ViewTrending_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHashtags;
        private System.Windows.Forms.Button btnBack;
    }
}