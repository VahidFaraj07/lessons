using System;

namespace Homework1
{
    public class Product : SystemInfo
    {
        private static int idCount;
        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal BuyPrice
        {
            get { return BuyPrice; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Alis qiymeti 1-den kicik ola bilmez!");
                    BuyPrice = 0;
                }
                else
                {
                    BuyPrice = value;
                }
            }
        }
        public decimal SellPrice
        {
            get
            {
                return SellPrice;
            }
            set
            {
                if (value < BuyPrice)
                {
                    Console.WriteLine("Satis qiymeti alis qiymetinden az ola bilmez!");
                    SellPrice = 0;
                }
                else
                {
                    SellPrice = value;
                }
            }
        }
        public decimal OfferPrice
        {
            get { return OfferPrice; }
            set
            {
                if (OfferPrice < 1)
                {
                    Console.WriteLine("Kompaniya qiymeti 1-den kicik ola bilmez!");
                    OfferPrice = 0;
                }
                else
                {
                    OfferPrice = value;
                }
            }
        }


        protected Product()
        {
            _id = idCount++;
        }

        static Product()
        {
            idCount = 0;
        }




    }
}
