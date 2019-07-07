using marsrover.console;
using Xunit;

namespace marsrover.test
{
    public class PositionTest
    {
        [Theory]
        [InlineData(13, 144, CardinalPoints.North, "13 144 N")]
        [InlineData(45, 56, CardinalPoints.East, "45 56 E")]
        [InlineData(3, 1, CardinalPoints.South, "3 1 S")]
        [InlineData(7, 2, CardinalPoints.West, "7 2 W")]
        public void CanToStringReturnProperString(int initalX, int initalY, CardinalPoints initalHeading, string expected)
        {
            var position = new Position
            {
                X = initalX,
                Y = initalY,
                Heading = initalHeading
            };
            var actual = position.ToString();
            Assert.Equal(expected, actual);
        }
    }
}