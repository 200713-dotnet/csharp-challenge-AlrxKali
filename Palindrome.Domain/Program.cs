using System;git 

namespace Palindrome
{
    class Program
    {
        static void Main()
        {   
            //This program convert the string to integer
            //Store in a temp variable 
            // Then it inverts the input
            // If temp and input are equal it prints that it is a palindrome
            int input;
            int r;
            int sum = 0; 
            int temp;

            Console.Write("Enter the Number: ");
            input = int.Parse(Console.ReadLine());
            temp = input;
            while (input > 0)
            {
                r = input % 10;
                sum = (sum * 10) + r;
                input = input / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
    }
}