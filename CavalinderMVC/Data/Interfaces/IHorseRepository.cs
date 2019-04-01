using CavalinderMVC.Data.Context;
using CavalinderMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CavalinderMVC.Controllers.Interfaces
{
    public interface IHorseRepository : IGenericRepository<Horse>
    {
    }
}