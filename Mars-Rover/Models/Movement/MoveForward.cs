using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models.Movement
{
    public class MoveForward : IMovement
    {
        public Coordinates Move(Direction headDirection, Coordinates currentCoordinates)
        {
            switch (headDirection)
            {
                case Direction.N:
                    currentCoordinates.y += 1;
                    break;
                case Direction.E:
                    currentCoordinates.x += 1;
                    break;
                case Direction.S:
                    currentCoordinates.y -= 1;
                    break;
                case Direction.W:
                    currentCoordinates.x -= 1;
                    break;
            }
            return currentCoordinates;
        }
    }
}
