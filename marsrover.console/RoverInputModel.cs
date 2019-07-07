using System.Collections.Generic;
using marsrover.console.Commands;

namespace marsrover.console
{
    public class RoverInputModel
    {
        public Position DeployPosition { get; set; }
        public List<IRoverActionCommand> Commands { get; set; }
    }
}