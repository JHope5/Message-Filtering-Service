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
    public partial class ViewSIRs : Form
    {
        public ViewSIRs()
        {
            InitializeComponent();
        }

        private void ViewSIRs_Load(object sender, EventArgs e)
        {
            try
            {
                string sirs = File.ReadAllText("SIRs.json");

                // Display the file contents to the label
                lblSIRs.Text = sirs;

            }
            catch
            {

            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewMessages viewMessages = new ViewMessages();
            viewMessages.Show();
            Close();
        }
    }
}
