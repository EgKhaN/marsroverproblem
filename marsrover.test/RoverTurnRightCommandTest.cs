using marsrover.console;
using marsrover.console.Commands;
using Xunit;

namespace marsrover.test
{
    public class RoverTurnRightCommandTest
    {
        [Theory]
        [InlineData(CardinalPoints.North, CardinalPoints.East)]
        [InlineData(CardinalPoints.East, CardinalPoints.South)]
        [InlineData(CardinalPoints.South, CardinalPoints.West)]
        [InlineData(CardinalPoints.West, CardinalPoints.North)]
        public void CanTurnRightProperly(CardinalPoints inital, CardinalPoints expected)
        {
            var command = new RoverTurnRightCommand();
            var rover = new Rover
            {
                Position = new Position
                {
                Heading = inital
                }
            };

            command.Run(rover);
            Assert.Equal(expected, rover.Position.Heading);
        }
    }
}