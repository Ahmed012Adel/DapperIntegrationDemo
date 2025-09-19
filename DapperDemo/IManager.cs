using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    internal interface IManager<T>
    {
        List<T> GetAll();
        T? GetById(int id);
        bool Add (T entity);
        bool Update(T item);
        bool Delete(int id);
    }
}
