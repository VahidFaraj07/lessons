using System;
using System.Collections;
using System.Threading;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            byte yourOption = 0;

        start:
            switch (yourOption)
            {
                #region case0
                case 0:
                    Console.Write("Menu:\n1 - Element elave et\n2 - Elementleri goster\n3 - Element axtar\n4 - Element editle\n5 - Element sil\n6 - Exit\nEmeliyyat novunu secin: ");
                    bool availableOption = byte.TryParse(Console.ReadLine(), out yourOption);
                    Console.Clear();
                    if (availableOption == false || yourOption > 6 || yourOption == 0)                                 // her hansi string ve ya case daxilinde olmayan reqem daxil edilmesi zamani
                    {
                        yourOption = 0;
                        Console.WriteLine("\t***Yanlis secim!! Yeniden cehd edin***\n");
                    }
                    goto start;
                #endregion

                #region case1
                case 1:
                    Console.Write("Zehmet olmasa elave etmek istediyiniz elementi daxil edin: ");
                    arr.Add(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("\t***Element elave olundu!***\n");
                    goto case 0;
                #endregion

                #region case2
                case 2:
                    if (arr.Count == 0)                                                             // arraylist-in bos olmasi zamani
                    {
                        Console.WriteLine("\t***Hec bir element tapilmadi!***\n");
                        goto case 0;
                    }
                    else
                    {
                        for (int i = 0; i < arr.Count; i++)
                        {
                            Console.WriteLine($"{i}. Element = {arr[i]}");
                        }

                        Console.WriteLine("\nDavam etmek ucun Enter duymesine basin");

                        if (Console.ReadLine() == "")
                        {
                            Console.Clear();
                            goto case 0;
                        }
                        else
                        {
                            goto case 2;                                                            //enter duymesinden basqa input daxil olarsa case-i yeniden baslatsin
                        }
                    }
                #endregion

                #region case3
                case 3:
                    Console.Write("Axtarmaq istediyiniz elementi daxil edin: ");
                    string tempShow = Console.ReadLine();
                    Console.Clear();

                    if (arr.Contains(tempShow))
                    {
                        Console.WriteLine("\t***Element tapildi!***");
                        for (int i = 0; i < arr.Count; i++)                                         //eyni adda 1-den cox element oldugu halda her birini gostermesi ucun
                        {
                            if (arr[i].ToString() == tempShow)
                            {
                                Console.WriteLine($"\tIndex:{i} - Deyer:{arr[i]}");
                            }
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("\t***Axtardiginiz element tapilmadi!***\n");
                    }
                    goto case 0;
                #endregion

                #region case4
                case 4:
                    Console.Write("Editlemek istediyiniz elementi daxil edin: ");
                    string tempEdit = Console.ReadLine();
                    if (arr.Contains(tempEdit))
                    {
                        int countOfEdit = 0;
                        Console.WriteLine($"\"{tempEdit}\" elementini ne ile evezlemek isteyirsiniz?");
                        string inpEdit = Console.ReadLine();
                        for (int i = 0; i < arr.Count; i++)
                        {
                            if (arr[i].ToString() == tempEdit)
                            {
                                arr[i] = inpEdit;
                                countOfEdit++;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine($"\t***{countOfEdit} eded element editlendi!***\n");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\t***Axtardiginiz element tapilmadi!***\n");
                    }
                    goto case 0;
                #endregion

                #region case5
                case 5:
                    Console.WriteLine("Butun elementleri silmek isteyirsiniz? (H/Y)");
                    string yesNo = Console.ReadLine().ToUpper();
                    if (yesNo == "H")
                    {
                        arr.Clear();
                        arr.TrimToSize();
                        Console.Clear();
                        Console.WriteLine("\t***Butun elementler silindi!***\n");
                    }
                    else if (yesNo == "Y")
                    {
                        Console.Clear();
                        Console.Write("Silmek istediyiniz elementi daxil edin: ");
                        string delElem = Console.ReadLine();

                        if (arr.Contains(delElem))
                        {
                            int countOfDel = 0;
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (arr[i].ToString() == delElem)
                                {
                                    arr.Remove(arr[i]);
                                    i--;                                                                                // ard-arda gelen eyni adli elementler ucun
                                    countOfDel++;
                                }
                            }
                            Console.Clear();
                            Console.WriteLine($"\t***{countOfDel} eded element silindi!***\n");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\t***Silmek istediyiniz element tapilmadi!***\n");
                        }
                    }
                    else
                    {
                        goto case 5;                                                                    // H ve ya Y duymesinden basqa input daxil olarsa case-i yeniden baslatsin
                    }
                    goto case 0;
                #endregion

                #region case6
                case 6:
                    string message = "Exiting";
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Clear();
                        message += ".";
                        Console.WriteLine(message);
                        Thread.Sleep(800);
                    }
                    break;
                #endregion

            }
        }
    }
}
