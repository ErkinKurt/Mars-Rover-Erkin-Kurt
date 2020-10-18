using Mars_Rover.Models;
using Mars_Rover.Models.Movement;
using Mars_Rover.Models.Rotation;
using System;

namespace Mars_Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            int roverNumber = 2;
            Grid grid = CreateGrid();

            for(int i = 0; i < roverNumber; i++)
            {
                try
                {
                    ExecuteRover(grid);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }

        static Grid CreateGrid()
        {
            String gridBorder = Console.ReadLine();
            String[] gridPoints = gridBorder.Split(" ");

            Coordinates gridTopRightCoordinates = new Coordinates(Int32.Parse(gridPoints[0]), Int32.Parse(gridPoints[1]));
            Grid grid = new Grid(new Coordinates(0, 0), gridTopRightCoordinates);

            return grid;
        }

        static void ExecuteRover(Grid grid)
        {
            String startingPosition = Console.ReadLine();
            String[] startingPositionInfo = startingPosition.Split(" ");

            Coordinates startingCoordinates = new Coordinates(Int32.Parse(startingPositionInfo[0]), Int32.Parse(startingPositionInfo[1]));
            Direction startingHeadDirection = (Direction)Enum.Parse(typeof(Direction), startingPositionInfo[2]);

            Rover rover = new Rover(startingCoordinates, startingHeadDirection, grid);
            String commands = Console.ReadLine();

            foreach (char command in commands)
            {
                switch (command.ToString())
                {
                    case MovementType.LeftRotation:
                        rover.Rotate(new LeftRotation());
                        break;
                    case MovementType.RightRotation:
                        rover.Rotate(new RightRotation());
                        break;
                    case MovementType.Forward:
                        rover.Move(new MoveForward());
                        break;
                }
            }
            Console.WriteLine($"{rover.CurrentPosition} {rover.HeadDirection}");
        }
    }
}
