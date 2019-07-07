namespace marsrover.console
{
    /// <summary>
    /// Example input
    /// 5 5
    /// 1 2 N
    /// LMLMLMLMM
    ///
    /// -minimum input is 3 lines
    /// * 1 line plateau size
    /// * 1 line rover deploy position
    /// * 1 line commands
    /// 
    /// - input length should be always odd
    /// * 1 line for plateau
    /// * 2 linesfor each rover
    /// </summary>
    public class InputLengthValidator
    {
        public bool Validate(string[] input)
        {
            if (input.Length < 3 || input.Length % 2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}