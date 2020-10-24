using MarsRobots.Enums;
using MarsRobots.Interfaces;
using MarsRobots.Models;
using MarsRobots.Models.Commands;
using System;

namespace MarsRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            var gridString = Console.ReadLine();
            var gridSize = gridString.Split(' ');
            var grid = new Grid(int.Parse(gridSize[0]), int.Parse(gridSize[1]));

            var rPositionString = Console.ReadLine();
            while (!string.IsNullOrEmpty(rPositionString))
            {
                var rPosition = rPositionString.Split(' ');
                IRobot robot = new Robot(grid, new Position(int.Parse(rPosition[0]), int.Parse(rPosition[1]), Enum.Parse<Direction>(rPosition[2])));
                robot = new ForwardCommand(robot);
                robot = new LeftCommand(robot);
                robot = new RightCommand(robot);

                robot.Run(Console.ReadLine());
                Console.WriteLine(robot);

                rPositionString = Console.ReadLine();
            }
        }
    }
}
