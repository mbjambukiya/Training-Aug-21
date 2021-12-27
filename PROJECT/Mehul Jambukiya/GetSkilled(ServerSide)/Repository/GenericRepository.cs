using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.Entities;
using Microsoft.EntityFrameworkCore;

namespace GetSkilled.Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        protected readonly GetSkilledDbContext _context;
        protected readonly DbSet<T> table;
        public GenericRepository(GetSkilledDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public virtual bool CreateData(T entity)
        {
            table.Add(entity);
            return true;
        }

        public virtual bool DeleteData(int id)
        {
            var obj = table.Find(id);
            var result = table.Remove(obj);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual IEnumerable<T> GetAllData()
        {
            return table.ToList();
        }

        public virtual T GetDataById(int id)
        {
            return table.Find(id);
        }

        public virtual bool UpdateData(T entity)
        {
            var result = table.Update(entity);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool SaveData()
        {
            _context.SaveChanges();
            return true;
        }
    }
}
