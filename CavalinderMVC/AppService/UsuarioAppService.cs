using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using CavalinderMVC.Controllers.Interfaces;
using CavalinderMVC.ViewModel;

namespace CavalinderMVC.AppService
{
    public class UsuarioAppService : GenericAppService, IUsuarioAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioAppService(IUnitOfWork uow, IUsuarioRepository usuarioRepository)
            : base(uow)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<string> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioViewModel> Get(Expression<Func<UsuarioViewModel, bool>> filter = null, Expression<Func<IQueryable<UsuarioViewModel>, IOrderedQueryable<UsuarioViewModel>>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public UsuarioViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<string> Insert(UsuarioViewModel obj)
        {
            throw new NotImplementedException();
        }

        public List<string> Update(UsuarioViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}