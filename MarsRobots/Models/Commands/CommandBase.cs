using MarsRobots.Enums;
using MarsRobots.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRobots.Models.Commands
{
    public abstract class CommandBase : IRobot
    {
        private readonly IRobot _robot;

        public CommandBase(IRobot robot)
        {
            _robot = robot;
        }

        public Grid Grid => _robot.Grid;
        public Position Position => _robot.Position;

        public virtual bool IsLost => _robot.IsLost;

        public void Run(string cmdLine)
        {
            foreach (var cmd in cmdLine)
            {
                DoCommand(cmd);
                if (IsLost)
                    break;
            }
        }

        public virtual void DoCommand(char cmd)
        {
            _robot.DoCommand(cmd);
        }
    }
}
