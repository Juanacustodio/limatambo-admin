using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using LimatamboAdmin.Models;

namespace LimatamboAdmin.DAL
{
    public class LimatamboContext : DbContext
    {
        public LimatamboContext() : base("limatambo")
        {
        }

        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<EspecialidadPorSede> EspecialidadPorSedes { get; set; }
        public DbSet<Sede> Sede { get; set; }
        public DbSet<Medico> Medicos { get; set; }


        public DbSet<Admin> Admin { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<LimatamboAdmin.Models.Consultorio> Consultorios { get; set; }

        public System.Data.Entity.DbSet<LimatamboAdmin.Models.Paciente> Pacientes { get; set; }
    }
}