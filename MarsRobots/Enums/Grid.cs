using MarsRobots.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MarsRobots.Enums
{
    public class Grid
    {
        public Grid(int width, int height)
        {
            Size = new Size(width, height);
        }

        public Size Size { get; }

        public List<Position> Scents { get; } = new List<Position>();

        public bool IsPositionValid(Position position)
        {
            return
                position.X >= 0 && position.X <= Size.Width &&
                position.Y >= 0 && position.Y <= Size.Height;
        }

        public bool HasScent(Position coordinates) => Scents.Any(s => s.X == coordinates.X && s.Y == coordinates.Y);

        public void ReportScent(Position position) => Scents.Add(position);
    }
}
