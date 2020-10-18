using Mars_Rover.Models.Movement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_Rover.Models
{
    interface IMovable
    {
        void Rotate(IRotation rotation);

        void Move(IMovement movement);
    }
}
