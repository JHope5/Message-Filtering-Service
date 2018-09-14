namespace NapierBank
{
    partial class ViewSMSTexts
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
            this.lblSMSTexts = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSMSTexts
            // 
            this.lblSMSTexts.Location = new System.Drawing.Point(12, 9);
            this.lblSMSTexts.Name = "lblSMSTexts";
            this.lblSMSTexts.Size = new System.Drawing.Size(1035, 690);
            this.lblSMSTexts.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(340, 748);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(287, 64);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewSMSTexts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 843);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSMSTexts);
            this.Name = "ViewSMSTexts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSMSTexts";
            this.Load += new System.EventHandler(this.ViewSMSTexts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSMSTexts;
        private System.Windows.Forms.Button btnBack;
    }
}