using System.Collections.Generic;
using marsrover.console;
using marsrover.console.Commands;
using Xunit;

namespace marsrover.test
{
    public class RoverControllerTest
    {

        [Fact]
        public void DeployRover_Position_SamePosition()
        {
            var controller = CreateRoverController();
            var position = new Position()
            {
                X = 1,
                Y = 1,
                Heading = CardinalPoints.North
            };
            var rover = controller.DeployRover(position);
            Assert.Equal(position.X, rover.Position.X);
            Assert.Equal(position.Y, rover.Position.Y);
            Assert.Equal(position.Heading, rover.Position.Heading);
        }

        [Fact]
        public void DeployRover_Position_AddedToList()
        {
            var controller = CreateRoverController();
            var position = new Position()
            {
                X = 1,
                Y = 1,
                Heading = CardinalPoints.North
            };
            var rover = controller.DeployRover(position);
            Assert.Single(controller.Rovers);
            Assert.Same(rover, controller.Rovers[0]);
        }

        [Fact]
        public void RunRoverCommands_Command_ShouldRun()
        {
            var controller = CreateRoverController();
            var commandList = new List<IRoverActionCommand>()
            {
                new MockRoverActionCommand(), new MockRoverActionCommand()
            };
            var rover = controller.DeployRover(new Position { X = 10, Y = 10, Heading = CardinalPoints.North });
            controller.RunRoverCommans(rover, commandList);
            Assert.Equal(1, ((MockRoverActionCommand) commandList[0]).RunCount);
            Assert.Equal(1, ((MockRoverActionCommand) commandList[1]).RunCount);
        }

        private RoverController CreateRoverController()
        {
            var plateau = new Plateau(10, 10);
            var controller = new RoverController(plateau);
            return controller;
        }
    }
}