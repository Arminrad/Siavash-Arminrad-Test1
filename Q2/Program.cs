using System;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of \"{num}\" divisors is: {sum}");
        }
    }
}
