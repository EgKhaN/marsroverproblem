using marsrover.console;
using Xunit;

namespace marsrover.test
{
    public class CardinalPointEnumConverterTest
    {
        [Theory]
        [InlineData("N", CardinalPoints.North)]
        [InlineData("E", CardinalPoints.East)]
        [InlineData("S", CardinalPoints.South)]
        [InlineData("W", CardinalPoints.West)]
        public void CanConvertStringToEnum(string inital, CardinalPoints expected)
        {
            var converter = new CardinalPointEnumConverter();
            var actual = converter.ToEnum(inital);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(CardinalPoints.North, "N")]
        [InlineData(CardinalPoints.East, "E")]
        [InlineData(CardinalPoints.South, "S")]
        [InlineData(CardinalPoints.West, "W")]
        public void CanConvertEnumToString(CardinalPoints inital, string expected)
        {
            var converter = new CardinalPointEnumConverter();
            var actual = converter.ToString(inital);
            Assert.Equal(expected, actual);
        }
    }
}