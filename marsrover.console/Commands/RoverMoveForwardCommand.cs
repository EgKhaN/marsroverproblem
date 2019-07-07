using System.Collections.Generic;

namespace marsrover.console.Commands
{
    public class RoverMoveForwardCommand : IRoverActionCommand
    {
        Dictionary<CardinalPoints, Coordinate> _moveOffsets = new Dictionary<CardinalPoints, Coordinate>()
        { { CardinalPoints.North, new Coordinate(0, 1) }, { CardinalPoints.East, new Coordinate(1, 0) }, { CardinalPoints.South, new Coordinate(0, -1) }, { CardinalPoints.West, new Coordinate(-1, 0) }
        };

        public void Run(Rover rover)
        {
            // get precalculated offsets for each cardinal point and 
            // add it to the rover's current position
            var offsetCoordinate = _moveOffsets[rover.Position.Heading];
            rover.Position.X += offsetCoordinate.X;
            rover.Position.Y += offsetCoordinate.Y;
        }

        private class Coordinate
        {
            public int X { get; private set; }
            public int Y { get; private set; }
            public Coordinate(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}