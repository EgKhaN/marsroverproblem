using marsrover.console;
using marsrover.console.Commands;
using Xunit;

namespace marsrover.test
{
    public class RoverPositionParserTest
    {
        [Fact]
        public void GetPosition_ProperPosition_SameValuePositionObject()
        {
            var parser = new RoverPositionParser("12 11 E");
            var position = parser.GetPosition();

            Assert.Equal(12, position.X);
            Assert.Equal(11, position.Y);
            Assert.Equal(CardinalPoints.East, position.Heading);
        }
    }
}