using System;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            string palindrome;

            palindrome = Console.ReadLine();

            PalindromeChecker(palindrome);



        }

        public static string Inverter(string input)
        {
            char[] word = input.ToCharArray();
            char[] inverted = new char[input.Length];

            for (var i = 0; i < word.Length; i++)s
            {
                inverted[i] = word[word.Length - i];
            }
            string result = new string(inverted);

            return result;       
        }

        public static void PalindromeChecker(string palindrome)
        {
            if (Inverter(palindrome).Equals(palindrome))
            {
                Console.WriteLine("It is a palindrome");
            }
             else
             {
                Console.WriteLine("It is not a palindrome");
              }
        }

    }
}