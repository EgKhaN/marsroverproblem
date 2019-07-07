using marsrover.console;
using marsrover.console.Commands;

namespace marsrover.test
{
    public class MockRoverActionCommand : IRoverActionCommand
    {
        public int RunCount { get; set; }
        public void Run(Rover rover)
        {
            RunCount++;
        }
    }
}