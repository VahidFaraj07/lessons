﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    public interface IGenericRepository<T>
    {
        void Add(T obj);
        void Update(T obj, int id);
        T Get(int id);
        void Delete(int id);
    }
}
