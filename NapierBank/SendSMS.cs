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
    public partial class SendSMS : Form
    {
        public SendSMS()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            string messageID = functions.IDCreator("S");
            string number = txtNumber.Text;
            string message = txtMessage.Text;
            string body = functions.BodyCreator(number, null, message, "S");
            string onlyNumbers = new String(number.ToCharArray().Where(c => Char.IsDigit(c)).ToArray());

            // Validation
            if (message == "" || number == "")
            {
                MessageBox.Show("Boxes cannot be left blank. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (message.Length > 140)
            {
                MessageBox.Show("Message exceeds 140 character limit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (onlyNumbers.Length <= 8 || onlyNumbers.Length >= 13)
            {
                MessageBox.Show("Invalid phone number. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                message = functions.Expand(message);
                List<SMS> sms = new List<SMS>();
                sms.Add(new SMS()
                {
                  messageID = functions.IDCreator("S"),
                  messageBody = functions.BodyCreator(number, null, message, "S")
                });
                string json = JsonConvert.SerializeObject(sms.ToArray());

                // Writing the information to the file
                File.AppendAllText("SMSTexts.json", json);

                MessageBox.Show("SMS Text Message added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                Close();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }
    }
}
