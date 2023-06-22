using System;
using System.Collections.Generic;
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
            items[id] = obj;
        }

        public T Get(int id)
        {
            return items[id];
        }

        public void Delete(int id)
        {
            items.RemoveAt(id);
        }


    }
}
