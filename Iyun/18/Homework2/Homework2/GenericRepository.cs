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

        #region Add
        public void Add(T obj)
        {
            items.Add(obj);
        }
        #endregion


        public void Update(T obj, int id)
        {

        }

        #region Get
        public void Get(int id)
        {
            foreach (T obj in items)
            {
                Type type = obj.GetType();
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    if (property.Name == "Id" && (int)property.GetValue(obj) == id)
                    {
                        ShowAllProperties(obj, properties);
                    }
                }
            }
        }

        private void ShowAllProperties(T obj, PropertyInfo[] properties)
        {
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(obj)}");
            }
        }
        #endregion

        public void Delete(int id)
        {
            items.RemoveAt(id);
        }
    }
}
