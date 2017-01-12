using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ColourMatch
{


    public class Game
    {
        Color targetColour;
        int guessRed;
        int guessGreen;
        int guessBlue;
        Random random;

        // constructor
        public Game()
        {
            // create a random Object
            random = new Random();

            // create a random colour
            int red = random.Next(0, 255);
            int green = random.Next(0, 255);
            int blue = random.Next(0, 255);

            targetColour = Color.FromArgb(255, red, green, blue);

            // start the guessing with black (0,0,0)
            guessRed = 0;
            guessGreen = 0;
            guessBlue = 0;
        }


        // get set functions

        public Color TargetColour
        {
            get { return targetColour; }
        }

        // creates the currently guessed colour from the R,G,B components
        public Color Guess
        {
            get { return Color.FromArgb(255, guessRed, guessGreen, guessBlue); }
        }

        public int GuessRed
        {
            get { return guessRed; }
            set { guessRed = value; }
        }
        public int GuessGreen
        {
            get { return guessGreen; }
            set { guessGreen = value; }
        }
        public int GuessBlue
        {
            get { return guessBlue; }
            set { guessBlue = value; }
        }

    }
}
