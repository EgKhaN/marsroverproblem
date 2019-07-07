namespace marsrover.console.Commands
{
    public class RoverTurnRightCommand : IRoverActionCommand
    {
        public void Run(Rover rover)
        {
            // fallback to north in case of the left of west
            // otherwise increase to turn right
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