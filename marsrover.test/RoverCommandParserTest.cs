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
            Assert.Single(commandList);
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
            Assert.Single(commandList);
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
            Assert.Single(commandList);
            Assert.True(commandList[0] is RoverMoveForwardCommand);
        }

        [Fact]
        public void GetCommands_LRM_LeftRightMoveCombinedList()
        {
            var parser = new RoverCommandParser("LRM");
            var commandList = parser.GetCommands();
            Assert.Equal(3, commandList.Count);
            Assert.True(commandList[0] is RoverTurnLeftCommand);
            Assert.True(commandList[1] is RoverTurnRightCommand);
            Assert.True(commandList[2] is RoverMoveForwardCommand);
        }

    }
}