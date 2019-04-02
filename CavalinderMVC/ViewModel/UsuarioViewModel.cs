using CavalinderMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CavalinderMVC.ViewModel
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime bithday { get; set; }
        public string country { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public Double phone { get; set; }
        public string HarasName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Usuario usuario { get; set; }
    }

    public class UsuarioViewModelLogin
    {
        public string email { get; set; }
        public string password { get; set; }
    }
}