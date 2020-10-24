using MarsRobots.Enums;
using MarsRobots.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRobots.Models.Commands
{
    public class ForwardCommand : CommandBase
    {
        private bool _isLost;

        public ForwardCommand(IRobot robot) : base(robot)
        {
        }

        public override bool IsLost => _isLost;

        public override void DoCommand(char cmd)
        {
            if (cmd != 'F')
                base.DoCommand(cmd);
            else
            {
                var newCoords = new Position(Position);
                switch (Position.Direction)
                {
                    case Direction.N:
                        newCoords.Y++;
                        break;
                    case Direction.E:
                        newCoords.X++;
                        break;
                    case Direction.S:
                        newCoords.Y--;
                        break;
                    case Direction.W:
                        newCoords.X--;
                        break;
                }
                if (Grid.IsPositionValid(newCoords))
                {
                    Position.UpdatePosition(newCoords);
                }
                else
                {
                    if (!Grid.HasScent(Position))
                    {
                        _isLost = true;
                        Grid.ReportScent(Position);
                    }
                }
            }
        }
    }
}
