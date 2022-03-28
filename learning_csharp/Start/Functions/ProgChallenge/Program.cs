using System;
using System.Text;

namespace ProgChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets begin:");
            string inputStr = "";
            (bool b, int l) result;
            while (inputStr != "exit")
            {
                inputStr = Console.ReadLine();
                if (inputStr != "exit")
                {
                    result = IsPalindrome(inputStr);
                    Console.WriteLine($"Palindrome : {result.b}, Length: {result.l}");
                }
            }

        }

        static (bool b, int l) IsPalindrome(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in str.ToUpper())
            {
                if (Char.IsLetter(ch))
                {
                    sb.Append(ch);
                }
            }

            string testStr = sb.ToString();
            int i = 0, j = testStr.Length - 1;

            while (i <= j)
            {
                if (testStr[i] != testStr[j])
                {
                    return (false, 0);
                }
                i++;
                j--;
            }

            return (true, testStr.Length);
        }
    }
}
