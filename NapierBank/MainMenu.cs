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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSendTweet_Click(object sender, EventArgs e)
        {
            SendTweet sendTweet = new SendTweet();
            sendTweet.Show();
            Hide();
        }

        private void btnViewMessages_Click(object sender, EventArgs e)
        {
            ViewMessages viewMessages = new ViewMessages();
            viewMessages.Show();
            Hide();
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            SendSMS sendSMS = new SendSMS();
            sendSMS.Show();
            Hide();
        }

        private void btnSendSIR_Click(object sender, EventArgs e)
        {
            SendSIR sendSIR = new SendSIR();
            sendSIR.Show();
            Hide();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            SendEmail sendEmail = new SendEmail();
            sendEmail.Show();
            Hide();
        }
    }
}
