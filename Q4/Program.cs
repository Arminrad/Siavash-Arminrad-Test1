using System;

namespace Q4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int spaceCounter = 2, i, j , k;

            for (i = 1; i <= 5; i += 2)
            {
                for (k = 1; k <= spaceCounter; k++)
                {
                    Console.Write(" ");
                }
                spaceCounter--;

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            spaceCounter++;
            for (i = 5; i >= 1; i -= 2)
            {
                for (k = 1; k <= spaceCounter; k++)
                {
                    Console.Write(" ");
                }
                spaceCounter++;

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            spaceCounter = 5;
            for (i = 1; i <= 4; i++)
            {
                for(k = 1; k <= spaceCounter; k++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            spaceCounter = 12;
            for (i = 5; i >= 1; i--)
            {
                for (k = 1; k <= spaceCounter; k++)
                {
                    Console.Write(" ");
                }
                spaceCounter++;

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            spaceCounter = 20;
            for (i = 1; i <= 5; i += 2)
            {
                for (k = 1; k <= spaceCounter; k++)
                {
                    Console.Write(" ");
                }
                spaceCounter--;

                for (j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }


            spaceCounter = 25;
            for (i = 7; i >= 1; i -= 2)
            {
                for (k = 1; k <= spaceCounter; k++)
                {
                    Console.Write(" ");
                }
                spaceCounter++;

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            spaceCounter = 32;
            for (i = 1; i <= 4; i++)
            {
                for (k = 1; k <= spaceCounter; k++)
                {
                    Console.Write(" ");
                }
                spaceCounter--;

                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
