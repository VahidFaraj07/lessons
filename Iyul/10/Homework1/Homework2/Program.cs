using Homework2.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
/*
Homework 2:
Bir Car class'ınız olsun. (Property'ləri: Şəhər (satıldığı), Marka, Model, Buraxılış ili, Rəngi, Mühərrik Həcmi, At Gücü, Kilometrajı, Sürətlər Qutusunun tipi, Qiyməti).
Bir list'in içinə bir neçə dənə Car əlavə edib nümunədən aşağıdakı sorğuları yazacaqsınız.
Nümunə data:
Şəhər: Bakı
Marka: Lexus
Model: GX460
Buraxılış ili: 2021
Rəngi: Black (Enum olacaq və 10-15 dənə rəng olsun Enum'da)
Mühərrik Həcmi: 4500
At Gücü: 296
Kilometrajı: 15777
Sürətlər Qutusunun tipi: Automatic (Enum olacaq. Dəyərləri də Automatic, Manual, Robot)
Qiyməti: 200.000

Aşağıdakı sorğuları yazın:
1. Markası Mercedes olub, mühərrik həcmi 4200'dən az olan və ya bərabər olan, Bakıda satılan.
2. Bakıda satılmayan, buraxılış ili 2015-ci il daxil olmaqla 2020-ci ilə qədər olan (2020 də daxildir buna)
3. Kilometrajı 0 olan və Modelində "ml" sözü olan
4. Sürətlər qutusu avtomatik olan və qiyməti 15.000-17.500 arasında olan
5. Rəngi Red, Black olmayan, mühərrik həcmi 2000-4000 arasında olan, sürətlər qutusu Robot olmayan, buraxılış ili 2010-dan köhnə olmayan.
6. Ya markası Lexus olub, qiyməti 30.000-ə qədər olan ya da markası Mercedes olub qiyməti 45.000-ə qədər olan.

*/


namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Car car1 = new Car
            {
                City = "Baku",
                Brand = "Lexus",
                Model = "GX460",
                ManufactureYear = 2021,
                Color = Color.Black,
                EngineCapacity = 4200,
                Horsepower = 296,
                Mileage = 15777,
                Transmission = TransmissionType.Automatic,
                Price = 20000
            };
            Car car2 = new Car
            {
                City = "Baku",
                Brand = "Mercedes",
                Model = "S 63 AMG Coupe",
                ManufactureYear = 2014,
                Color = Color.White,
                EngineCapacity = 4000,
                Horsepower = 585,
                Mileage = 41000,
                Transmission = TransmissionType.Automatic,
                Price = 100000
            };
            Car car3 = new Car
            {
                City = "Germany",
                Brand = "BMW",
                Model = "528",
                ManufactureYear = 2012,
                Color = Color.DeepPink,
                EngineCapacity = 4500,
                Horsepower = 245,
                Mileage = 96000,
                Transmission = TransmissionType.Automatic,
                Price = 16000
            };
            Car car4 = new Car
            {
                City = "Spain",
                Brand = "Ford",
                Model = "Fusion ml ",
                ManufactureYear = 2016,
                Color = Color.Blue,
                EngineCapacity = 4500,
                Horsepower = 181,
                Mileage = 0,
                Transmission = TransmissionType.Robot,
                Price = 21000
            };

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            cars.Add(car4);

            var condition1 = cars.Where(m => m.Brand == "Mercedes" && m.EngineCapacity <= 4200 && m.City == "Baku").ToList();
            var condition2 = cars.Where(m => m.City != "Baku" && m.ManufactureYear <= 2020 && m.ManufactureYear >= 2015).ToList();
            var condition3 = cars.Where(m => m.Mileage == 0 && m.Model.Contains("ml")).ToList();
            var condition4 = cars.Where(m => m.Transmission == Enum.TransmissionType.Automatic && m.Price >= 15000 && m.Price <= 17000).ToList();
            var condition5 = cars.Where(m => m.Color != Color.Black && m.Color != Color.Red && m.EngineCapacity >= 2000 && m.EngineCapacity <= 4000 && m.Transmission != Enum.TransmissionType.Robot && m.ManufactureYear >= 2010).ToList();
            var condition6 = cars.Where(m => (m.Brand == "Lexus" && m.Price <= 30000) || (m.Brand == "Mercedes" && m.Price <= 45000)).ToList();

            cars.ForEach(car =>
            {
                Console.WriteLine("City: " + car.City);
                Console.WriteLine("Brand: " + car.Brand);
                Console.WriteLine("Model: " + car.Model);
                Console.WriteLine("Year: " + car.ManufactureYear);
                Console.WriteLine("Color: " + car.Color);
                Console.WriteLine("Engine Capacity: " + car.EngineCapacity);
                Console.WriteLine("Horsepower: " + car.Horsepower);
                Console.WriteLine("Mileage: " + car.Mileage);
                Console.WriteLine("Transmission: " + car.Transmission);
                Console.WriteLine("Price: " + car.Price);
                Console.WriteLine();
            });



        }

    }
}
