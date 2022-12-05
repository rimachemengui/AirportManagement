using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class Services <T> :IServices<T> where T : class
    {
        IRepository<T> repo;
       
        readonly IUnitOfWork unitOfWork;
        public Services(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }

        public void Add(T obj)
        {
            repo.Add(obj);
            unitOfWork.Save();
        }

        public T Get(int id)
        {
            return repo.Get(id);
        }

        public void Update(T obj)
        {
            repo.Update(obj);
            unitOfWork.Save();
        }

        public void Delete(T obj)
        {
            repo.Delete(obj);
            unitOfWork.Save();
        }

        public IList<T> GetAll()
        {return repo.GetAll();
        }
    }
}
