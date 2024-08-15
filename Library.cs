using System;

namespace LibraryApp
{
    struct Library
    {
        public string BookName;
        public string AuthorName;
        public float Cost;
        public int NoOfPages;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library[] lib = new Library[100];
            string bookName;
            int i = 0, j = 0, count = 0;
            bool isLoggedIn = false;

            string username = "admin";
            string password = "password";

            while (!isLoggedIn)
            {
                Console.Write("Enter username: ");
                string inputUsername = Console.ReadLine();

                Console.Write("Enter password: ");
                string inputPassword = Console.ReadLine();

                if (inputUsername == username && inputPassword == password)
                {
                    isLoggedIn = true;
                    Console.WriteLine("\nLogin successful!\n");
                }
                else
                {
                    Console.WriteLine("\nInvalid credentials, please try again.\n");
                }
            }

            while (j != 6)
            {
                Console.WriteLine("\n\n1. Add Book details\n");
                Console.WriteLine("2. Display the list of books and its details\n");
                Console.WriteLine("3. Display the total number of books in the library\n");
                Console.WriteLine("4. Logout\n\n");
                Console.Write("Enter the number: ");
                j = Convert.ToInt32(Console.ReadLine());

                switch (j)
                {
                    case 1:
                        Console.WriteLine("\nYou can add the details of the book");
                        Console.Write("Enter the book name: ");
                        lib[i].BookName = Console.ReadLine();
                        Console.Write("Enter the author name: ");
                        lib[i].AuthorName = Console.ReadLine();
                        Console.Write("Enter the number of pages: ");
                        lib[i].NoOfPages = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the cost of the book: ");
                        lib[i].Cost = float.Parse(Console.ReadLine());
                        count++;
                        i++;
                        break;

                    case 2:
                        if (count == 0)
                        {
                            Console.WriteLine("\nThere are no books stored!!\n\n");
                        }
                        else
                        {
                            Console.WriteLine("\nYou can view the list of books");
                            Console.WriteLine("The list of books are:");
                            for (i = 0; i < count; i++)
                            {
                                Console.WriteLine($"The name of the book is: {lib[i].BookName}");
                                Console.WriteLine($"The name of the author is: {lib[i].AuthorName}");
                                Console.WriteLine($"The number of pages are: {lib[i].NoOfPages}");
                                Console.WriteLine($"The cost of the book is: {lib[i].Cost}\n\n");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine($"Total number of books in the library are: {count}\n\n");
                        break;

                    case 4:
                        isLoggedIn = false;
                        Console.WriteLine("\nLogged out successfully!\n");
                        Main(args);
                        break;

                    default:
                        Console.WriteLine("\nInvalid number entered\n\n");
                        break;
                }
            }
        }
    }
}
