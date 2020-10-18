using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models.Rotation
{
    public class RotationHelper
    {
        public static Direction CalculateDirection(Direction currentDirection, int movementConstant)
        {
            int headDirection = (int)currentDirection;
            int totalDirectionNumber = Enum.GetNames(typeof(Direction)).Length;
            int calculatedDirection = (headDirection + totalDirectionNumber + movementConstant) % totalDirectionNumber;

            return (Direction)calculatedDirection;
        }
    }
}
