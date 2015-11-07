using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int score = 0;
        Random randNum = new Random();
        int newNum = 5;
        int oldNum = 5;
        int bet = 1;
        
        
        private void RandomNumber()
        {
            // generate number between 1 and 10
            oldNum = newNum;
            newNum = randNum.Next(1, 10);
        }
        private void displayScore()
        {
            if (score < 0)
            {
                labelScore.ForeColor = Color.Red;

            }
            else
            {
                labelScore.ForeColor = Color.Black;
            }

            labelScore.Text = "Score is " + score;

        }
        public Form1()
        {
            InitializeComponent();
            labelNewNumber.Text = "Number is " + newNum.ToString();
            labelNumber.Text = " ";
            displayScore();
            //labelScore.Text = "Score is " + score;
            textBoxBet.Text = bet.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHigh_Click(object sender, EventArgs e)
        {
            RandomNumber(); // get new random
            bet = Int32.Parse(textBoxBet.Text); // convert textbox input to int
            if (oldNum < newNum)
            {
                score= score + bet;
            }
            if(oldNum > newNum)
            {
                score= score - bet;
            }
            labelNewNumber.Text = "New Number is "  + newNum.ToString();
            labelNumber.Text = "Old Number was " + oldNum.ToString();
            displayScore();



        }

        private void buttonLow_Click(object sender, EventArgs e)
        {
            RandomNumber();
            bet = Int32.Parse(textBoxBet.Text);
            if (oldNum > newNum)
            {
                score = score + bet;
            }
            if (oldNum < newNum)
            {
                score = score - bet;
            }
            labelNewNumber.Text = "New Number is " + newNum.ToString();
            labelNumber.Text = "Old Number was " + oldNum.ToString();
            displayScore();

        }

        private void labelNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)  )
            {
                e.Handled = true;
            }
        }
    }
}
