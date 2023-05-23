using System;
/*
 Homework 3:
 İnternetdə Access Modifiers mövzusunu araşdırın və elə edin ki, CheckCustomerFromDb methodunu nə public nədə private istifadə etmədən,
 Program class'ında istifadə edə bilim. Inherit almaq şansınız yoxdur, yanlız aşağıdakı kimi yazanda işləməlidir və dəyişikliyi Customer
 class'ı tərəfdə etməlisiniz.

 Nümunə:
 Customer customer = new Customer();
 customer.CheckCustomerFromDb();
 */

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CheckCustomerFromDb();
        }
    }
}
