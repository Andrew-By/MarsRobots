using MarsRobots.Enums;
using MarsRobots.Interfaces;
using MarsRobots.Models;
using MarsRobots.Models.Commands;
using NUnit.Framework;

namespace MarsRobots.Test
{
    public class Tests
    {
        private Grid _grid;

        [OneTimeSetUp]
        public void Setup()
        {
            _grid = new Grid(5, 3);
        }

        [Test]
        public void Test1()
        {
            IRobot robot = CreateRobot(_grid, new Position(1, 1, Direction.E));
            robot.Run("RFRFRFRF");

            string output = robot.Position.ToString();
            if (robot.IsLost)
                output += " LOST";
            Assert.AreEqual(output, "1 1 E");
        }

        [Test]
        public void Test2()
        {
            IRobot robot = CreateRobot(_grid, new Position(3, 2, Direction.N));
            robot.Run("FRRFLLFFRRFLL");

            string output = robot.Position.ToString();
            if (robot.IsLost)
                output += " LOST";
            Assert.AreEqual(output, "3 3 N LOST");
        }

        [Test]
        public void Test3()
        {
            IRobot robot = CreateRobot(_grid, new Position(0, 3, Direction.W));
            robot.Run("LLFFFLFLFL");

            string output = robot.Position.ToString();
            if (robot.IsLost)
                output += " LOST";
            Assert.AreEqual(output, "2 3 S");
        }

        private IRobot CreateRobot(Grid grid, Position position)
        {
            IRobot robot = new Robot(grid, position);
            robot = new ForwardCommand(robot);
            robot = new LeftCommand(robot);
            robot = new RightCommand(robot);
            return robot;
        }
    }
}