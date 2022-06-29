using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Races
{
    internal class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public int Location;
        public PictureBox MyPictureBox;
        public Random Randomizer;

        public bool Run() 
        {
            int distance = Convert.ToInt32(Randomizer);
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            if (p.X >= 670)
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        public void TakeStartingPosition() 
        {
            StartingPosition = 49;
        }

    }
}
