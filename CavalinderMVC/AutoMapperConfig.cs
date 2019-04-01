using CavalinderMVC.Models;
using CavalinderMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CavalinderMVC
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.Initialize(
                cfg =>
                {
                    #region  Usuario 
                    cfg.CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
                    #endregion

                    #region  Horse 
                    cfg.CreateMap<Horse, HorseViewModel>().ReverseMap();
                    #endregion
                }
                );
        }
    }
}