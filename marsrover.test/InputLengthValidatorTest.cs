using marsrover.console;
using Xunit;

namespace marsrover.test
{
    public class InputLengthValidatorTest
    {
        [Fact]
        public void Validate_3Items_true()
        {
            var validator = new InputLengthValidator();
            var input = new string[] { "1", "2", "3" };
            var actual = validator.Validate(input);
            Assert.True(actual);
        }

        [Fact]
        public void Validate_5Items_true()
        {
            var validator = new InputLengthValidator();
            var input = new string[] { "1", "2", "3", "4", "5" };
            var actual = validator.Validate(input);
            Assert.True(actual);
        }

        [Fact]
        public void Validate_2Items_false()
        {
            var validator = new InputLengthValidator();
            var input = new string[] { "1", "2" };
            var actual = validator.Validate(input);
            Assert.False(actual);
        }

        [Fact]
        public void Validate_4Items_true()
        {
            var validator = new InputLengthValidator();
            var input = new string[] { "1", "2", "3", "4", };
            var actual = validator.Validate(input);
            Assert.False(actual);
        }

    }
}