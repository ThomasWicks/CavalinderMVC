using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CavalinderMVC.Models
{
    public class Horse
    {
        public int Id { get; set; }
        public string HorseName { get; set; }
        public int HorseAge { get; set; }
        public string HorseGender { get; set; }
        public string HorseBreed { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}