using CavalinderMVC.Controllers.Interfaces;
using CavalinderMVC.Data.Context;
using CavalinderMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CavalinderMVC.Data.Repositories
{
    public class HorseRepository : GenericRepository<Horse>, IHorseRepository
    {
        private ApplicationContext _context;
        public HorseRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}