using System;
using System.IO;

namespace marsrover.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(args[0]);

            ValidateInputLength(input);

            var adapter = new RoverControlAdapter();
            adapter.ProcessInput(input);

            foreach (var rover in adapter.Controller.Rovers)
            {
                Console.WriteLine(rover.Position);
            }
        }

        private static void ValidateInputLength(string[] input)
        {
            var validator = new InputLengthValidator();
            var isValid = validator.Validate(input);
            if (!isValid)
            {
                throw new Exception("Invalid input");
            }
        }
    }
}