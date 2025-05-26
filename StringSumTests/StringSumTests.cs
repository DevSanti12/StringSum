using StringSumLibrary;
using Xunit;

namespace StringSumTests
{
    public class StringSumTests
    {
        [Fact]
        public void StringSum_EmptyStrings_ReturnsZero()
        {
            var result = StringSumUtility.StringSum("", "");
            Assert.Equal("0", result);
        }

        [Fact]
        public void StringSum_SmallNumbers_ReturnsSum()
        {
            var result = StringSumUtility.StringSum("2", "3");
            Assert.Equal("5", result);
        }

        [Fact]
        public void StringSum_InvalidInputs()
        {
            var result = StringSumUtility.StringSum("abc", "5");
            Assert.Equal("5", result);
        }

        [Fact]
        public void StringSum_ZeroAndLargeNumbers_CorrectSumReturned()
        {
            var result = StringSumUtility.StringSum("0", "5000");
            Assert.Equal("5000", result);
        }

        [Fact]
        public void StringSum_NullInput_ReturnsNullException()
        {
            string num1 = null;
            string num2 = null;
            Assert.Throws<ArgumentNullException>(() => StringSumUtility.StringSum(num1, num2));
        }
    }
}