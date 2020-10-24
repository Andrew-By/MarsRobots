using MarsRobots.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRobots.Models
{
    public class Position
    {
        public Position()
        {
        }

        public Position(Position coordinates) => UpdatePosition(coordinates);

        public Position(int x, int y, Direction dir)
        {
            X = x;
            Y = y;
            Direction = dir;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public void UpdatePosition(Position coordinates)
        {
            X = coordinates.X;
            Y = coordinates.Y;
            Direction = coordinates.Direction;
        }

        public override string ToString()
        {
            return $"{X} {Y} {Direction}";
        }
    }
}
