using System;
using marsrover.console;
using marsrover.console.Commands;
using Xunit;
namespace marsrover.test
{
    public class RoverCommandParserTest
    {
        [Fact]
        public void GetCommands_L_LeftCommand()
        {
            var parser = new RoverCommandParser()
            {
                Commands = "L"
            };
            var commandList = parser.GetCommands();
            Assert.Equal(commandList.Count, 1);
            Assert.True(commandList[0] is RoverTurnLeftCommand);
        }

        [Fact]
        public void GetCommands_R_RightCommand()
        {
            var parser = new RoverCommandParser()
            {
                Commands = "R"
            };
            var commandList = parser.GetCommands();
            Assert.Equal(commandList.Count, 1);
            Assert.True(commandList[0] is RoverTurnRightCommand);
        }

        [Fact]
        public void GetCommands_M_MoveCommand()
        {
            var parser = new RoverCommandParser()
            {
                Commands = "M"
            };
            var commandList = parser.GetCommands();
            Assert.Equal(commandList.Count, 1);
            Assert.True(commandList[0] is RoverMoveForwardCommand);
        }

        [Fact]
        public void GetCommands_LRM_LeftRightMoveCombinedList()
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
        public void GetPosition_ProperPosition_SameValuePositionObject()
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