using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    public interface IGenericRepository<T>
    {
        void Add(T obj, int id);
        void Update(T obj, int id);
        void Get(int id);
        void Delete(int id);
    }
}
