using System;
using System.Collections.Generic;

namespace marsrover.console.Commands
{
    public class RoverCommandParser
    {
        public string Commands { get; set; }
        public string RoverPosition { get; set; }

        public RoverCommandParser() { }

        public RoverCommandParser(string roverPosition, string commands)
        {
            Commands = commands;
            RoverPosition = roverPosition;
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

        public Position GetPosition()
        {
            var arrPosition = RoverPosition.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var x = Convert.ToInt32(arrPosition[0]);
            var y = Convert.ToInt32(arrPosition[1]);
            var heading = ParseCardinalPoint(arrPosition[2]);
            var position = new Position()
            {
                X = x,
                Y = y,
                Heading = heading
            };
            return position;
        }

        private CardinalPoints ParseCardinalPoint(string v)
        {
            var cardinalPointConverter = new CardinalPointEnumConverter();
            return cardinalPointConverter.ToEnum(v);
        }
    }
}