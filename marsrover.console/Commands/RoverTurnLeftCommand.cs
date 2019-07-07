namespace marsrover.console.Commands
{
    public class RoverTurnLeftCommand : IRoverActionCommand
    {
        public void Run(Rover rover)
        {
            if (rover.Position.Heading - 1 < CardinalPoints.North)
            {
                rover.Position.Heading = CardinalPoints.West;
            }
            else
            {
                rover.Position.Heading--;
            }
        }
    }
}