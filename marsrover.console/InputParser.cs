using System;
using System.Collections.Generic;

namespace marsrover.console
{
    public class InputParser
    {
        public int PlateauHeight { get; set; }
        public int PlateauWidth { get; set; }

        public List<RoverInputModel> Rovers { get; set; } = new List<RoverInputModel>();
        private readonly string[] _input;

        public InputParser(string[] input)
        {
            _input = input;
        }

        public void Parse()
        {
            ParsePlateauSize();
            ParseRoverData();
        }

        private void ParseRoverData()
        {
            for (int i = 1; i < _input.Length; i += 2)
            {
                var strPosition = _input[i];
                var strCommands = _input[i + 1];
                var positionParser = new RoverPositionParser(strPosition);
                var commandParser = new Commands.RoverCommandParser(strCommands);
                var roverInputModel = new RoverInputModel
                {
                    DeployPosition = positionParser.GetPosition(),
                    Commands = commandParser.GetCommands()
                };
                Rovers.Add(roverInputModel);
            }
        }

        private void ParsePlateauSize()
        {
            var strPlateauSize = _input[0];
            var arrPlateauSize = strPlateauSize.Split(' ');
            PlateauWidth = Convert.ToInt32(arrPlateauSize[0]);
            PlateauHeight = Convert.ToInt32(arrPlateauSize[1]);
        }
    }
}