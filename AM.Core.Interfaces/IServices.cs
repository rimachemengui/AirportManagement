using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Interfaces
{
    public interface IServices<T> where T : class
    {
        void Add(T obj);
        T Get(int id);
        void Update(T obj);
        void Delete(T obj);
        IList<T> GetAll();
    }
}
