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
        public bool IsLost { get; set; }

        public void Run(string cmdLine)
        {
            throw new InvalidOperationException("This robot doesn't support command execution");
        }

        public void DoCommand(char cmd)
        {
            throw new ArgumentException($"Unknown command {cmd}");
        }

        public override string ToString()
        {
            return Position.ToString() + (IsLost ? " LOST" : string.Empty);
        }
    }
}
