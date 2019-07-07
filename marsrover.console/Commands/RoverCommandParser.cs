using System;
using System.Collections.Generic;

namespace marsrover.console.Commands
{
    public class RoverCommandParser
    {
        public string Commands { get; set; }

        public RoverCommandParser() { }

        public RoverCommandParser(string commands)
        {
            Commands = commands;
        }

        public List<IRoverActionCommand> GetCommands()
        {
            var commandList = new List<IRoverActionCommand>();
            foreach (var commandIdentifier in Commands)
            {
                switch (commandIdentifier)
                {
                    case 'L':
                        commandList.Add(new RoverTurnLeftCommand());
                        break;
                    case 'R':
                        commandList.Add(new RoverTurnRightCommand());
                        break;
                    case 'M':
                        commandList.Add(new RoverMoveForwardCommand());
                        break;
                }
            }
            return commandList;
        }

    }
}