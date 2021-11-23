using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day17_Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Day17_Assignment.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly HealthCareDbContext _context;
        public GenericRepository(HealthCareDbContext context)
        {
            _context = context;
        }
        public virtual bool CreateData(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return true;
        }

        public virtual bool DeleteData(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<T> GetAllData()
        {
            return _context.Set<T>();
        }

        public T GetDataById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual bool UpdateData(int id, T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
    }
}
