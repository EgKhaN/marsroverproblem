using System.Collections.Generic;
using marsrover.console.Commands;

namespace marsrover.console
{
    public class RoverController
    {
        public List<Rover> Rovers { get; set; } = new List<Rover>();
        public Plateau Plateau { get; private set; }
        public RoverController(Plateau plateu)
        {
            Plateau = plateu;
        }

        public Rover DeployRover(Position roverPosition)
        {
            var rover = new Rover
            {
                Position = roverPosition
            };
            Rovers.Add(rover);
            return rover;
        }

        public void RunRoverCommans(Rover rover, List<IRoverActionCommand> commands)
        {
            foreach (var command in commands)
            {
                RunRoverCommand(rover, command);
            }
        }

        private void RunRoverCommand(Rover rover, IRoverActionCommand command)
        {
            command.Run(rover);
        }
    }
}