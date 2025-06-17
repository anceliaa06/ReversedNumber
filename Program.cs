using System;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = reversedNum * 10 + digit;
                num /= 10;
            }

            Console.WriteLine($"Reverse is: {reversedNum}");
        }
    }
}
