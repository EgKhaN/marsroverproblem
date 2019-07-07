using System.Collections.Generic;

namespace marsrover.console
{
    public class RoverController
    {
        public List<Rover> Rovers { get; set; }
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

    }
}