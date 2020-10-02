﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JobTestSemma.core
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> All();
        T GetById(int id);

        T Find(Expression<Func<T, bool>> predicado = null);
        void Add(T entity);
        void Update(T entity);
        void Remove(int id);
    }
    
}
