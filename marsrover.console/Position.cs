namespace marsrover.console
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CardinalPoints Heading { get; set; }

        public override string ToString()
        {
            //the output 
            var enumConverter = new CardinalPointEnumConverter();
            var strHeading = enumConverter.ToString(Heading);
            return $"{X} {Y} {strHeading}";
        }
    }
}