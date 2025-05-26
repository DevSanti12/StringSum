
namespace StringSumLibrary
{
    public static class StringSumUtility
    {
        public static string StringSum(string number1, string number2)
        {
            if(number1 == null || number2 == null)
            {
                throw new ArgumentNullException();
            }
            int TryParseOrZero(string input)
            {
                return int.TryParse(input, out var result) ? result : 0;
            }

            int num1 = TryParseOrZero(number1);
            int num2 = TryParseOrZero(number2);

            return (num1 + num2).ToString();

        }
    }
}
