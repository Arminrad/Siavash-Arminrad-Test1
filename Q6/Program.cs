using System;

namespace Q6
{
    public class Program
    {
        public struct Book
        {
            public string Title { get; set; }
            public string Writer { get; set; }
            public string ISBN { get; set; }
            public Boolean isDelete { get; set; }

            public override string ToString()
            {
                return "Book Title: " + this.Title + " Book Writer: " + this.Writer + " Book ISBN: " + this.ISBN;
            }
        }

        static Book[] books;
        static int emptyIndex = 0;
        static int size = 0;



        static void Main(string[] args)
        {
            Console.WriteLine("How many books does your library have? ");
            size = int.Parse(Console.ReadLine());
            books = new Book[size];

            while (true)
            {
                Console.WriteLine("1.Add book\n" +
                                  "2.Edit book\n" +
                                  "3.Delete book\n" +
                                  "4.Recovering book\n" +
                                  "5.Search book\n" +
                                  "6.Print book\n" +
                                  "7.Exit");
                int key = int.Parse(Console.ReadLine());

                switch (key)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        Console.WriteLine("Enter book title or writer or ISBN which you want to edit: ");
                        string bookPropertyToEdit = Console.ReadLine();
                        UpdateBook(bookPropertyToEdit);
                        break;
                    case 3:
                        Console.WriteLine("Enter book title or writer or ISBN which you want to delete: ");
                        string bookPropertyToDelete = Console.ReadLine();
                        DeleteBook(bookPropertyToDelete);
                        break;
                    case 4:
                        Console.WriteLine("Enter book title or writer or ISBN which you want to recover: ");
                        string bookPropertyToRecover = Console.ReadLine();
                        RecoverBook(bookPropertyToRecover);
                        break;
                    case 5:
                        Console.WriteLine("Enter book title or writer or ISBN which you want to find: ");
                        string bookProperty = Console.ReadLine();
                        int foundedBookIndex = SearchBook(bookProperty);
                        if (foundedBookIndex != -1)
                        {
                            Console.WriteLine(books[foundedBookIndex].ToString());
                        }
                        else
                        {
                            Console.WriteLine("Book not found!");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Which book do you want to print, Enter book title or writer or ISBN which you want to print: ");
                        string bookPropertyToPrint = Console.ReadLine();
                        PrintBook(bookPropertyToPrint);
                        break;
                    case 7:
                        return;
                }
            }

        }

        public static void AddBook()
        {
            Console.WriteLine("Enter book title: ");
            books[emptyIndex].Title = Console.ReadLine();
            Console.WriteLine("Enter book writer: ");
            books[emptyIndex].Writer = Console.ReadLine();
            Console.WriteLine("Enter book ISBN: ");
            books[emptyIndex].ISBN = Console.ReadLine();
            emptyIndex++;
        }

        public static void UpdateBook(string bookFeature)
        {
            int bookIndex = SearchBook(bookFeature);
            if (bookIndex != -1)
            {
                while (true)
                {
                    Console.WriteLine("Which one do you want to change? \n" +
                                      "1.Title\n" +
                                      "2.Writer\n" +
                                      "3.ISBN\n" +
                                      "4.Nothing More!");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter new title: ");
                            string title = Console.ReadLine();
                            books[bookIndex].Title = title;
                            break;
                        case 2:
                            Console.WriteLine("Enter new writer: ");
                            books[bookIndex].Writer = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter new ISBN: ");
                            books[bookIndex].ISBN = Console.ReadLine();
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("book not found!");
            }
        }

        public static int SearchBook(string bookProperty)
        {
            for (int i = 0; i < size; i++)
            {
                if (books[i].Title == bookProperty && books[i].isDelete == false)
                {
                    return i;
                }
                else if (books[i].Writer == bookProperty && books[i].isDelete == false)
                {
                    return i;
                }
                else if (books[i].ISBN == bookProperty && books[i].isDelete == false)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int SearchBookForRecovery(string bookProperty)
        {
            for (int i = 0; i < size; i++)
            {
                if (books[i].Title == bookProperty)
                {
                    return i;
                }
                else if (books[i].Writer == bookProperty)
                {
                    return i;
                }
                else if (books[i].ISBN == bookProperty)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void DeleteBook(string bookProperty)
        {
            int bookIndex = SearchBook(bookProperty);
            books[bookIndex].isDelete = true;
            emptyIndex--;
        }

        public static void RecoverBook(string bookProperty)
        {
            int bookIndex = SearchBookForRecovery(bookProperty);
            if (bookIndex != -1)
            {
                books[bookIndex].isDelete = false;
                Console.WriteLine("Book recovered!");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        public static void PrintBook(string bookProperty)
        {
            int bookIndex = SearchBook(bookProperty);
            if (bookIndex != -1)
            {
                Console.WriteLine(books[bookIndex].ToString());
            }
            else
            {
                Console.WriteLine("book not found!");
            }
        }

        public static void PrintBook(int bookIndex)
        {
            Console.WriteLine(books[bookIndex].ToString());
        }
    }
}
