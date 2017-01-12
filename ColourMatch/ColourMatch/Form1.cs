using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourMatch
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            game.GuessRed = trackBarRed.Value;
            pictureBoxGuess.BackColor = game.Guess;
            pictureBoxGuess.Invalidate();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            game.GuessGreen = trackBarGreen.Value;
            pictureBoxGuess.BackColor = game.Guess;
            pictureBoxGuess.Invalidate();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            game.GuessBlue = trackBarBlue.Value;
            pictureBoxGuess.BackColor = game.Guess;
            pictureBoxGuess.Invalidate();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int distance = ColourHelper.Distance(game.TargetColour, game.Guess);

            // show how well you did
            MessageBox.Show(String.Format("Score: {0}", distance));

            // start a new game here
            StartNewGame();
        }
        public void StartNewGame()
        {
            game = new Game();
            pictureBoxColour.BackColor = game.TargetColour;
            // zero the trackbars
            trackBarRed.Value = 0;
            trackBarGreen.Value = 0;
            trackBarBlue.Value = 0;
            pictureBoxGuess.BackColor = game.Guess;

        }
    }
}
