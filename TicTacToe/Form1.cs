using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int player = 2; // even = x turn, odd = 0 turn
        public int turns = 0; // counting turns
        // counting wins for both player and draws
        public int XWinCount = 0; //s1
        public int OWinCount = 0; //s2
        public int DrawCount = 0; //sd

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "0";
                    player++;
                    turns++;
                }

                if(CheckDraw() == true)
                {
                    MessageBox.Show("Tie Game!");
                    DrawCount++;
                    NewGame();
                }

                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X won!");
                        XWinCount++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O won!");
                        OWinCount++;
                        NewGame();
                    }
                }
            }
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XWins.Text = "X: " + XWinCount;
            OWins.Text = "O: " + OWinCount;
            Draws.Text = "Draws: " + DrawCount;
        }

        void NewGame()
        {
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWins.Text = "X: " + XWinCount;
            OWins.Text = "O: " + OWinCount;
            Draws.Text = "Draws: " + DrawCount;
        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        bool CheckDraw()
        {
            if ((turns == 9) && (CheckWinner() == false))
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            // horizontal checks
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;

            // vertical checks
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            // diagonal checks
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                return true;
            else return false;
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            XWinCount = OWinCount = DrawCount = 0;
            NewGame();
        }
    }
}
