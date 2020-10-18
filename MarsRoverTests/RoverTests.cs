using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mars_Rover.Models;
using Mars_Rover.Models.Rotation;
using Mars_Rover.Models.Movement;
using System;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void Rotate_WhenRotationisLeft_ShouldUpdateHeadToPreceding()
        {
            Coordinates initialCoordinates = new Coordinates(0, 0);
            Direction headDirection = Direction.N;
            Grid grid = new Grid(new Coordinates(0, 0), new Coordinates(5, 5));
            Direction expectedDirection = Direction.W;
            Rover rover = new Rover(initialCoordinates, headDirection, grid);
            IRotation leftRotation = new LeftRotation();

            rover.Rotate(leftRotation);

            Assert.AreEqual(expectedDirection, rover.HeadDirection);
        }

        [TestMethod]
        public void Rotate_WhenRotationisLeft_ShouldNotUpdateHeadToSucceeding()
        {
            Coordinates initialCoordinates = new Coordinates(0, 0);
            Direction headDirection = Direction.N;
            Direction expectedDirection = Direction.E;
            Grid grid = new Grid(new Coordinates(0, 0), new Coordinates(5, 5));
            Rover rover = new Rover(initialCoordinates, headDirection, grid);
            IRotation leftRotation = new LeftRotation();

            rover.Rotate(leftRotation);

            Assert.AreNotEqual(expectedDirection, rover.HeadDirection);
        }

        [TestMethod]
        public void Rotate_WhenRotationisRight_ShouldUpdateHeadToSucceeding()
        {
            Coordinates initialCoordinates = new Coordinates(0, 0);
            Direction headDirection = Direction.N;
            Direction expectedDirection = Direction.E;
            Grid grid = new Grid(new Coordinates(0, 0), new Coordinates(5, 5));
            Rover rover = new Rover(initialCoordinates, headDirection, grid);
            IRotation rightRotation = new RightRotation();

            rover.Rotate(rightRotation);

            Assert.AreEqual(expectedDirection, rover.HeadDirection);
        }

        [TestMethod]
        public void Rotate_WhenRotationisRight_ShouldNotUpdateHeadToPreceding()
        {
            Coordinates initialCoordinates = new Coordinates(0, 0);
            Direction headDirection = Direction.N;
            Direction expectedDirection = Direction.W;
            Grid grid = new Grid(new Coordinates(0, 0), new Coordinates(5, 5));
            Rover rover = new Rover(initialCoordinates, headDirection, grid);
            IRotation rightRotation = new RightRotation();

            rover.Rotate(rightRotation);

            Assert.AreNotEqual(expectedDirection, rover.HeadDirection);
        }

        [TestMethod]
        public void Move_WhenMovementIsOutsideOfGrid_ShouldThrowException()
        {
            Coordinates initialCoordinates = new Coordinates(5, 5);
            Direction headDirection = Direction.N;
            Grid grid = new Grid(new Coordinates(0, 0), new Coordinates(5, 5));
            IMovement moveForward = new MoveForward();
            Rover rover = new Rover(initialCoordinates, headDirection, grid);

            try
            {
                rover.Move(moveForward);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, Rover.OutOfBoundsMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
