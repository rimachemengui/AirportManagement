using AM.Core.Domain;
using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class PlaneService : Services<Plane>, IPlaneService
    {
        IRepository<Plane> repo;
        private IRepository<Plane> planeRepo;
        readonly IUnitOfWork unitOfWork;
        public PlaneService(IUnitOfWork unitOfWork)
        {
            //this.unitOfWork = unitOfWork;
            //repo = unitOfWork.GetRepository<Plane>();

        }

       /* public PlaneService(IRepository<Plane> planeRepo)
        {
            this.planeRepo = planeRepo;
        }

        public void Add(Plane plane)
        {
            repo.Add(plane);
            //repo.Save();
            unitOfWork.Save();
        }

        public void Delete(Plane plane)
        {

            repo.Delete(plane);
            //repo.Save();
            unitOfWork.Save();
        }

        public IList<Plane> GetAll()
        {
            return repo.GetAll();
        }
    }*/
}
