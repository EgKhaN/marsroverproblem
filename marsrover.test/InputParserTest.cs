using marsrover.console;
using marsrover.console.Commands;
using Xunit;

namespace marsrover.test
{
    public class InputParserTest
    {
        [Fact]
        public void Parse_ExampleInput_ProperPlateauSize()
        {
            var exampleInput = GetExampleInput();
            var parser = new InputParser(exampleInput);
            parser.Parse();

            Assert.Equal(1, parser.PlateauWidth);
            Assert.Equal(5, parser.PlateauHeight);
        }

        [Fact]
        public void Parse_ExampleInput_ProperPoverList()
        {
            var exampleInput = GetExampleInput();
            var parser = new InputParser(exampleInput);
            parser.Parse();

            Assert.Equal(2, parser.Rovers.Count);

            Assert.Equal(1, parser.Rovers[0].DeployPosition.X);
            Assert.True(parser.Rovers[0].Commands[0] is RoverTurnLeftCommand);

            Assert.Equal(3, parser.Rovers[1].DeployPosition.X);
            Assert.True(parser.Rovers[1].Commands[0] is RoverMoveForwardCommand);
        }
        private string[] GetExampleInput()
        {
            return new string[]
            {
                "1 5",
                "1 2 N",
                "LMLMLMLMM",
                "3 3 E",
                "MMRMMRMRRM"
            };
        }
    }
}