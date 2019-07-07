using marsrover.console;
using marsrover.console.Commands;
using Xunit;

namespace marsrover.test
{
    public class RoverTurnLeftCommandTest
    {
        [Theory]
        [InlineData(CardinalPoints.North, CardinalPoints.West)]
        [InlineData(CardinalPoints.West, CardinalPoints.South)]
        [InlineData(CardinalPoints.South, CardinalPoints.East)]
        [InlineData(CardinalPoints.East, CardinalPoints.North)]
        public void CanTurnLeftProperly(CardinalPoints inital, CardinalPoints expected)
        {
            var command = new RoverTurnLeftCommand();
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