using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day17_Assignment.Repository
{
    public interface IGenericRepository<T> where T : class
    {
            IEnumerable<T> GetAllData();
            T GetDataById(int id);
            bool CreateData(T entity);
            bool UpdateData(int id, T entity);
            bool DeleteData(int id);
    }
}
