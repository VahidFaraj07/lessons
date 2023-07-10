using Homework2.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;

namespace Homework2
{
    public class Car
    {
        public string City { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ManufactureYear { get; set; }
        public Color Color { get; set; }
        public int EngineCapacity { get; set; }
        public int Horsepower { get; set; }
        public int Mileage { get; set; }
        public TransmissionType Transmission { get; set; }
        public decimal Price { get; set; }
    }


}
