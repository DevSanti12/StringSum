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
    }
}