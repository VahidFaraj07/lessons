using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGame
{
    public partial class MainPage : Form
    {
        public static string whoIsNext = "O";
        public static List<string> charList = new List<string>(9);

        static MainPage()
        {
            for (int i = 0; i < 8; i++)
            {
                charList.Add("");
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (whoIsNext == "O")
            {
                btn.Text = "O";
                btn.BackColor = Color.Red;
                charList.Insert(btn.TabIndex, "O");
                whoIsNext = "X";
            }
            else if (whoIsNext == "X")
            {
                btn.Text = "X";
                btn.BackColor = Color.Green;
                charList.Insert(btn.TabIndex, "X");
                whoIsNext = "O";
            }

            btn.Enabled = false;
            CheckGameStatus(btn.Text);

        }

        private void CheckGameStatus(string gamer)
        {
            bool gamerIsWin = false;
            if (charList[0] == gamer && charList[1] == gamer && charList[2] == gamer)
            {
                gamerIsWin = true;
            }
            else if (charList[3] == gamer && charList[4] == gamer && charList[5] == gamer)
            {
                gamerIsWin = true;
            }
            else if (charList[6] == gamer && charList[7] == gamer && charList[8] == gamer)
            {
                gamerIsWin = true;
            }
            else if (charList[0] == gamer && charList[3] == gamer && charList[6] == gamer)
            {
                gamerIsWin = true;
            }
            else if (charList[1] == gamer && charList[4] == gamer && charList[7] == gamer)
            {
                gamerIsWin = true;
            }
            else if (charList[2] == gamer && charList[5] == gamer && charList[8] == gamer)
            {
                gamerIsWin = true;
            }
            else if (charList[0] == gamer && charList[4] == gamer && charList[8] == gamer)
            {
                gamerIsWin = true;
            }
            else if (charList[2] == gamer && charList[4] == gamer && charList[6] == gamer)
            {
                gamerIsWin = true;
            }
            else
            {
                if (allButtonIsSelected())
                {
                    MessageBox.Show("Oyun bitmisdir yeniden baslayin!");
                }
            }

            if (gamerIsWin)
            {
                MessageBox.Show($"{gamer} oyuncu qalibdir!!");
            }
        }

        private bool allButtonIsSelected()
        {
            for (int i = 0; i < 9; i++)
            {
                if (charList[i] == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            charList.Clear();

            foreach (var item in groupBox.Controls)
            {
                if (item is Button)
                {
                    Button tempButton = (Button)item;
                    tempButton.Text = "";
                    tempButton.Enabled = true;
                    tempButton.BackColor = Color.White;
                    for (int i = 0; i < 8; i++)
                    {
                        charList.Add("");
                    }
                }
            }
        }
    }
}
