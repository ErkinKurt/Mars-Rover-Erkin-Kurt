using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models
{
    public class Coordinates
    {
        public int x { get; set; }
        public int y { get; set; }

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || ! this.GetType().Equals(obj.GetType())) {
                return false;
            }
            else
            {
                Coordinates c = (Coordinates) obj;
                return (this.x == c.x) && (this.y == c.y);
            }
        }

        public override int GetHashCode()
        {
            return (this.x << 2) ^ y;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.x, this.y);
        }

        public static bool operator <=(Coordinates a, Coordinates b)
        {
            return (a.x <= b.x) && (a.y <= b.y);
        }
        public static bool operator >=(Coordinates a, Coordinates b)
        {
            return (a.x >= b.x) && (a.y >= b.y);
        }
    }
}
