using CavalinderMVC.AppService;
using CavalinderMVC.AppService.Interfaces;
using CavalinderMVC.Controllers;
using CavalinderMVC.Controllers.Interfaces;
using CavalinderMVC.Data;
using CavalinderMVC.Data.Repositories;
using CavalinderMVC.Models;
using CavalinderMVC.Service;
using SimpleInjector;

namespace CavalinderMVC.IoC
{
    public static class BootStrapper
    {
        public static Container Register(Container container, Lifestyle hybridLifestyle)
        {
            #region APP
            container.Register<IUsuarioAppService, UsuarioAppService>(hybridLifestyle);
            container.Register<IHorseAppService, HorseAppService>(hybridLifestyle);
            #endregion

            #region Service
            container.Register<IGenericService<Usuario>, GenericService<Usuario>>(hybridLifestyle);
            #endregion

            #region Infra_Data
            container.Register<IUsuarioRepository, UsuarioRepository>(hybridLifestyle);
            container.Register<IHorseRepository, HorseRepository>(hybridLifestyle);
            container.Register<IUnitOfWork, UnitOfWork>(hybridLifestyle);
            container.Register<IGenericRepository<Usuario>, GenericRepository<Usuario>>(hybridLifestyle);


            #endregion



            container.Register<ApplicationContext>(hybridLifestyle);

            return container;
        }
    }
}