using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

       //Not sure where this goes yet.
       

        public bool Run()
        {
            this.Randomizer = new Random(); 
            
            return true;
        }

        public void TakeStartingPosition()
        {
            Location = 0;
           // MyPictureBox = 0;
        }


    }
}
