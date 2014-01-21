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


        public string GetDescription()
        {
            string description = Bettor.Name + " bet $" + Amount + " on dog #" + Dog;
            return description;
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog) {
                return Amount;
            }
            else return (Amount * -1);
        }
    }
}
