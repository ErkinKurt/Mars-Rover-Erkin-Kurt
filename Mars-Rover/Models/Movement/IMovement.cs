using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models.Movement
{
    public interface IMovement
    {
        Coordinates Move(Direction headDirection, Coordinates currentCoordinates);
    }
}
