using System.Text;

namespace Oops
{
    internal class BasicCodingQuestion
    {
        public static string Reverse(string inputString)
        {
            //Way 1: Using a for loop to reverse the string
            string reversedString = string.Empty;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString += inputString[i];
            }

            //Way 2: Using a char array to reverse the string
            char[] chars = new char[inputString.Length];
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                chars[inputString.Length - i - 1] = inputString[i];
            }
            string newString = new string(chars);

            //Way 3: Using StringBuilder to reverse the string
            StringBuilder sb = new StringBuilder();
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                sb.Append(inputString[i]);
            }

            Console.WriteLine($"String {reversedString}"); //not recommended for performance
            Console.WriteLine($"Chars {newString}"); // We can use this
            Console.WriteLine($"SB {sb}"); // StringBuilder is the best option for performance

            return reversedString;
        }

        public static void CheckPalindrome(string inputString)
        {
            int l = 0;
            int r = inputString.Length-1;
            bool flag = false;
            inputString = inputString.ToLower();
            while(l <= r)
            {
                if (!inputString[l].Equals(inputString[r]))
                {
                    flag = true;
                    break;
                }
                l++;r--;
            }

            if (flag)
            {
                Console.WriteLine("String is not Palindrome");
            }
            else
            {
                Console.WriteLine("String is Palindrome");
            }
        }
    }
}
