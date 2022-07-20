using System;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers from 2 to 100 are: ");
            EvenNum2to100(2);
        }

        public static void EvenNum2to100(int n)
        {
            if (n <= 100)
            {
                Console.WriteLine(n);
                EvenNum2to100(n + 2);
            }
        }
    }
}
