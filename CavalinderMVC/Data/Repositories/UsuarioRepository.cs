using CavalinderMVC.Controllers.Interfaces;
using CavalinderMVC.Data.Context;
using CavalinderMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using Dapper;

namespace CavalinderMVC.Data.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        private ApplicationContext _context;
        public UsuarioRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}