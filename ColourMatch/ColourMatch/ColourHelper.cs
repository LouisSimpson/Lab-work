using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ColourMatch
{
    class ColourHelper
    {
        public static int Distance(Color firstColour, Color secondColour)
        {
            // calculates a measure of how close two
            // colours are to each other using
            // a variation on pythagorus in the
            // colour space
            // a value of 0 means colours are the same
            // black and white returns the value 443!

            int redDistance = Math.Abs(firstColour.R - secondColour.R);
            int greenDistance = Math.Abs(firstColour.G - secondColour.G);
            int blueDistance = Math.Abs(firstColour.B - secondColour.B);

            int distance = (int)Math.Sqrt(redDistance * redDistance + greenDistance * greenDistance + blueDistance * blueDistance);

            return distance;
        }

    }
}


