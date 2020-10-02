using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTestSemma.core
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        private DbContext _context;
        private DbSet<T> _dbSet;

        public RepositoryBase(DbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<T>();
        }
        public void Add(T entity)
        {
            this._dbSet.Add(entity);
        }

        public IEnumerable<T> All()
        {
            return this._dbSet.ToList();
        }

        public T Find(System.Linq.Expressions.Expression<Func<T, bool>> predicado = null)
        {
            return this._dbSet.Find(predicado);
        }

        public T GetById(int id)
        {
            return this._dbSet.Find(id);
        }

        public void Remove(int id)
        {
            var item= this._dbSet.Find(id);
            this._dbSet.Remove(item);
        }

        public void Update(T entity)
        {
            this._dbSet.Attach(entity);
            this._context.Entry(entity).State = EntityState.Modified;
        }
   
    }
}
