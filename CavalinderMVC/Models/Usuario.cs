using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CavalinderMVC.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        //[DataType(DataType.DateTime)]
        //public DateTime bithday { get; set; }
        public string country { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public Double phone { get; set; }
        public string HarasName { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual IEnumerable<Horse> Horses { get; set; }
    }
}