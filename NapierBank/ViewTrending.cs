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
    public partial class ViewTrending : Form
    {
        public ViewTrending()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewTweets viewTweets = new ViewTweets();
            viewTweets.Show();
            Close();
        }

        private void ViewTrending_Load(object sender, EventArgs e)
        {
            try
            {
                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                string[] hashtags = File.ReadAllLines("Trending.json");

                // Display the file contents by using a foreach loop.
                foreach (string hashtag in hashtags)
                {
                    // Use a tab to indent each line of the file.
                    lblHashtags.Text = hashtag;
                }
            }
            catch
            { }
        }
    }
}
