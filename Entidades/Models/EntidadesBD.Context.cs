﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ingSoftwareEntitiesBD : DbContext
    {
        public ingSoftwareEntitiesBD()
            : base("name=ingSoftwareEntitiesBD")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AsignacionCatedratico> AsignacionCatedratico { get; set; }
        public virtual DbSet<AsignacionEstudiante> AsignacionEstudiante { get; set; }
        public virtual DbSet<AsignacionEvento> AsignacionEvento { get; set; }
        public virtual DbSet<Asistencia> Asistencia { get; set; }
        public virtual DbSet<AsistenciaDetalle> AsistenciaDetalle { get; set; }
        public virtual DbSet<Catedratico> Catedratico { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
    }
}
