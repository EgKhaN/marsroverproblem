using System;
using marsrover.console;
using marsrover.console.Commands;
using Xunit;
namespace marsrover.test
{
    public class RoverCommandParserTest
    {
        [Fact]
        public void GetCommandsTest()
        {
            var parser = new RoverCommandParser()
            {
                Commands = "LRM"
            };
            var commandList = parser.GetCommands();
            Assert.Equal(commandList.Count, 3);
            Assert.True(commandList[0] is RoverTurnLeftCommand);
            Assert.True(commandList[1] is RoverTurnRightCommand);
            Assert.True(commandList[2] is RoverMoveForwardCommand);
        }

        [Fact]
        public void GetPositionTest()
        {
            var parser = new RoverCommandParser()
            {
                RoverPosition = "12 11 E"
            };

            var position = parser.GetPosition();
            Assert.Equal(position.X, 12);
            Assert.Equal(position.Y, 11);
            Assert.Equal(position.Heading, CardinalPoints.East);
        }
    }
}