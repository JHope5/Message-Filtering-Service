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
    public partial class ViewSMSTexts : Form
    {
        public ViewSMSTexts()
        {
            InitializeComponent();
        }

        private void ViewSMSTexts_Load(object sender, EventArgs e)
        {
            try
            {
                string smstexts = File.ReadAllText("SMSTexts.json");

                // Display the file contents to the label
                lblSMSTexts.Text = smstexts;
            }
            catch
            { }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewMessages viewMessages = new ViewMessages();
            viewMessages.Show();
            Close();
        }
    }
}
