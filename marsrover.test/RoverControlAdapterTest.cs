using System;
using System.Linq;
using marsrover.console;
using Xunit;
namespace marsrover.test
{
    public class RoverControlAdapterTest
    {
        [Fact]
        public void ProcessInput_ProperInput_ProperOutput()
        {
            var input = GetProperInput();
            var expected = new string[]
            {
                "1 3 N",
                "5 1 E"
            };
            var adapter = new RoverControlAdapter();
            adapter.ProcessInput(input);
            var actual = adapter.Controller.Rovers.Select(x => x.Position.ToString()).ToArray();

            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[1], actual[1]);
        }

        private string[] GetProperInput()
        {
            return new string[]
            {
                "5 5",
                "1 2 N",
                "LMLMLMLMM",
                "3 3 E",
                "MMRMMRMRRM"
            };
        }
    }
}