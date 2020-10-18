using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models
{
    public interface IRotation
    {
        Direction Rotate(Direction direction);
    }
}
