using Newtonsoft.Json;
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
    public partial class ViewTweets : Form
    {
        public ViewTweets()
        {
            InitializeComponent();
        }

        private void ViewTweets_Load(object sender, EventArgs e)
        {
            try
            {
                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                string[] tweets = File.ReadAllLines("Tweets.json");

                // Display the file contents by using a foreach loop.
                foreach (string tweet in tweets)
                {
                    // Use a tab to indent each line of the file.
                    lblTweets.Text = tweet;
                }
            }
            catch { }
        }

        private void btnViewTrending_Click(object sender, EventArgs e)
        {
            ViewTrending viewTrending = new ViewTrending();
            viewTrending.Show();
            Close();
        }

        private void btnViewMentions_Click(object sender, EventArgs e)
        {
            ViewMentions viewMentions = new ViewMentions();
            viewMentions.Show();
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewMessages viewMessages = new ViewMessages();
            viewMessages.Show();
            Close();
        }
    }
}
