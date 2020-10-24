using MarsRobots.Enums;
using MarsRobots.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MarsRobots.Models
{
    public class Robot : IRobot
    {
        public Robot(Grid grid, Position position)
        {
            Grid = grid;
            Position = position;
        }

        public Grid Grid { get; }
        public Position Position { get; }
        public bool IsLost { get; protected set; }

        public void Run(string cmdLine)
        {
        }

        public void DoCommand(char cmd)
        {
            throw new ArgumentException();
        }
    }
}
