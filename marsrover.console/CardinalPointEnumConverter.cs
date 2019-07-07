using System.Collections.Generic;

namespace marsrover.console
{
    public class CardinalPointEnumConverter
    {
        private Dictionary<string, CardinalPoints> _string2CardinalPointDict = new Dictionary<string, CardinalPoints>()
        { { "N", CardinalPoints.North }, { "E", CardinalPoints.East }, { "S", CardinalPoints.South }, { "W", CardinalPoints.West }
        };

        public CardinalPoints ToEnum(string p)
        {
            return _string2CardinalPointDict[p];
        }

    }
}