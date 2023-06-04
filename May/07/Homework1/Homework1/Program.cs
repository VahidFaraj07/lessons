using System;

//Homework 1:
//    Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız.
//    Bunun üçün öncə bütün elementlərin toplamını tapın sonra onu array'dakı element sayına bölün. 
//    Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq bir array yaradacaq.
//    Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən soruşub array'ı doldurun.
//    Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın.Bunu həm for döngüsüylə edin həm də foreach.

//Homework 2:
//    int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 };
//    bu arrayın içindəki elementləri kiçikdən böyüyə sıralayın.Ancaq bunu edərkən 
//    sort və reverse method'larından istifadə etmək olmaz :). Alqoritmasını özünüz düşünün.

//Homework 3:
//    Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın. Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın.
//    Əlavə olaraq da bütün rəqəmlərin toplamını ekrana yazdırın.


//Homework 4:
//    Array'ın property və method'larını araşdırın, nə işə yarayır, necə istifadə edilir, nə üçün istifadə edilir və s. 
//    Araşdırdığınız method və property'ləri mütləq praktika edin!

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Homework1
            int elem = 0;
            bool isNum = false;

            Console.Write("Arrayin nece elementi olacaq: ");
            while (!isNum)
            {
                isNum = int.TryParse(Console.ReadLine(), out elem);
                if (isNum == false)
                {
                    Console.Clear();
                    Console.Write("Xeta!! Yeniden daxil edin: ");
                }
            }

            int[] arr = new int[elem];
            isNum = false;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"\n{i}. indeksli elementi daxil edin: ");
                while (!isNum)
                {
                    isNum = int.TryParse(Console.ReadLine(), out arr[i]);
                    if (isNum == false)
                        Console.Write("Xeta!! Yeniden daxil edin: ");
                }
                isNum = false;
            }

            int arrSum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arrSum1 += arr[i];
            }
            Console.WriteLine($"Cem = {arrSum1}");
            Console.WriteLine($"Ortalama = {(double)arrSum1 / arr.Length}\n");

            #endregion


            #region Homework2
            int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 };
            int[] sortedArr = new int[numArr.Length];

            for (int i = 0; i < numArr.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < numArr.Length; j++)
                {
                    if (numArr[i] > numArr[j])
                        tempCount++;
                    
                }
                sortedArr[tempCount] = numArr[i];
            }

            foreach (var item in sortedArr)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region Homework3
            int[] randArr = new int[100];
            Random rand = new Random();
            for (int i = 0; i < randArr.Length; i++)
            {
                randArr[i] = rand.Next(100000);
            }

            int randArrSum = 0;
            for (int j = 0; j < randArr.Length; j++)
            {
                //Console.WriteLine(randArr[j]);
                randArrSum += randArr[j];
            }
            Console.WriteLine($"Cem: {randArrSum}");

            int minNum = 100000;
            int maxNum = 1;
            for (int i = 0; i < randArr.Length; i++)
            {
                if (randArr[i] > maxNum)
                    maxNum = randArr[i];
                if (randArr[i] < minNum)
                    minNum = randArr[i];
            }
            Console.WriteLine($"Min: {minNum}\nMax: {maxNum}");
            #endregion


            #region Homework4
            int[] arr1 = new int[6] { 23, 16, 4, 42, 8, 15 };
            int[] arr2 = new int[8];


            //CopyTo - 1ci indeksden baslayaraq arr2-nin icine arr1-in icindeki elementleri kopyalayir
            arr1.CopyTo(arr2, 1);
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

            // Array.Sort()
            Array.Sort(arr1);

            //Array.Reverse
            Array.Reverse(arr1);

            //Array.Clear - 2ci indeksden baslayaraq 3 elementi sil
            Array.Clear(arr1, 2, 3);

            //Array.IndexOf - deyeri 23 olan elementin indeks nomresini tap
            Console.WriteLine(Array.IndexOf(arr1, 23));

            int[] myArray = new int[5] { 1, 2, 3, 4, 5 };
            // resize the array to 10 elements
            Array.Resize(ref myArray, 6);
            #endregion


        }
    }
}
