using System;


namespace Homework4
{
    class Vehicle
    {
        string marka;
        string model;
        ushort istehIli;
        double km;
        string yanacaqNovu;
        string suretQut;
        double alisQiy;
        double satisQiy;
        double maxEndirimMeb;
        private double qiymet;

        //1. marka, model
        public Vehicle(string marka, string model)
        {
            this.marka = marka;
            this.model = model;
        }

        //2. marka, model, istehsal ili
        public Vehicle(string marka, string model, ushort istehIli)
        {
            this.marka = marka;
            this.model = model;
            this.istehIli = istehIli;
        }

        //3. marka, model, istehsal ili, km
        public Vehicle(string marka, string model, ushort istehIli, double km)
        {
            this.marka = marka;
            this.model = model;
            this.istehIli = istehIli;
            this.km = km;
        }

        //4. bütün property'lər
        public Vehicle(string marka, string model, ushort istehIli, double km, string yanacaqNovu, string suretQut, double alisQiy, double satisQiy, double maxEndirimMeb)
        {
            this.marka = marka;
            this.model = model;
            this.istehIli = istehIli;
            this.km = km;
            this.yanacaqNovu = yanacaqNovu;
            this.suretQut = suretQut;
            this.alisQiy = alisQiy;
            this.satisQiy = satisQiy;
            this.maxEndirimMeb = maxEndirimMeb;
        }

        public void ShowInfo() {
            Console.WriteLine("--Avtomobil haqqinda melumat--");
            Console.WriteLine($"Markasi: {marka}");
            Console.WriteLine($"Modeli: {model}");
            Console.WriteLine($"Istehsal ili: {istehIli}");
            Console.WriteLine($"Yurus mesafesi: {km}km");
            Console.WriteLine($"Yanacaq novu: {yanacaqNovu}");
            Console.WriteLine($"Süretler qutusu: {suretQut}");
            Console.WriteLine($"Alıs qiymeti: {alisQiy}");
            Console.WriteLine($"Satıs qiymeti: {satisQiy}");
            Console.WriteLine($"Max endirim mebleği: {maxEndirimMeb}");
        }

        public void SetPrice() {
            qiymet = alisQiy * 1.1F;

            if ((satisQiy - maxEndirimMeb) > qiymet)
            {
                Console.WriteLine($"Satis ucun nezerde tutulmus minimal qiymet {qiymet}");
                Console.WriteLine($"Faktiki satis qiymeti {satisQiy - maxEndirimMeb}");
                Console.WriteLine($"Satildi!");
            }
            else {
                Console.WriteLine("Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!");
            }
        }
    }
}
