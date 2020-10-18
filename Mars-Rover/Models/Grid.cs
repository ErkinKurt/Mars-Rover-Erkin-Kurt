using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models
{
    public class Grid
    {
        public Coordinates LeftCorner { get; set; }
        public Coordinates RightCorner { get; set; }

        public Grid(Coordinates leftCorner, Coordinates rightCorner)
        {
            this.LeftCorner = leftCorner;
            this.RightCorner = rightCorner;
        }
    }
}
