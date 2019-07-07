using System.Collections.Generic;

namespace marsrover.console
{
    public class CardinalPointEnumConverter
    {
        private Dictionary<string, CardinalPoints> _string2CardinalPointDict = new Dictionary<string, CardinalPoints>()
        { { "N", CardinalPoints.North }, { "E", CardinalPoints.East }, { "S", CardinalPoints.South }, { "W", CardinalPoints.West }
        };
        private Dictionary<CardinalPoints, string> _cardinalPoint2StringDict = new Dictionary<CardinalPoints, string>()
        { { CardinalPoints.North, "N" }, { CardinalPoints.East, "E" }, { CardinalPoints.South, "S" }, { CardinalPoints.West, "W" }
        };

        public CardinalPoints ToEnum(string p)
        {
            return _string2CardinalPointDict[p];
        }
        public string ToString(CardinalPoints p)
        {
            return _cardinalPoint2StringDict[p];
        }

    }
}