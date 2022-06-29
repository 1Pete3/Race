using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Races
{
    public partial class Form1 : Form
    {
        Guy joe, al, bob;
        Bet joeBet, alBet, bobBet;
        public Form1()
        {
            InitializeComponent();
            buttonRace.Enabled = false;
            labelMinimumBet.Text = "Minimum bet: " + numericUpDownMoney.Minimum.ToString() + " bucks";

            joe = new Guy() {Name = "Joe",Cash = 50, MyBet = null, MyRadioButton = radioButtonJoe,MyLabel = labelJoeBet };
            joeBet = new Bet() { Amount = 0, Dog = 0, Bettor = null };

            bob = new Guy() { Name = "Bob", Cash = 75, MyBet = null, MyRadioButton = radioButtonBob, MyLabel = labelBobBet };
            bobBet = new Bet() { Amount = 0, Dog = 0, Bettor = null };

            al = new Guy() { Name = "Al", Cash = 45, MyBet = null, MyRadioButton = radioButtonAl, MyLabel = labelAlBet };
            alBet = new Bet() { Amount = 0, Dog = 0, Bettor = null };

            if (joeBet.Amount == 0 && bobBet.Amount == 0 && alBet.Amount == 0)
            {
                labelJoeBet.Text = joe.Name + " hasn't placed a bet";
                labelBobBet.Text = bob.Name + " hasn't placed a bet";
                labelAlBet.Text = al.Name + " hasn't placed a bet";
            }

            joe.UpdateLabels();
            al.UpdateLabels();
            bob.UpdateLabels();
        }

        private void buttonBets_Click(object sender, EventArgs e)
        {

            if (radioButtonJoe.Checked == true)
            {
                joeBet.Amount = Convert.ToInt32(numericUpDownMoney.Value);
                joeBet.Dog = Convert.ToInt32(numericUpDownDogNum.Value);
                joeBet.Bettor = joe;
                if (joe.PlaceBet(joeBet.Amount, joeBet.Dog) == true)
                {
                    buttonRace.Enabled = true;
                }
                else 
                {
                    buttonRace.Enabled = false;
                    joeBet.Amount = 0;
                    labelJoeBet.Text = joe.Name + " hasn't placed a bet";
                    resetMoneyAndDog();
                }
                Console.WriteLine(joeBet.Amount);
            }
            else if (radioButtonBob.Checked == true)
            {
                bobBet.Amount = Convert.ToInt32(numericUpDownMoney.Value);
                bobBet.Dog = Convert.ToInt32(numericUpDownDogNum.Value);
                bobBet.Bettor = bob;
                if (bob.PlaceBet(bobBet.Amount, bobBet.Dog) == true)
                {
                    buttonRace.Enabled = true;
                }
                else
                {
                    buttonRace.Enabled = false;
                    bobBet.Amount = 0;
                    labelBobBet.Text = al.Name + " hasn't placed a bet";
                    resetMoneyAndDog();
                }
            }
            else if (radioButtonAl.Checked == true)
            {
                alBet.Amount = Convert.ToInt32(numericUpDownMoney.Value);
                alBet.Dog = Convert.ToInt32(numericUpDownDogNum.Value);
                alBet.Bettor = al;
                if (al.PlaceBet(alBet.Amount, alBet.Dog) == true)
                {
                    buttonRace.Enabled = true;
                }
                else
                {
                    buttonRace.Enabled = false;
                    alBet.Amount = 0;
                    labelAlBet.Text = al.Name + " hasn't placed a bet";
                    resetMoneyAndDog();
                }
            }
            else 
            {
                MessageBox.Show("Select a bettor","No Bettor Seleceted",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
  
        }

        private void buttonRace_Click(object sender, EventArgs e)
        {

        }

        private void labelJoeBet_Click(object sender, EventArgs e)
        {

        }

        private void resetMoneyAndDog() 
        {
            numericUpDownMoney.Value = numericUpDownMoney.Minimum;
            numericUpDownDogNum.Value = numericUpDownDogNum.Minimum;
        }
        private void radioButtonBob_CheckedChanged(object sender, EventArgs e)
        {
            resetMoneyAndDog();
            if (radioButtonBob.Checked == true) 
            {
                labelName.Visible = true;
                labelName.Text = bob.Name;
            }
        }

        private void radioButtonAl_CheckedChanged(object sender, EventArgs e)
        {
            resetMoneyAndDog();
            if (radioButtonAl.Checked == true) 
            {
                labelName.Visible = true;
                labelName.Text = al.Name;
            }
        }

        private void radioButtonJoe_CheckedChanged(object sender, EventArgs e)
        {
            resetMoneyAndDog();
            if (radioButtonJoe.Checked == true)
            {
                labelName.Visible = true;
                labelName.Text = joe.Name;
            }
        }
    }
}
