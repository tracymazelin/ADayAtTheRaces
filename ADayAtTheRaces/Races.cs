using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces {
    public partial class Races : Form {
        Greyhound[] dogs = new Greyhound[4];
        Person[] players = new Person[3];
        Random MyRandomizer = new Random();

        public Races() {
            InitializeComponent();

            dogs[0] = new Greyhound { MyPictureBox = Dog1, StartingPosition = Dog1.Left, RacetrackLength = racetrackPictureBox.Width - Dog1.Width, Randomizer = MyRandomizer };
            dogs[1] = new Greyhound { MyPictureBox = Dog2, StartingPosition = Dog2.Left, RacetrackLength = racetrackPictureBox.Width - Dog2.Width, Randomizer = MyRandomizer };
            dogs[2] = new Greyhound { MyPictureBox = Dog3, StartingPosition = Dog3.Left, RacetrackLength = racetrackPictureBox.Width - Dog2.Width, Randomizer = MyRandomizer };
            dogs[3] = new Greyhound { MyPictureBox = Dog4, StartingPosition = Dog4.Left, RacetrackLength = racetrackPictureBox.Width - Dog3.Width, Randomizer = MyRandomizer };

            //Changed names for my kids to play it!
            players[0] = new Person { Name = "David", MyBet = null, Cash = 50, MyRadioButton = player1Radio, MyLabel = player1BetLabel };
            players[1] = new Person { Name = "Jonathan", MyBet = null, Cash = 50, MyRadioButton = player2Radio, MyLabel = player2BetLabel };
            players[2] = new Person { Name = "Jacob", MyBet = null, Cash = 50, MyRadioButton = player3Radio, MyLabel = player3BetLabel };

            foreach (Person player in players) {
                player.UpdateLabels();
            }
        }

        private void raceButton_Click(object sender, EventArgs e) {
            foreach (Greyhound dog in dogs) {
                timer1.Start();
                dog.TakeStartingPosition();
            }
        }

        private void Bet_Click(object sender, EventArgs e) {
            for (int i = 0; i < this.players.Length; i++) {
                if (this.players[i].Name == name.Text) {
                    players[i].PlaceBet((int)betAmount.Value, (int)dogNumber.Value);
                    players[i].UpdateLabels();
                }
            }
        }

        private void player1RadioButton_CheckedChanged(object sender, EventArgs e) {
            name.Text = players[0].Name;
        }

        private void player2RadioButton_CheckedChanged(object sender, EventArgs e) {
            name.Text = players[1].Name;
        }

        private void player3RadioButton_CheckedChanged(object sender, EventArgs e) {
            name.Text = players[2].Name;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            for (int i = 0; i < dogs.Length; i++) {
                if (dogs[i].Run()) {
                    timer1.Stop();
                    int Winner = i + 1;

                    MessageBox.Show("Dog #" + Winner + " Won!");

                    foreach (Person player in players) {
                        player.Collect(Winner);
                    }

                    foreach (Greyhound dog in dogs)
                    {
                        dog.TakeStartingPosition();
                    }
                }
            }
        }
    }
}
