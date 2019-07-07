using marsrover.console;
using marsrover.console.Commands;
using Xunit;

namespace marsrover.test
{
    public class RoverMoveForwardCommandTest
    {
        [Theory]
        [InlineData(5, 5, 5, 6, CardinalPoints.North)]
        [InlineData(5, 5, 6, 5, CardinalPoints.East)]
        [InlineData(5, 5, 5, 4, CardinalPoints.South)]
        [InlineData(5, 5, 4, 5, CardinalPoints.West)]
        public void CanMoveForwardMoveProperly(int initalX, int initalY, int expectedX, int expectedY, CardinalPoints heading)
        {
            var command = new RoverMoveForwardCommand();
            var position = new Position
            {
                X = initalX,
                Y = initalY,
                Heading = heading
            };
            var rover = new Rover
            {
                Position = position
            };

            command.Run(rover);
            Assert.Equal(heading, rover.Position.Heading);
            Assert.Equal(expectedX, rover.Position.X);
            Assert.Equal(expectedY, rover.Position.Y);
        }
    }
}