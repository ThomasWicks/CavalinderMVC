using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CavalinderMVC.ViewModel
{
    public class HorseViewModel
    {
        public int Id { get; set; }
        public string HorseName { get; set; }
        public int HorseAge { get; set; }
        public string HorseGender { get; set; }
        public string HorseBreed { get; set; }
        public int UsuarioId { get; set; }
    }
}