using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NapierBank
{
    public partial class ViewEmails : Form
    {
        public ViewEmails()
        {
            InitializeComponent();
        }

        private void ViewEmails_Load(object sender, EventArgs e)
        {
            try
            {
                string emails = File.ReadAllText("Emails.json");

                // Display the file contents to the label
                lblEmails.Text = emails;
            }
            catch
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewMessages viewMessages = new ViewMessages();
            viewMessages.Show();
            Close();
        }
    }
}
