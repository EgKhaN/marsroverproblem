using marsrover.console;
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

        private RoverController CreateRoverController()
        {
            var plateau = new Plateau(10, 10);
            var controller = new RoverController(plateau);
            return controller;
        }
    }
}