namespace marsrover.console.Commands
{
    public class RoverTurnRightCommand : IRoverActionCommand
    {
        public void Run(Rover rover)
        {
            if (rover.Position.Heading + 1 > CardinalPoints.West)
            {
                rover.Position.Heading = CardinalPoints.North;
            }
            else
            {
                rover.Position.Heading++;
            }
        }
    }
}