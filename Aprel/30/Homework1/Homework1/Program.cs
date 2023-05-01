using System;

/*
 Homework 1:
 Əvvəlcədən iki dəyişəndə username və password saxlayın. Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. Yəni proqramda belə dəyişdirmək mümkün olmasın.
 Sonra istifadəçidən username və password'u daxil etməsini istəyin. Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
 Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.
 */

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            const string usernameDB = "vahid.faraj";
            const string passwordDB = "Admin123";

            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (usernameDB == username && passwordDB == password)
            {
                Console.WriteLine("Sisteme daxil olundu.");
            }
            else
            {
                Console.WriteLine("Username ve Password'u yeniden daxil edin.");

                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                if (usernameDB == username && passwordDB == password)
                {
                    Console.WriteLine("Sisteme daxil olundu.");
                }
                else
                {
                    Console.WriteLine("Username ve Password'u yeniden daxil edin.");
                    Console.Write("Username: ");
                    username = Console.ReadLine();
                    Console.Write("Password: ");
                    password = Console.ReadLine();
                    if (usernameDB == username && passwordDB == password)
                    {
                        Console.WriteLine("Sisteme daxil olundu.");
                    }
                    else
                    {
                        Console.WriteLine("Hesab bloklandi");
                    }
                }
            }
        }
    }
}
