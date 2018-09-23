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
    public partial class SendTweet : Form
    {
        public SendTweet()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string message = txtTweet.Text;
            string username = txtUsername.Text;

            // Validation
            if (message == "" || username == "")
            {
                MessageBox.Show("Invalid input. Boxes cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (message.Length > 140)
            {
                MessageBox.Show("Tweet exceeds 140 character limit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((username.Length > 15) || (!Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$")))
            {
                MessageBox.Show("Invalid username. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Functions functions = new Functions();
                message = functions.Expand(message);

                #region Storing Hashtags
                foreach (Match match in Regex.Matches(message, @"(?<!\w)#\w+"))
                {

                    File.AppendAllText("Trending.json", " - " + match.Value);
                }
                #endregion

                #region Storing Mentions
                foreach (Match match in Regex.Matches(message, @"(?<!\w)@\w+"))
                {
                    File.AppendAllText("Mentions.json", " - " + match.Value);
                }
                #endregion

                string messageID = functions.IDCreator("T");
                string body = functions.BodyCreator(username, null, message, "T");

                // Creating a tweet from the information provided
                List<Tweet> tweets = new List<Tweet>();
                tweets.Add(new Tweet()
                {
                    messageID = functions.IDCreator("T"),
                    messageBody = functions.BodyCreator(username, null, message, "T")
                });
                string json = JsonConvert.SerializeObject(tweets.ToArray());

                // Writing the information to the file
                File.AppendAllText("Tweets.json", json);

                // Displaying a message and redirecting the user to the Main Menu
                MessageBox.Show("Tweet added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
