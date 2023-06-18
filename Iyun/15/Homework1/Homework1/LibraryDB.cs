using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class LibraryDB
    {
        private static List<Author> db;
        static LibraryDB()
        {
            db = new List<Author>();
        }

        #region Author Methods
        public static void AddAuthor(Author author)
        {
            db.Add(author);
        }

        public static void ShowAllAuthorNames()
        {
            for (int i = 0; i < db.Count; i++)
            {
                Console.WriteLine(db[i].AuthorName);
            }
        }

        public static void FindAuthorByName(string authorName)
        {
            for (int i = 0; i < db.Count; i++)
            {
                if (db[i].AuthorName == authorName)
                {
                    Console.WriteLine($"Muellif database-de movcuddur.");
                    Console.Write("Haqqindaki melumati ve kitablarini gormek isterdinizmi(yes/no): ");

                    if (Console.ReadLine() == "yes")
                    {
                        Console.Clear();
                        ShowLibraryItemInfo(i);
                    }
                }
            }
        }

        public static void EditAuthor(string authorName)
        {

            for (int i = 0; i < db.Count; i++)
            {
                if (authorName == db[i].AuthorName)
                {
                    Console.Write($"Yeni ad: ");
                    db[i].AuthorName = Console.ReadLine();

                    Console.Write("Yeni yas: ");
                    db[i].AuthorAge = int.Parse(Console.ReadLine());

                }
            }
        }
        #endregion

        #region Book Methods
        public static void AddBook(Book newBook, int Id)
        {
            bool isAdded = false;
            for (int i = 0; i < db.Count; i++)
            {
                if (db[i].AuthorId == Id)
                {
                    isAdded = true;
                    db[i].authorBooks.Add(newBook);
                }
            }
            if (isAdded)
            {
                Console.WriteLine("Kitab elave olundu");
            }
            else {
                Console.WriteLine("Qeyd olunan ID -de muellif tapilmadi");
            }
        }

        public static void ShowAllBookNames()
        {
            for (int i = 0; i < db.Count; i++)
            {
                for (int j = 0; j < db.Count; j++)
                {
                    Console.WriteLine(db[i].authorBooks[j].BookName);
                }
            }
        }

        public static void FindBookByName(string bookName)
        {
            for (int i = 0; i < db.Count; i++)
            {
                for (int j = 0; j < db.Count; j++)
                {
                    if (db[i].authorBooks[j].BookName == bookName)
                    {
                        Console.WriteLine($"Kitab database-de movcuddur.");
                        Console.Write("Haqqindaki melumati gormek isterdinizmi(yes/no): ");
                        if (Console.ReadLine() == "yes")
                        {
                            Console.Clear();
                            Console.WriteLine($"Muellifi: {db[i].AuthorName}");
                            Console.WriteLine($"Sehife sayi: {db[i].authorBooks[j].CountOfPages}");
                        }
                    }
                }
            }
        }

        public static void EditBook(string bookName)
        {
            string tempChoice;
            for (int i = 0; i < db.Count; i++)
            {
                for (int j = 0; j < db.Count; j++)
                {
                    if (db[i].authorBooks[j].BookName == bookName)
                    {
                        Console.Write($"Yeniden adlandir(Press Enter to Continue): ");
                        tempChoice = Console.ReadLine();
                        if (!String.IsNullOrEmpty(tempChoice))
                        {
                            db[i].authorBooks[j].BookName = tempChoice;
                        }

                        start:
                        Console.Write("Vereq sayini deyis(Press Enter to Continue): ");
                        tempChoice = Console.ReadLine();

                        try
                        {
                            db[i].authorBooks[j].CountOfPages = int.Parse(tempChoice);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Xeta! Sehife sayi yalniz reqemlerden ibaret olmalidir");
                            goto start;
                        }
                    }
                }
            }
        }
        #endregion


        private static void ShowLibraryItemInfo(int indexNum)
        {
            Console.WriteLine($"Muellif: {db[indexNum].AuthorName}");
            Console.WriteLine($"Id-si: {db[indexNum].AuthorId}");
            Console.WriteLine($"Yasi: {db[indexNum].AuthorAge}");
            Console.WriteLine("\tKitablari:");
            for (int j = 0; j < db[indexNum].authorBooks.Count; j++)
            {
                Console.WriteLine($"\tAdi: {db[indexNum].authorBooks[j].BookName}");
                Console.WriteLine($"\tSeh. sayi: {db[indexNum].authorBooks[j].CountOfPages}");
            }
            if (db[indexNum].authorBooks.Count == 0)
            {
                Console.WriteLine("\tMovcud kitabi yoxdur");
            }


        }
    }
}
