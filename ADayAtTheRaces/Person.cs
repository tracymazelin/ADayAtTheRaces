using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Person
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
                       
        public void UpdateLabels()
        {
            if (MyBet == null) {
                MyLabel.Text = String.Format("{0} hasn't placed a bet", this.Name);
            }

            else MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = String.Format("{0} has {1} bucks", this.Name, this.Cash);  
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }


        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (BetAmount <= Cash) {
                MyBet = new Bet { Amount = BetAmount, Dog = DogToWin, Bettor = this };
                UpdateLabels();
                return true;
            }
            else return false;           
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}