namespace ADayAtTheRaces
{
    partial class Races
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.setBet = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.player3BetLabel = new System.Windows.Forms.Label();
            this.player2BetLabel = new System.Windows.Forms.Label();
            this.player1BetLabel = new System.Windows.Forms.Label();
            this.Bets = new System.Windows.Forms.Label();
            this.player3Radio = new System.Windows.Forms.RadioButton();
            this.player2Radio = new System.Windows.Forms.RadioButton();
            this.player1Radio = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.dogNumber);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.betAmount);
            this.GroupBox1.Controls.Add(this.setBet);
            this.GroupBox1.Controls.Add(this.name);
            this.GroupBox1.Controls.Add(this.race);
            this.GroupBox1.Controls.Add(this.player3BetLabel);
            this.GroupBox1.Controls.Add(this.player2BetLabel);
            this.GroupBox1.Controls.Add(this.player1BetLabel);
            this.GroupBox1.Controls.Add(this.Bets);
            this.GroupBox1.Controls.Add(this.player3Radio);
            this.GroupBox1.Controls.Add(this.player2Radio);
            this.GroupBox1.Controls.Add(this.player1Radio);
            this.GroupBox1.Controls.Add(this.minimumBetLabel);
            this.GroupBox1.Location = new System.Drawing.Point(0, 248);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(754, 192);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Betting Parlor";
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(322, 150);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(50, 20);
            this.dogNumber.TabIndex = 13;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(206, 152);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "bucks on dog number";
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(150, 150);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(50, 20);
            this.betAmount.TabIndex = 11;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // setBet
            // 
            this.setBet.Location = new System.Drawing.Point(390, 150);
            this.setBet.Name = "setBet";
            this.setBet.Size = new System.Drawing.Size(75, 23);
            this.setBet.TabIndex = 10;
            this.setBet.Text = "Place Bet";
            this.setBet.UseVisualStyleBackColor = true;
            this.setBet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(40, 150);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 9;
            this.name.Text = "name";
            // 
            // race
            // 
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(441, 51);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(228, 60);
            this.race.TabIndex = 8;
            this.race.Text = "RACE!";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // player3BetLabel
            // 
            this.player3BetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player3BetLabel.Location = new System.Drawing.Point(205, 100);
            this.player3BetLabel.Name = "player3BetLabel";
            this.player3BetLabel.Size = new System.Drawing.Size(200, 15);
            this.player3BetLabel.TabIndex = 7;
            this.player3BetLabel.Text = "player3BetLabel";
            // 
            // player2BetLabel
            // 
            this.player2BetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2BetLabel.Location = new System.Drawing.Point(205, 77);
            this.player2BetLabel.Name = "player2BetLabel";
            this.player2BetLabel.Size = new System.Drawing.Size(200, 15);
            this.player2BetLabel.TabIndex = 6;
            this.player2BetLabel.Text = "player2BetLabel";
            // 
            // player1BetLabel
            // 
            this.player1BetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1BetLabel.Location = new System.Drawing.Point(205, 54);
            this.player1BetLabel.Name = "player1BetLabel";
            this.player1BetLabel.Size = new System.Drawing.Size(200, 15);
            this.player1BetLabel.TabIndex = 5;
            this.player1BetLabel.Text = "player1BetLabel";
            // 
            // Bets
            // 
            this.Bets.AutoSize = true;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.Location = new System.Drawing.Point(205, 29);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(32, 13);
            this.Bets.TabIndex = 4;
            this.Bets.Text = "Bets";
            // 
            // player3Radio
            // 
            this.player3Radio.AutoSize = true;
            this.player3Radio.Location = new System.Drawing.Point(15, 100);
            this.player3Radio.Name = "player3Radio";
            this.player3Radio.Size = new System.Drawing.Size(87, 17);
            this.player3Radio.TabIndex = 3;
            this.player3Radio.TabStop = true;
            this.player3Radio.Text = "player3Radio";
            this.player3Radio.UseVisualStyleBackColor = true;
            this.player3Radio.CheckedChanged += new System.EventHandler(this.player3RadioButton_CheckedChanged);
            // 
            // player2Radio
            // 
            this.player2Radio.AutoSize = true;
            this.player2Radio.Location = new System.Drawing.Point(15, 77);
            this.player2Radio.Name = "player2Radio";
            this.player2Radio.Size = new System.Drawing.Size(87, 17);
            this.player2Radio.TabIndex = 2;
            this.player2Radio.TabStop = true;
            this.player2Radio.Text = "player2Radio";
            this.player2Radio.UseVisualStyleBackColor = true;
            this.player2Radio.CheckedChanged += new System.EventHandler(this.player2RadioButton_CheckedChanged);
            // 
            // player1Radio
            // 
            this.player1Radio.AutoSize = true;
            this.player1Radio.Location = new System.Drawing.Point(15, 54);
            this.player1Radio.Name = "player1Radio";
            this.player1Radio.Size = new System.Drawing.Size(87, 17);
            this.player1Radio.TabIndex = 1;
            this.player1Radio.TabStop = true;
            this.player1Radio.Text = "player1Radio";
            this.player1Radio.UseVisualStyleBackColor = true;
            this.player1Radio.CheckedChanged += new System.EventHandler(this.player1RadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(12, 29);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(131, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum Bet: 5 bucks";
            // 
            // Dog1
            // 
            this.Dog1.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.Dog1.Location = new System.Drawing.Point(82, 23);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(75, 23);
            this.Dog1.TabIndex = 12;
            this.Dog1.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.Dog3.Location = new System.Drawing.Point(81, 123);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(77, 22);
            this.Dog3.TabIndex = 15;
            this.Dog3.TabStop = false;
            // 
            // Dog4
            // 
            this.Dog4.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.Dog4.Location = new System.Drawing.Point(83, 176);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(75, 22);
            this.Dog4.TabIndex = 14;
            this.Dog4.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.Dog2.Location = new System.Drawing.Point(82, 67);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(76, 22);
            this.Dog2.TabIndex = 13;
            this.Dog2.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = global::ADayAtTheRaces.Properties.Resources.racetrack;
            this.racetrackPictureBox.Location = new System.Drawing.Point(72, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(601, 203);
            this.racetrackPictureBox.TabIndex = 17;
            this.racetrackPictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "bets";
            // 
            // Races
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 452);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.racetrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Races";
            this.Text = "A Day At The Races";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox Dog1;
        internal System.Windows.Forms.PictureBox Dog3;
        internal System.Windows.Forms.PictureBox Dog4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.NumericUpDown dogNumber;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown betAmount;
        internal System.Windows.Forms.Button setBet;
        internal System.Windows.Forms.Label name;
        internal System.Windows.Forms.Button race;
        internal System.Windows.Forms.Label player3BetLabel;
        internal System.Windows.Forms.Label player2BetLabel;
        internal System.Windows.Forms.Label player1BetLabel;
        internal System.Windows.Forms.Label Bets;
        internal System.Windows.Forms.RadioButton player3Radio;
        internal System.Windows.Forms.RadioButton player2Radio;
        internal System.Windows.Forms.RadioButton player1Radio;
        internal System.Windows.Forms.Label minimumBetLabel;
        internal System.Windows.Forms.PictureBox Dog2;
        internal System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

