using System.Text;

namespace Oops
{
    internal class BasicCodingQuestion
    {
        public static string Reverse(string inputString)
        {
            string reversedString = string.Empty;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString += inputString[i];
            }

            char[] chars = new char[inputString.Length];
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                chars[inputString.Length - i - 1] = inputString[i];
            }
            string newString = new string(chars);


            StringBuilder sb = new StringBuilder();
            for (int i = inputString.Length - 1; i >= 0; i++)
            {
                sb.Append(inputString[i]);
            }

            Console.WriteLine($"String {reversedString}"); //not recommended for performance
            Console.WriteLine($"Chars {newString}"); // We can use this
            Console.WriteLine($"SB {sb}"); // StringBuilder is the best option for performance

            return reversedString;
        }
    }
}
