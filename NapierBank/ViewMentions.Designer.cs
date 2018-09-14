namespace NapierBank
{
    partial class ViewMentions
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
            this.lblMentions = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMentions
            // 
            this.lblMentions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMentions.Location = new System.Drawing.Point(12, 9);
            this.lblMentions.Name = "lblMentions";
            this.lblMentions.Size = new System.Drawing.Size(1047, 548);
            this.lblMentions.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(379, 575);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(243, 109);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewMentions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 729);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMentions);
            this.Name = "ViewMentions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMentions";
            this.Load += new System.EventHandler(this.ViewMentions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMentions;
        private System.Windows.Forms.Button btnBack;
    }
}