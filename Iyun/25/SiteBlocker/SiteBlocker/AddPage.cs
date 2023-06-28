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

namespace SiteBlocker
{
    public partial class AddPage : Form
    {
        public event EventHandler ButtonClicked;

        private void Button_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public AddPage()
        {
            InitializeComponent();
        }

        public void addPageAddButton_Click(object sender, EventArgs e)
        {
            string hostsFilePath = @"C:\Windows\System32\drivers\etc\hosts";
            string newLineInHosts = "\n127.0.0.1        " + addPageSiteTextBox.Text;
            newLineInHosts = newLineInHosts.TrimEnd('\n', '\r');

            using (StreamWriter sw = File.AppendText(hostsFilePath))
            {
                sw.Write(newLineInHosts);
            }
            Button_Click(sender, e);
            this.Close();
        }
    
    }
}
