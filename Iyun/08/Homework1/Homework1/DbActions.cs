using System;
using System.Collections;


namespace Homework1
{
    public static class DbActions
    {
        private static ArrayList db;

        public static void NewItem(Product Product)
        {
            if (BarcodeCanBeAdd(Product))
            {
                db.Add(Product);
            }
            else {
                Console.WriteLine($"{Product.Barcode} barkodu daha once basqa mehsul ucun sisteme elave olunub!");
            }
        }

        public static void NewItems(Product[] args)
        {
            foreach (var Product in args)
            {
                NewItem(Product);
            }
        }

        public static void UpdateItem(Product Product)
        {

        }

        public static void DeleteItem(Product Product)
        {
            Product.IsDeleted = true;
        }

        // This method is created to control the results of the code
        public static void ShowItems()
        {
            foreach (var item in db)
            {
                if (item.GetType() == typeof(Tv))
                {
                    Tv a = (Tv)item;
                    Console.WriteLine($"{a.Id}");
                    Console.WriteLine($"{a.IsSmartTv}");
                    Console.WriteLine($"{a.HasHDMI}");
                    Console.WriteLine($"{a.Resolution}");
                    Console.WriteLine($"{a.Barcode}");
                    Console.WriteLine($"{a.Brand}");
                    Console.WriteLine($"{a.IsDeleted}");
                }
                else
                {
                    Laptop a = (Laptop)item;
                    Console.WriteLine($"{a.Id}");
                    Console.WriteLine($"{a.CPU}");
                    Console.WriteLine($"{a.Ram}");
                    Console.WriteLine($"{a.GraphicCard}");
                    Console.WriteLine($"{a.Barcode}");
                    Console.WriteLine($"{a.Brand}");
                    Console.WriteLine($"{a.IsDeleted}");
                }
            }
        }

        static DbActions()
        {
            db = new ArrayList();
        }

        public static bool BarcodeCanBeAdd(Product Product)
        {
            if (db.Count != 0)
            {
                bool result = false;
                foreach (Product item in db)
                {
                    if (Product.Barcode != item.Barcode || item.IsDeleted == true)
                    {
                        result = true;
                    }
                }
                return result;

            }
            else
            {
                return true;
            }
        }


    }
}
