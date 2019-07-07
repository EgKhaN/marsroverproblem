using System;

namespace marsrover.console
{
    public class RoverPositionParser
    {
        public string RoverPosition { get; set; }

        public RoverPositionParser(string roverPosition)
        {
            RoverPosition = roverPosition;
        }

        public Position GetPosition()
        {
            // Example position: 5 5 E
            var arrPosition = RoverPosition.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var x = Convert.ToInt32(arrPosition[0]);
            var y = Convert.ToInt32(arrPosition[1]);
            var heading = ParseCardinalPoint(arrPosition[2]);
            var position = new Position()
            {
                X = x,
                Y = y,
                Heading = heading
            };
            return position;
        }

        private CardinalPoints ParseCardinalPoint(string v)
        {
            var cardinalPointConverter = new CardinalPointEnumConverter();
            return cardinalPointConverter.ToEnum(v);
        }
    }
}