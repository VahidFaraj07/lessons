using System;
/*
 Homework 4:
 Satılacaq mehsulu yaradacaqsınız ve onun bir neçe dene constructor method'ları olacaq.
 Satılacaq mehsul dedikde meselen Vehicle class'ı ola biler.

 Mehsul (item) Class'ında olacaq property'ler:
    Marka
    Model
    İstehsal ili
    Km
    Yanacaq növü
    Süretler qutusu
    Alış qiymeti
    Satış qiymeti
    Max endirim mebleği
    Qiymet (private olması mütleqdir!)

   Constructor overload'ları aşağıdakı kimi olmalıdır:
    1. marka, model
    2. marka, model, istehsal ili
    3. marka, model, istehsal ili, km
    4. bütün property'ler

   elave olaraq iki methodunuz olacaq hansı ki, birinci method bütün melumatları ekrana yazacaq ve ikinci method ise müeyyen obyektin
   satış qiymetini teyin edecek. Burda biraz baş işletmek lazımdır. Teyin edilen qiymet, satış qiymeti - max endirim qiymeti qeder
   olmalıdır. Yeni, max endirim qiymeti qeder geriye gede bilmeliyem.
   Meselen:
   Satış qiymetim 10 manatdırsa, maximum endirim qiymetim 2 manatdırsa, men bu mehsulu en aşağı 8 manata sata bilmeliyem. 7 manata
   satmağa çalışsam xeta mesajı yazsın ekrana (mes: Max. endirim qiymetinden aşağı bir qiymet teyin etmeye çalışdınız!)
*/

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Marka: ");
            string marka = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Istehsal ili: ");
            ushort istehIli = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Km: ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yanacaq növü: ");
            string yanacaqNovu = Console.ReadLine();
            Console.Write("Süretler qutusu: ");
            string suretQut = Console.ReadLine();
            Console.Write("Alıs qiymeti: ");
            double alisQiy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Satıs qiymeti: ");
            double satisQiy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Max endirim mebleği: ");
            double maxEndirimMeb = Convert.ToDouble(Console.ReadLine());
            Console.Clear();


            Vehicle vehicle = new Vehicle(marka, model, istehIli, km, yanacaqNovu, suretQut, alisQiy, satisQiy, maxEndirimMeb);
            vehicle.ShowInfo();
            vehicle.SetPrice();


        }
    }
}
