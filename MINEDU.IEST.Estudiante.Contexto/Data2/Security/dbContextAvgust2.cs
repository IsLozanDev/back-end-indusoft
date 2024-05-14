﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using IDCL.AVGUST.SIP.Contexto2.IDCL.AVGUST.SIP.Contexto2.Configurations;
using IDCL.AVGUST.SIP.Contexto2.IDCL.AVGUST.SIP.Entity.Avgust;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
#nullable enable

namespace IDCL.AVGUST.SIP.Contexto2.IDCL.AVGUST.SIP.Contexto2
{
    public partial class dbContextAvgust2 : DbContext
    {
        public dbContextAvgust2()
        {
        }

        public dbContextAvgust2(DbContextOptions<dbContextAvgust2> options)
            : base(options)
        {
        }

        public virtual DbSet<Opcion> Opcions { get; set; } = null!;
        public virtual DbSet<Perfil> Perfils { get; set; } = null!;
        public virtual DbSet<PerfilOpcion> PerfilOpcions { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<UsuarioPerfil> UsuarioPerfils { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.OpcionConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PerfilConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PerfilOpcionConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.UsuarioPerfilConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
