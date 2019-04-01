using CavalinderMVC.AppService.Interfaces;
using CavalinderMVC.Controllers.Interfaces;
using CavalinderMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CavalinderMVC.AppService
{
    public class HorseAppService : GenericAppService, IHorseAppService
    {
        private readonly IHorseRepository _horseRepository;

        public HorseAppService(IUnitOfWork uow, IHorseRepository horseRepository)
            : base(uow)
        {
            _horseRepository = horseRepository;
        }

        public List<string> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HorseViewModel> Get(Expression<Func<HorseViewModel, bool>> filter = null, Expression<Func<IQueryable<HorseViewModel>, IOrderedQueryable<HorseViewModel>>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HorseViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public HorseViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> Insert(HorseViewModel obj)
        {
            throw new NotImplementedException();
        }

        public List<string> Update(HorseViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}