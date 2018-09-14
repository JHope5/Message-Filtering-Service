using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NapierBank
{
    public partial class ViewMessages : Form
    {
        public ViewMessages()
        {
            InitializeComponent();
        }

        private void btnViewTweets_Click(object sender, EventArgs e)
        {
            ViewTweets viewTweets = new ViewTweets();
            viewTweets.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void btnViewSMSTexts_Click(object sender, EventArgs e)
        {
            ViewSMSTexts viewSMS = new ViewSMSTexts();
            viewSMS.Show();
            Close();
        }

        private void btnViewEmails_Click(object sender, EventArgs e)
        {
            ViewEmails viewEmails = new ViewEmails();
            viewEmails.Show();
            Close();
        }

        private void btnViewSIRs_Click(object sender, EventArgs e)
        {
            ViewSIRs viewSIRs = new ViewSIRs();
            viewSIRs.Show();
            Close();
        }
    }
}
