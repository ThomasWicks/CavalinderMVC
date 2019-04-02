using CavalinderMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CavalinderMVC.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(u => u.Id);

            Property(u => u.fullname)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(u => u.email)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(u => u.password)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(u => u.bithday)
                    .IsRequired();

            Property(u => u.country)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(u => u.City)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(u => u.State)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(u => u.phone)
                    .IsRequired();

            Property(u => u.HarasName)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(u => u.password)
                    .IsRequired()
                    .HasMaxLength(150);

        }
    }
}