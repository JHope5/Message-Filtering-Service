namespace NapierBank
{
    partial class ViewSIRs
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
            this.lblSIRs = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSIRs
            // 
            this.lblSIRs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSIRs.Location = new System.Drawing.Point(12, 9);
            this.lblSIRs.Name = "lblSIRs";
            this.lblSIRs.Size = new System.Drawing.Size(1035, 690);
            this.lblSIRs.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(410, 702);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(190, 129);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewSIRs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 862);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSIRs);
            this.Name = "ViewSIRs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSIRs";
            this.Load += new System.EventHandler(this.ViewSIRs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSIRs;
        private System.Windows.Forms.Button btnBack;
    }
}