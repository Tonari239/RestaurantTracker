using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RestaurantTracker.DataLayer.Repositories
{
    public abstract class CRUDrepository<T> where T : class
    {
        private readonly RestaurantDbContext _context;
        public DbSet<T> _dbSet;
        public CRUDrepository(RestaurantDbContext cont, DbSet<T> dbSet)
        {
            this._context = cont;
            this._dbSet = dbSet;
        }

        //Basic CRUD
        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).AsQueryable();
        }

        public bool Add(T item)
        {
            if (_dbSet.Contains(item))
            {
                return false;
            }
            _dbSet.Add(item);
            _context.SaveChanges();
            return true;
        }

        public bool Remove(T item)
        {
            if (!_dbSet.Contains(item))
            {
                return false;
            }
            _dbSet.Remove(item);
            _context.SaveChanges();
            return true;
        }


        public void Update(T item)
        {
            _context.Entry<T>(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IQueryable<T> OrderBy(Expression<Func<T, bool>> expression)
        {
            return _dbSet.OrderBy(expression).AsQueryable();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).FirstOrDefault();
        }


    }
}
