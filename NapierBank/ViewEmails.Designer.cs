namespace NapierBank
{
    partial class ViewEmails
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
            this.lblEmails = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmails
            // 
            this.lblEmails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmails.Location = new System.Drawing.Point(12, 9);
            this.lblEmails.Name = "lblEmails";
            this.lblEmails.Size = new System.Drawing.Size(1035, 690);
            this.lblEmails.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(354, 725);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(333, 97);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 862);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEmails);
            this.Name = "ViewEmails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmails";
            this.Load += new System.EventHandler(this.ViewEmails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmails;
        private System.Windows.Forms.Button btnBack;
    }
}