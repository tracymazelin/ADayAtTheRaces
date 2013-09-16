using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Person Bettor;

        public Bet(int Amount, int Dog, Person Bettor) 
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
           
        }

        public string GetDescription()
        {
            string description = this.Bettor.Name + " bet $" + this.Amount + " on dog #" + Dog;
            return description;
        }

        public int PayOut(int Winner)
        {
            return Winner;
        }
    }
}
