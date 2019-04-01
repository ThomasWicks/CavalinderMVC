using CavalinderMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CavalinderMVC.Data.EntityConfig
{
    public class HorseConfiguration : EntityTypeConfiguration<Horse>
    {
        public HorseConfiguration()
        {
            HasKey(h => h.Id);

            Property(h => h.HorseName)
                .IsRequired()
                .HasMaxLength(150);

            Property(h => h.HorseBreed)
                .IsRequired()
                .HasMaxLength(150);

            Property(h => h.HorseGender)
                .IsRequired()
                .HasMaxLength(150);

            Property(h => h.HorseAge)
                .IsRequired();

            HasRequired(h => h.Usuario)
                 .WithMany()
                 .HasForeignKey(h => h.UsuarioId);
        }
    }
}