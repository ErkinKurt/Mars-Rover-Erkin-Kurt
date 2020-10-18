using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models.Rotation
{
    public class RightRotation : IRotation
    {
        public Direction Rotate(Direction direction)
        {
            return RotationHelper.CalculateDirection(direction, 1);
        }
    }
}
