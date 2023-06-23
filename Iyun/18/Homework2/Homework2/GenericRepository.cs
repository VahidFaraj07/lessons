using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Homework2
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private List<T> items;

        public GenericRepository()
        {
            items = new List<T>();
        }

        public void Add(T obj)
        {
            items.Add(obj);
        }

        public void Update(T obj, int id)
        {
        }

        public void Get(int id)
        {
            foreach (var obj in items)
            {
                Type type = obj.GetType();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine($"{property.Name}: {property.GetValue(obj)}");
                }
                Console.WriteLine();
            }                   
        }

        public void Delete(int id)
        {
            items.RemoveAt(id);
        }


    }
}
