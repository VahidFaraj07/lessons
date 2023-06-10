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
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal OfferPrice { get; set; }


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
