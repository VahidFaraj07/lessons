using System;
using System.Collections;

//dev interview task:

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] { 'r', 'e', 'd', ' ', 'b', 'l', 'u', 'e', ' ', 'y', 'o', 'u', ' ', 'm', 'e', ' ', 'c', 'a', 'l', 'l' };

            ArrayList newSet = new ArrayList();

            int tempCount = 0;
            for (int i = (arr.Length - 1); i >= 0; i--)
            {
                tempCount++;
                if (arr[i] == ' ')
                {
                    i++;
                    tempCount--;
                    for (int j = 0; j < tempCount; j++)
                    {
                        newSet.Add(arr[i + j]);
                    }
                    newSet.Add(' ');
                    tempCount = 0;
                    i--;
                }
                else if (i == 0)
                {
                    for (int j = 0; j < tempCount; j++)
                    {
                        newSet.Add(arr[i + j]);
                    }
                }
            }

            foreach (var item in newSet)
            {
                Console.Write(item);
            }
        }
    }
}
