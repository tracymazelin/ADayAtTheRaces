using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Person[] players = new Person[3];
                
        public Form1()
        {
            InitializeComponent();

			dogs[0] = new Greyhound()
	        {
		        MyPictureBox = Dog1,
		        StartingPosition = Dog1.Left,
		        RacetrackLength = racetrackPictureBox.Width - Dog1.Width,
		       // Randomizer = MyRandomizer
	        };

            dogs[1] = new Greyhound()
            {
                MyPictureBox = Dog2,
                StartingPosition = Dog2.Left,
                RacetrackLength = racetrackPictureBox.Width - Dog2.Width,
                //Randomizer = MyRandomizer
            };

            dogs[2] = new Greyhound()
            {
                MyPictureBox = Dog3,
                StartingPosition = Dog3.Left,
                RacetrackLength = racetrackPictureBox.Width - Dog3.Width,
                //Randomizer = MyRandomizer
            };

            players[0] = new Person("David", null, 50, player1Radio, player1BetLabel);
            players[1] = new Person("Jonathan", null, 75, player2Radio, player2BetLabel);
            players[2] = new Person("Jacob", null, 45, player3Radio, player3BetLabel);

            foreach (Person player in players)
            {
                player.UpdateLabels();
            }
   

        }

        private void raceButton_Click(object sender, EventArgs e)
        {

        }

        private void Bet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.players.Length; i++)
            {
                if (this.players[i].Name == name.Text)
                {
                    players[i].PlaceBet((int)betAmount.Value, (int)dogNumber.Value);
                    players[i].UpdateLabels();                                   
                }
            }
            
                      
        }

        private void player1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = players[0].Name;
        }

        private void player2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = players[1].Name;
        }

        private void player3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = players[2].Name;
        }
    }
}
