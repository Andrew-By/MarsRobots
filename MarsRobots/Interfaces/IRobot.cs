using MarsRobots.Enums;
using MarsRobots.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRobots.Interfaces
{
    public interface IRobot
    {
        Grid Grid { get; }
        Position Position { get; }
        bool IsLost { get; set; }

        void Run(string cmdLine);
        void DoCommand(char cmd);
    }
}
