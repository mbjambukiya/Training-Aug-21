using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetSkilled.Repository
{
    public interface IGeneric<T> where T : class
    {
        IEnumerable<T> GetAllData();
        T GetDataById(int id);
        bool CreateData(T entity);
        bool UpdateData(T entity);
        bool DeleteData(int id);
        bool SaveData();
    }
}
