using System;

/*
Homework 1:
public delegate void RunAnyMethod();

public static void Add(){
    Console.WriteLine("Add method");
}

public static void Edit(){
    Console.WriteLine("Edit method");
}

public static void Delete(){
    Console.WriteLine("Delete method");
}

Yuxarıda 1 delegate'iniz var və 3 dənə də standart adi method. 
Elə etməlisiniz ki, myDelegate adında bir dəyişəniniz olsun və myDelegate dəyişənini 
    method kimi istifadə edə biləsiniz. 
Yəni myDelegate() yazanda bir method işləmiş olsun. 
Bu qayda da sadəcə 1 dəyişən sayəsində Add, Edit, Delete methodlarını işlətməlisiz. 
Bunu etmək üçün biraz araşdırmalı olacaqsız.

*/

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAnyMethod myDelegate = Add;
            myDelegate += Edit;
            myDelegate += Delete;

            myDelegate.Invoke();
            //myDelegate();
        }

        public delegate void RunAnyMethod();

        public static void Add()
        {
            Console.WriteLine("Add method");
        }

        public static void Edit()
        {
            Console.WriteLine("Edit method");
        }

        public static void Delete()
        {
            Console.WriteLine("Delete method");
        }

    }
}
