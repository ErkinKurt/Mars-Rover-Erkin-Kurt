using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mars_Rover.Models;
using Mars_Rover.Models.Rotation;
using Mars_Rover.Models.Movement;

namespace MarsRoverTests
{
    [TestClass]
    public class MoveForwardTests
    {
        [TestMethod]
        public void Move_WhenDirectionIsN_ShouldIncrementY()
        {
            Coordinates initialCoordinates = new Coordinates(0, 0);
            Coordinates expectedCoordinates = new Coordinates(0, 1);
            Direction direction = Direction.N;
            IMovement movement = new MoveForward();

            Coordinates actual = movement.Move(direction, initialCoordinates);

            Assert.AreEqual(actual, expectedCoordinates);
        }

        [TestMethod]
        public void Move_WhenDirectionIsS_ShouldDecrementY()
        {
            Coordinates initialCoordinates = new Coordinates(0, 1);
            Coordinates expectedCoordinates = new Coordinates(0, 0);
            Direction direction = Direction.S;
            IMovement movement = new MoveForward();

            Coordinates actual = movement.Move(direction, initialCoordinates);

            Assert.AreEqual(actual, expectedCoordinates);
        }

        [TestMethod]
        public void Move_WhenDirectionIsW_ShouldDecrementX()
        {
            Coordinates initialCoordinates = new Coordinates(1, 1);
            Coordinates expectedCoordinates = new Coordinates(0, 1);
            Direction direction = Direction.W;
            IMovement movement = new MoveForward();

            Coordinates actual = movement.Move(direction, initialCoordinates);

            Assert.AreEqual(actual, expectedCoordinates);
        }

        [TestMethod]
        public void Move_WhenDirectionIsE_ShouldIncrementX()
        {
            Coordinates initialCoordinates = new Coordinates(1, 1);
            Coordinates expectedCoordinates = new Coordinates(2, 1);
            Direction direction = Direction.E;
            IMovement movement = new MoveForward();

            Coordinates actual = movement.Move(direction, initialCoordinates);

            Assert.AreEqual(actual, expectedCoordinates);
        }
    }
}
