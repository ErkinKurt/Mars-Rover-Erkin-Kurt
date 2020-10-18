using Mars_Rover.Models.Movement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models
{
    public class Rover : IMovable
    {

        public Rover(Coordinates initialPosition, Direction headDirection, Grid grid)
        {
            this.CurrentPosition = initialPosition;
            this.HeadDirection = headDirection;
            this.Grid = grid;
        }

        public Direction HeadDirection { get; set; }

        public Coordinates CurrentPosition { get; set; }

        public Grid Grid { get; set; }

        public const String OutOfBoundsMessage = "Out of bounds, Marsians have captured us.";

        public void Move(IMovement movement)
        {
            Coordinates nextCoordinate = movement.Move(HeadDirection, CurrentPosition);
            if (IsInGrid(nextCoordinate))
            {
                CurrentPosition = nextCoordinate;
            }
            else
            {
                throw new Exception(OutOfBoundsMessage);
            }
        }

        public void Rotate(IRotation rotation)
        {
           HeadDirection = rotation.Rotate(HeadDirection);
        }

        private bool IsInGrid(Coordinates coordinates)
        {
            return (Grid.LeftCorner <= coordinates) && (coordinates <= Grid.RightCorner);
        }
    }
}
