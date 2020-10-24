using MarsRobots.Enums;
using MarsRobots.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRobots.Models.Commands
{
    public class LeftCommand : CommandBase
    {
        public LeftCommand(IRobot robot) : base(robot)
        {
        }

        public override void DoCommand(char cmd)
        {
            if (cmd != 'L')
                base.DoCommand(cmd);
            else
            {
                if (Position.Direction <= Direction.N)
                    Position.Direction = Direction.W;
                else
                    Position.Direction--;
            }
        }
    }
}
