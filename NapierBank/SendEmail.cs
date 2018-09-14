using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NapierBank
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            string subject = txtSubject.Text;
            string emailAddress = txtEmail.Text;
            message = Regex.Replace(message, @"\b(?:https?://|www\.)\S+\b", "<URL Quarantined>");
            bool isEmail = Regex.IsMatch(emailAddress, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if((emailAddress == "") || (subject == "") || (message == ""))
            {
                MessageBox.Show("Boxes cannot be left blank. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(subject.Length > 20)
            {
                MessageBox.Show("Subject exceeds 20 character limit. Please try again.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if(message.Length > 1028)
            {
                MessageBox.Show("Message exceeds 1028 character limit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (isEmail == false)
            {
                MessageBox.Show("Invalid email address. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            
                List<Email> email = new List<Email>();
                email.Add(new Email()
                {
                    messageID = IDCreator(),
                    messageBody = BodyCreator(message, emailAddress, subject)
                });
                string json = JsonConvert.SerializeObject(email.ToArray());

                //write string to file
                File.AppendAllText("Emails.json", json);

                MessageBox.Show("Email Message added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                Close();
            }
            
        }

        private string IDCreator()
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < 9; i++)
            {
                s = String.Concat(s, random.Next(10).ToString());
            }
            string fName = "E" + s;
            return fName;
        }

        private string BodyCreator(string message, string emailAddress, string subject)
        {
            string body = "Sender: " + emailAddress + " - Subject: " + subject + " - Message Text: " + message;
            return body;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
