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
        public void Add(T obj, int id)
        {
            if (items.Count == 0)
            {
                items.Add(obj);
            }
            else
            {
                bool idIsValid = false;
                Type type;
                PropertyInfo[] properties;

                for (int i = 0; i < items.Count; i++)
                {
                    type = items[i].GetType();
                    properties = type.GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        if (property.Name == "Id" && (int)property.GetValue(items[i]) == id)
                        {
                            idIsValid = true;
                        }
                    }
                }


                if (idIsValid)
                {
                    Console.WriteLine("Qeyd olunan id nomresine uygun element artiq movcuddur.");
                }
                else
                {
                    items.Add(obj);
                }
            }
        }
        #endregion

        #region Update
        public void Update(T obj, int id)
        {
            bool idIsValid = false;
            Type type;
            PropertyInfo[] properties;

            for (int i = 0; i < items.Count; i++)
            {
                type = items[i].GetType();
                properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    if (property.Name == "Id" && (int)property.GetValue(items[i]) == id)
                    {
                        items[i] = obj;
                        idIsValid = true;
                        Console.WriteLine("Ugurla update olundu");
                    }
                }
            }

            if (!idIsValid)
            {
                Console.WriteLine("Qeyd olunan id nomresine uygun element tapilmadi.");
            }
        }
        #endregion

        #region Get
        public void Get(int id)
        {
            bool idIsValid = false;
            Type type;
            PropertyInfo[] properties;

            foreach (T obj in items)
            {
                type = obj.GetType();
                properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    if (property.Name == "Id" && (int)property.GetValue(obj) == id)
                    {
                        ShowAllProperties(obj, properties);
                    }
                }
            }
            Console.WriteLine();

            if (!idIsValid)
            {
                Console.WriteLine("Qeyd olunan id nomresine uygun element tapilmadi.");
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

        #region Delete
        public void Delete(int id)
        {
            bool idIsValid = false;
            Type type;
            PropertyInfo[] properties;
            foreach (T obj in items)
            {
                type = obj.GetType();
                properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    if (property.Name == "Id" && (int)property.GetValue(obj) == id)
                    {
                        items.Remove(obj);
                        items.TrimExcess();
                        idIsValid = true;
                    }
                }
            }
            if (!idIsValid)
            {
                Console.WriteLine("Qeyd olunan id nomresine uygun element tapilmadi.");
            }

        }
        #endregion

    }
}
