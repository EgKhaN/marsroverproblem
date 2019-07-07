namespace marsrover.console
{
    public class RoverControlAdapter
    {
        public RoverController Controller { get; private set; }
        public void ProcessInput(string[] input)
        {
            var inputParser = new InputParser(input);
            inputParser.Parse();

            var plateau = new Plateau(inputParser.PlateauWidth, inputParser.PlateauHeight);
            Controller = new RoverController(plateau);

            foreach (var roverInputModel in inputParser.Rovers)
            {
                var deployedRover = Controller.DeployRover(roverInputModel.DeployPosition);
                Controller.RunRoverCommans(deployedRover, roverInputModel.Commands);
            }
        }
    }
}