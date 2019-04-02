using CavalinderMVC.AppService.Interfaces;
using CavalinderMVC.Models;
using CavalinderMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CavalinderMVC.AppService
{
    public interface IUsuarioAppService : IGenericAppService<UsuarioViewModel>
    {
        List<string> Logar(UsuarioViewModelLogin obj);
        IEnumerable<Usuario> GetByName(string name);

    }
}
