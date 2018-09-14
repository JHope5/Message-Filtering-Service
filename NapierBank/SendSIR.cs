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
    public partial class SendSIR : Form
    {
        public SendSIR()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string natOfIncident = lstIncident.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Please select the nature of the incident.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string natureOfIncident = lstIncident.SelectedItem.ToString();
            string messageID = IDCreator();
            string message = txtMessage.Text;
            string emailAddress = txtEmail.Text;
            string date = dpDate.Value.ToShortDateString();
            try
            {
                int sC1 = Int32.Parse(txtSortCode1.Text.TrimStart('0'));
                int sC2 = Int32.Parse(txtSortCode2.Text.TrimStart('0'));
                int sC3 = Int32.Parse(txtSortCode3.Text.TrimStart('0'));
            }
            catch
            {
                MessageBox.Show("Invalid sort code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int sortCode1 = Int32.Parse(txtSortCode1.Text.TrimStart('0'));
            int sortCode2 = Int32.Parse(txtSortCode2.Text.TrimStart('0'));
            int sortCode3 = Int32.Parse(txtSortCode3.Text.TrimStart('0'));
            if((sortCode1.ToString().Length != 2) || (sortCode2.ToString().Length != 2) || (sortCode3.ToString().Length != 2))
            {
                MessageBox.Show("Invalid sort code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string sortCode = txtSortCode1.Text + " - " + txtSortCode2.Text + " - " + txtSortCode3.Text;
            message = Regex.Replace(message, @"\b(?:https?://|www\.)\S+\b", "<URL Quarantined>");
            bool isEmail = Regex.IsMatch(emailAddress, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if ((emailAddress == "") || (message == "") || (date == ""))
            {
                MessageBox.Show("Boxes cannot be left blank. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (message.Length > 1028)
            {
                MessageBox.Show("Message exceeds 1028 character limit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (isEmail == false)
            {
                MessageBox.Show("Invalid email address. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                List<SIR> sir = new List<SIR>();
                sir.Add(new SIR()
                {
                    messageID = IDCreator(),
                    messageBody = BodyCreator(message, emailAddress, date, natureOfIncident, sortCode)
                });
                string json = JsonConvert.SerializeObject(sir.ToArray());

                //write string to file
                File.AppendAllText("SIRs.json", json);

                MessageBox.Show("Significant Incident Report added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                Close();
            }
            
        }

        public string IDCreator()
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < 9; i++)
            {
                s = String.Concat(s, random.Next(10).ToString());
            }
            string id = "E" + s;
            return id;
        }

        private string BodyCreator(string message, string emailAddress, string date, string natureOfIncident, string sortCode)
        {
            string subject = "SIR " + date;
            string body = "Sender: " + emailAddress + " - Sort Code: " + sortCode + " - Nature of Incident: " + natureOfIncident + " - Message Text: " + message;
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
