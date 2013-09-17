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
        
        public bool Run()
        {
           
           int moveForward = Randomizer.Next(1,8);
           Location += moveForward; 
           MyPictureBox.Left = StartingPosition + Location;

           if (MyPictureBox.Left == RacetrackLength)
           {
               
               return true;
              
           } else return false;
           
        }

        public void TakeStartingPosition()
        {
            Location = 0;
           // MyPictureBox = null;    
        }


    }
}
