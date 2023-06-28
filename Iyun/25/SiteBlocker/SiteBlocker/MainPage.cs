using System;
using System.Collections;
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
    public partial class MainPage : Form
    {
        string hostFilePath = @"C:\Windows\System32\drivers\etc\hosts";

        public MainPage()
        {
            InitializeComponent();
            ReloadList();
        }

        private void ReadHostFile()
        {
            string[] lines = File.ReadAllLines(hostFilePath);
            foreach (string line in lines)
            {
                if (!String.IsNullOrWhiteSpace(line) && line[0] != '#')
                {
                    string[] splitText = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (splitText[0] == "127.0.0.1" && splitText.Length == 2)
                    {
                        listBoxBlockedSites.Items.Add(splitText[1]);
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddPage();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ReloadList()
        {
            listBoxBlockedSites.Items.Clear();
            ReadHostFile();
        }

        private void AddPage()
        {
            AddPage newAddPage = new AddPage();
            newAddPage.ButtonClicked += OtherPages_ButtonsClicked;
            newAddPage.Show();
        }

        private void OtherPages_ButtonsClicked(object sender, EventArgs e)
        {
            ReloadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {


            string selectedItemText = listBoxBlockedSites.SelectedItem.ToString();

            string newFileContent = "";
            string[] lines = File.ReadAllLines(hostFilePath);
            foreach (string line in lines)
            {
                if (!line.Contains(selectedItemText) && !String.IsNullOrEmpty(line))
                {
                    newFileContent += line.Trim('\n', 'r');
                    newFileContent += '\r';
                }
            }
            File.WriteAllText(hostFilePath, newFileContent);
            ReloadList();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            string newFileContent = "";
            string[] lines = File.ReadAllLines(hostFilePath);
            string startLine = listBoxBlockedSites.Items[0].ToString();



            foreach (string line in lines)
            {
                if (line.Contains(startLine))
                {
                    break;
                }
                else {
                    newFileContent += line.Trim('\n', 'r');
                    newFileContent += '\r';
                }
            }
            File.WriteAllText(hostFilePath, newFileContent);
            ReloadList();
        }
    }
}
