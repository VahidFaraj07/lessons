using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte yourOption = 0;


        start:
            switch (yourOption)
            {
                #region case0
                case 0:
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("1. Muellif elave et");
                    Console.WriteLine("2. Butun muellifleri goster");
                    Console.WriteLine("3. Muellifi ada gore axtar");
                    Console.WriteLine("4. Muellifi editle");
                    Console.WriteLine("5. Kitab elave et");
                    Console.WriteLine("6. Butun kitablari goster");
                    Console.WriteLine("7. Kitabi ada gore axtar");
                    Console.WriteLine("8. Kitabi editle");
                    Console.WriteLine("9. Exit");
                    Console.WriteLine("---------------------------------");
                    Console.Write("Choice: ");

                    bool availableOption = byte.TryParse(Console.ReadLine(), out yourOption);
                    Console.Clear();

                    if (availableOption == false || yourOption > 9 || yourOption == 0)                                 // her hansi string ve ya case daxilinde olmayan reqem daxil edilmesi zamani
                    {
                        yourOption = 0;
                        Console.WriteLine("\t***Yanlis secim!! Yeniden cehd edin***\n");
                    }
                    goto start;
                #endregion

                #region case1
                case 1:
                    int authorId, authorAge;
                    string authorName;

                    Console.Clear();
                    Console.Write("Muellif id-sini daxil edin: ");
                    try
                    {
                        authorId = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Xeta! ID deyeri yalniz reqemlerden ibaret olmalidir");
                        goto case 0;
                    }

                    Console.Write("Muellif adini daxil edin: ");
                    authorName = Console.ReadLine();

                    Console.Write("Muellifin yasini daxil edin: ");
                    try
                    {
                        authorAge = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Xeta! Yas yalniz reqemlerden ibaret olmalidir");
                        goto case 0;
                    }

                    Author author = new Author
                    {
                        AuthorId = authorId,
                        AuthorName = authorName,
                        AuthorAge = authorAge
                    };

                    LibraryDB.AddAuthor(author);
                    Console.Clear();
                    Console.WriteLine("Muellif elave olundu");

                    goto case 0;
                #endregion

                #region case2
                case 2:
                    Console.Clear();
                    LibraryDB.ShowAllAuthorNames();
                    goto case 0;

                #endregion

                #region case3
                case 3:
                    Console.Clear();
                    Console.WriteLine("Axtarmaq istediyiniz muellifin adini daxil edin: ");
                    authorName = Console.ReadLine();
                    LibraryDB.FindAuthorByName(authorName);
                    goto case 0;
                #endregion

                #region case4
                case 4:
                    Console.Clear();
                    Console.WriteLine("Editlemek istediyiniz muellifin adini daxil edin: ");
                    authorName = Console.ReadLine();
                    LibraryDB.EditAuthor(authorName);
                    goto case 0;
                #endregion

                #region case5
                case 5:
                    string bookName;
                    int countOfPages;
                    Console.Clear();
                    Console.Write("Muellif id-sini daxil edin: ");
                    try
                    {
                        authorId = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Xeta! ID deyeri yalniz reqemlerden ibaret olmalidir");
                        goto case 0;
                    }

                    Console.Write("Kitabin adi: ");
                    bookName = Console.ReadLine();

                    Console.Write("Sehife sayi : ");
                    try
                    {
                        countOfPages = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Xeta! Sehife sayi yalniz reqemlerden ibaret olmalidir");
                        goto case 0;
                    }

                    Book book = new Book
                    {
                        BookName = bookName,
                        CountOfPages = countOfPages
                    };

                    LibraryDB.AddBook(book, authorId);
                    goto case 0;
                #endregion

                #region case6
                case 6:
                    LibraryDB.ShowAllBookNames();
                    goto case 0;
                #endregion

                #region case7
                case 7:
                    Console.Clear();
                    Console.WriteLine("Axtarmaq istediyiniz kitabin adini daxil edin: ");
                    bookName = Console.ReadLine();
                    LibraryDB.FindBookByName(bookName);
                    goto case 0;
                #endregion

                #region case8
                case 8:
                    Console.Clear();
                    Console.WriteLine("Editlemek istediyiniz kitabin adini daxil edin: ");
                    bookName = Console.ReadLine();
                    LibraryDB.EditBook(bookName);
                    goto case 0;
                #endregion

                #region case9
                case 9:
                    break;
                    #endregion

            }


        }
    }
}
