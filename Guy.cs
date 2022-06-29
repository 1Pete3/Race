using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Races
{
    internal class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        public void ClearBet()
        {
            
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            if (Cash >= Amount && Amount >= 5)
            {
                MyLabel.Text = Name + " bets " + Amount + " on dog #"+Dog;
                return true;
            }
            else 
            {
                MessageBox.Show(Name + " only has $" + Cash,"Not Enough Money",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            
        }

        public void Collect(int Winner) 
        {
            Bet bet = new Bet();
            bet.Payout(Winner);
        }
    }

    class Bet 
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription() 
        {
            return "";
           
        }

        public int Payout(int Winner) 
        {
            if (Dog == Winner)
            {
                return Amount * 2;
            }
            else 
            {
                return -Amount;
            }
        }
    }
}
