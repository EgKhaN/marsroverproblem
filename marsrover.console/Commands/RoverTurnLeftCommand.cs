namespace marsrover.console.Commands
{
    public class RoverTurnLeftCommand : IRoverActionCommand
    {
        public void Run(Rover rover)
        {
            // fallback to west in case of the left of north
            // otherfise decrease to turn left
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