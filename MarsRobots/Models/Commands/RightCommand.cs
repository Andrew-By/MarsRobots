using MarsRobots.Enums;
using MarsRobots.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRobots.Models.Commands
{
    public class RightCommand : CommandBase
    {
        public RightCommand(IRobot robot) : base(robot)
        {
        }

        public override void DoCommand(char cmd)
        {
            if (cmd != 'R')
                base.DoCommand(cmd);
            else
            {
                if (Position.Direction >= Direction.W)
                    Position.Direction = Direction.N;
                else
                    Position.Direction++;
            }
        }
    }
}
