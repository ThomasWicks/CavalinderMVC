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
            return AutoMapper.Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.Get(AutoMapper.Mapper.Map<Expression<Func<UsuarioViewModel, bool>>, Expression<Func<Usuario, bool>>>(filter), null, string.Empty));
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            return AutoMapper.Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.GetAll());
        }

        public UsuarioViewModel GetById(int id)
        {
            return AutoMapper.Mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.GetById(id));
        }

        public IEnumerable<Usuario> GetByName(string name)
        {
            Expression<Func<Usuario, bool>> filter =
                (Usuario e) => e.email == name;
            return _usuarioService.Get(filter);
        }

        //public List<string> Logar(UsuarioViewModelLogin obj)
        //{
        //    List<string> errors = new List<string>();
        //    UsuarioViewModel usuarioViewModel = AutoMapper.Mapper.Map<UsuarioViewModelLogin, UsuarioViewModel>(obj);
        //    Usuario usuario = AutoMapper.Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);
        //    usuario = GetByName(usuario.email).First();
        //    try
        //    {
        //        if(usuario.password == obj.password && usuario.email == obj.email)
        //        {
        //            return errors;
        //        }
        //        else
        //        {
        //            errors.Add("Email ou senha incorretos");
        //            return errors;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Rollback();
        //        errors.Add("Ocorreu um erro no Login");
        //        return errors;
        //    }
        //}

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