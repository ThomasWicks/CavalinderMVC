using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using CavalinderMVC.Controllers.Interfaces;
using CavalinderMVC.Models;
using CavalinderMVC.Service;
using CavalinderMVC.ViewModel;

namespace CavalinderMVC.AppService
{
    public class UsuarioAppService : GenericAppService, IUsuarioAppService
    {
        private readonly IGenericService<Usuario> _usuarioService;

        public UsuarioAppService(IUnitOfWork uow, IGenericService<Usuario> usuarioService)
            : base(uow)
        {
            _usuarioService = usuarioService;
        }

        public List<string> Delete(int id)
        {
            List<string> errors = new List<string>();

            try
            {
                



                BeginTransaction();
                errors = _usuarioService.Delete(id);
                if (errors?.Count() == 0)
                {
                    SaveChanges();
                    Commit();

                }
            }
            catch (Exception e)
            {
                Rollback();
                errors.Add("Ocorreu um erro no Cadastro");
            }
            return errors;

        }
    

        public IEnumerable<UsuarioViewModel> Get(Expression<Func<UsuarioViewModel, bool>> filter = null, Expression<Func<IQueryable<UsuarioViewModel>, IOrderedQueryable<UsuarioViewModel>>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            return AutoMapper.Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.GetAll());
        }

        public UsuarioViewModel GetById(int id)
        {
            return AutoMapper.Mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.GetById(id));
        }

        public List<string> Insert(UsuarioViewModel obj)
        {
            List<string> errors = new List<string>();
            try
            {

                Usuario usuario = AutoMapper.Mapper.Map<UsuarioViewModel, Usuario>(obj);
                if (errors?.Count > 0)
                {
                    return errors;
                }
                else
                {
                    BeginTransaction();
                    errors = _usuarioService.Insert(usuario);
                    if (errors?.Count() == 0)
                    {
                        SaveChanges();
                        Commit();
                    }
                }
            }
            catch (Exception e)
            {
                Rollback();
                errors.Add("Ocorreu um erro no Cadastro");
            }
            return errors;
        }

        public List<string> Update(UsuarioViewModel obj)
        {
            List<string> errors = new List<string>();
            try
            {

                Usuario usuario = AutoMapper.Mapper.Map<UsuarioViewModel, Usuario>(obj);
                if (errors?.Count > 0)
                {
                    return errors;
                }
                else
                {
                    BeginTransaction();
                    errors = _usuarioService.Update(usuario);
                    if (errors?.Count() == 0)
                    {
                        SaveChanges();
                        Commit();
                    }
                }
            }
            catch (Exception e)
            {
                Rollback();
                errors.Add("Ocorreu um erro no Cadastro");
            }
            return errors;
        }
    }
}