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

        public Person(string Name, Bet MyBet, int Cash, RadioButton MyRadio, Label MyLabel)
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadio;
            this.MyLabel = MyLabel;

        }
        
        public void UpdateLabels()
        {
           
            if (MyBet == null)
            {
                MyLabel.Text = String.Format(this.Name + " hasn't placed a bet");
            }
            
            else MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = this.Name + " has " + this.Cash + " bucks";
           
             
        }

        public void ClearBet()
        {

        }


        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if (BetAmount <= Cash)
            {
                MyBet = new Bet(BetAmount, DogToWin, this);
                return true;
            }
            else return false;   
        
        }

        public void Collect(int Winner)
        {
 
        }

    }
}