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
    public partial class ViewMentions : Form
    {
        public ViewMentions()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewTweets viewTweets = new ViewTweets();
            viewTweets.Show();
            Close();
        }

        private void ViewMentions_Load(object sender, EventArgs e)
        {
            try
            {
                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                string[] mentions = File.ReadAllLines("Mentions.json");

                // Display the file contents by using a foreach loop.
                foreach (string mention in mentions)
                {
                    // Use a tab to indent each line of the file.
                    lblMentions.Text = mention;
                }
            }
            catch
            { }
        }
    }
}
