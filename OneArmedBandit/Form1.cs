﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random randGen = new Random();
        // int value for score initialized to 10
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            int reelOne, reelTwo, reelThree;
            // get random values for each reel (store each in separate int variable)
            reelOne = randGen.Next(1,4);
            reelTwo = randGen.Next(1, 4);
            reelThree = randGen.Next(1, 4);
            // check value of reel 1 with a switch statement and set appropriate image
            switch (reelOne)
            {
                case 1:
                    reel1.Image = (Properties.Resources._7_100x125);
                    break;
                case 2:
                    reel1.Image = (Properties.Resources.diamond_100x125);
                    break;
                case 3:
                    reel1.Image = (Properties.Resources.cherry_100x125);
                    break;
            }

            // check value of reel 2 with a switch statement and set appropriate image
            switch (reelTwo)
            {
                case 1:
                    reel2.Image = (Properties.Resources._7_100x125);
                    break;
                case 2:
                    reel2.Image = (Properties.Resources.diamond_100x125);
                    break;
                case 3:
                    reel2.Image = (Properties.Resources.cherry_100x125);
                    break;
            }

            // check value of reel 3 with a switch statement and set appropriate image
            switch (reelThree)
            {
                case 1:
                    reel3.Image = (Properties.Resources._7_100x125);
                    break;
                case 2:
                    reel3.Image = (Properties.Resources.diamond_100x125);
                    break;
                case 3:
                    reel3.Image = (Properties.Resources.cherry_100x125);
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.         
            if (reelOne == reelTwo && reelThree == reelTwo)
            {
               
                    outputLabel.Text = "Winner!!";
                    score += 3;
            }
            else
            {
                outputLabel.Text = "Loser";
                score--;
            }

            // if score has reached 0 display "lose" message and set button enabled property to false
            if (score <= 0)
            {
                spinButton.Enabled = false;
                takeitButton.Enabled = false;
                outputLabel.Text = "You Are In Debt";
            }

            // display updated score
            scoreDisplay.Text = $"{score}";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            spinButton.Enabled = false;
            outputLabel.Text = $"score of {score}";
        }
    }
}
