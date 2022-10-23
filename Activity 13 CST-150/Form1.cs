using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13_CST_150
{

    public partial class Form1 : Form
    {
        //Here we declare a two dimensional array to store random values. 
        int[,] myArray = new int[3, 3];

        // Here we declare our integers. 
        int playersWins1;
        int playersWins2;
        int ties;
        int i;
        int j;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Generate random numbers for the 2D array. 
            Random randonNum = new Random();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    myArray[i, j] = randonNum.Next(0, 2);
                }
            }

            //Display an assortment of random numbers and convert them all to strings. 
            btn1.Text = myArray[1, 1].ToString();
            btn2.Text = myArray[0, 2].ToString();
            btn3.Text = myArray[0, 1].ToString();
            btn4.Text = myArray[2, 0].ToString();
            btn5.Text = myArray[0, 0].ToString();
            btn6.Text = myArray[2, 1].ToString();
            btn7.Text = myArray[1, 0].ToString();
            btn8.Text = myArray[1, 2].ToString();
            btn9.Text = myArray[1, 1].ToString();

            //Check the board to determine who won. 
            CheckBoard();

        }


        // Clear the entire board. 
        private void btnRestart_Click(object sender, EventArgs e)
        {
            btn1.Text = string.Empty;
            btn2.Text = string.Empty;
            btn3.Text = string.Empty;
            btn4.Text = string.Empty;
            btn5.Text = string.Empty;
            btn6.Text = string.Empty;
            btn7.Text = string.Empty;
            btn8.Text = string.Empty;
            btn9.Text = string.Empty;
            txtPlayerWins1.Clear();
            txtPlayerWins2.Clear();
            txtTies.Clear();
            playersWins1 = 0;
            playersWins2 = 0;
            ties = 0;
            i = 0;
            j = 0;
        }

        // Exit the application 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //Check The Board
        public void CheckBoard()
        {
            // Set the count of marks to zero. 
            int player1 = 0;
            int player2 = 0;

           // Check the top row, horizontally. 
            if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "")
            {
                if (btn1.Text == btn2.Text && btn1.Text == btn3.Text)
                {
                    if (btn1.Text == "1")
                    {
                        player1++;
                    }
                    else
                    {
                        player2++;
                    }
                }
            }
            //Check the middle row, horizontally. 
            if (btn4.Text != "" && btn5.Text != "" && btn6.Text != "")
            {
                if (btn4.Text == btn5.Text && btn4.Text == btn6.Text)
                {
                    if (btn4.Text == "1")
                    {
                        player1++;
                    }
                    else
                    {
                        player2++;
                    }
                }
            }
            //Check the bottom row, horizontally. 
            if (btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                if (btn7.Text == btn8.Text && btn7.Text == btn9.Text)
                {
                    if (btn7.Text == "1")
                    {
                        player1++;
                    }
                    else
                    {
                        player2++;
                    }
                }
            }
            // Check the first row, starting from left to right, diagonally. 
            if (btn1.Text != "" && btn5.Text != "" && btn9.Text != "")
            {
                if (btn1.Text == btn5.Text && btn1.Text == btn9.Text)
                {
                    if (btn1.Text == "1")
                    {
                        player1++;
                    }
                    else
                    {
                        player2++;
                    }
                }
            }
            // Check the second row, starting from right to left, diagonally. 
            if (btn3.Text != "" && btn5.Text != "" && btn7.Text != "")
            {
                if (btn3.Text == btn5.Text && btn3.Text == btn7.Text)
                {
                    if (btn3.Text == "1")
                    {
                        player1++;
                    }
                    else
                    {
                        player2++;
                    }
                }
            }
            //Check the first row - starting from the left, vertically. 
            if (btn1.Text != "" && btn4.Text != "" && btn7.Text != "")
            {
                if (btn1.Text == btn4.Text && btn1.Text == btn7.Text)
                {
                    if (btn1.Text == "1")
                    {
                        player1++;
                    }
                    else
                    {
                        player2++;
                    }
                }
            }
            //Check the  second row, vertically. 
            if (btn2.Text != "" && btn5.Text != "" && btn8.Text != "")
            {
                if (btn2.Text == btn5.Text && btn2.Text == btn8.Text)
                {
                    if (btn2.Text == "1")
                    {
                        player1++;
                    }
                    else
                    {
                        player2++;
                    }
                }
            }
            //Check the last row, vertically. 
            if (btn3.Text != "" && btn6.Text != "" && btn9.Text != "")
            {
                if (btn3.Text == btn6.Text && btn3.Text == btn9.Text)
                {
                    if (btn3.Text == "1")
                    {
                        player1++;
                    }
                    else
                    {
                        player2++;
                    }
                }
            }


            // Display who won. 
            if (player1 > player2)
            {
                playersWins1++;
                txtPlayerWins1.Text = playersWins1.ToString(); 
                MessageBox.Show("Player 1 Wins The Game!");
            }
            if (player1 < player2)
            {
                playersWins2++;
                txtPlayerWins2.Text = playersWins2.ToString();
                MessageBox.Show("Player 2 Wins The Game!");
            }
            if (player1 == player2)
            {
                ties++;
                txtTies.Text = ties.ToString();
                MessageBox.Show("It's a tie!");
            }
        }
    }
}