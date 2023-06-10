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
                if (ControlPrice(Product.BuyPrice, Product.SellPrice, Product.OfferPrice))
                {
                    db.Add(Product);
                }          
            }
            else {
                Console.WriteLine($"\"{Product.Barcode}\" barkodu daha once basqa mehsul ucun sisteme elave olunub!");
            }
        }

        public static void NewItems(params Product[] Products)
        {
            foreach (var Product in Products)
            {
                NewItem(Product);
            }
        }

        public static void UpdateItem(Product Product)
        {
            Console.WriteLine("Update olundu");
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

        private static bool ControlPrice(decimal BuyPrice, decimal SellPrice, decimal OfferPrice)
        {
            if (BuyPrice < 1)
            {
                Console.WriteLine("Alis qiymeti 1-den kicik ola bilmez!");
                return false;
            }
            else if (SellPrice < BuyPrice)
            {
                Console.WriteLine("Satis qiymeti alis qiymetinden az ola bilmez!");
                return false;
            }
            else if (OfferPrice < 1)
            {
                Console.WriteLine("Kompaniya qiymeti 1-den kicik ola bilmez!");
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
