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
            else
            {
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

        public static void UpdateItem(Tv Product)
        {
            foreach (Tv item in db)
            {
                if (Product.Id == item.Id)
                {
                    item.Barcode = Product.Barcode;
                    item.Brand = Product.Brand;
                    item.Model = Product.Model;
                    item.BuyPrice = Product.BuyPrice;
                    item.SellPrice = Product.SellPrice;
                    item.OfferPrice = Product.OfferPrice;
                    item.IsSmartTv = Product.IsSmartTv;
                    item.HasHDMI = Product.HasHDMI;
                    item.Resolution = Product.Resolution;
                    item.CreateDate = Product.CreateDate;
                    item.CreateUser = Product.CreateUser;
                    item.EditDate = Product.EditDate;
                    item.EditUser = Product.EditUser;
                    item.IsDeleted = Product.IsDeleted;
                    item.DeleteDate = Product.DeleteDate;
                    item.DeleteUser = Product.DeleteUser;
                }
            }
        }

        public static void UpdateItem(Laptop Product)
        {
            foreach (Laptop item in db)
            {
                if (Product.Id == item.Id)
                {
                    item.Barcode = Product.Barcode;
                    item.Brand = Product.Brand;
                    item.Model = Product.Model;
                    item.BuyPrice = Product.BuyPrice;
                    item.SellPrice = Product.SellPrice;
                    item.OfferPrice = Product.OfferPrice;
                    item.CPU = Product.CPU;
                    item.Ram = Product.Ram;
                    item.GraphicCard = Product.GraphicCard;
                    item.CreateDate = Product.CreateDate;
                    item.CreateUser = Product.CreateUser;
                    item.EditDate = Product.EditDate;
                    item.EditUser = Product.EditUser;
                    item.IsDeleted = Product.IsDeleted;
                    item.DeleteDate = Product.DeleteDate;
                    item.DeleteUser = Product.DeleteUser;
                }
            }
        }

        public static void DeleteItem(Product Product)
        {
            Product.IsDeleted = true;
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
