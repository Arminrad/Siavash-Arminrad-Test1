using System;

namespace Q5
{
    internal class Program
    {
        static int[] studentIds = new int[100];
        static int emptyIndex = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add new student ID\n" +
                    "2.Sort sutdent IDs\n" +
                    "3.Print student IDs\n" +
                    "4.Exit");

                int key = int.Parse(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        Console.WriteLine("Enter new sudent ID: ");
                        int id = int.Parse(Console.ReadLine());
                        AddNewStudentID(id);
                        break;
                    case 2:
                        SortStudentIDs();
                        break;
                    case 3:
                        PrintStudentIDs();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid number!");
                        break;
                };
            }
        }
        public static void AddNewStudentID(int id)
        {
            studentIds[emptyIndex] = id;
            emptyIndex++;
        }

        public static void SortStudentIDs()
        {
            for (int i = 0; i < emptyIndex - 1; i++)
            {
                for (int j = 0; j < emptyIndex - 1; j++)
                {
                    if (studentIds[j] > studentIds[j + 1])
                    {
                        int temp = studentIds[j];
                        studentIds[j] = studentIds[j + 1];
                        studentIds[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintStudentIDs()
        {
            for (int i = 0; i < emptyIndex; i++)
            {
                Console.WriteLine(studentIds[i]);
            }
        }

    }
}
