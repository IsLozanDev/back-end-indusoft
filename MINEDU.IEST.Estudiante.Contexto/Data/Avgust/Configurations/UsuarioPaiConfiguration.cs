﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using IDCL.AVGUST.SIP.Contexto.IDCL.AVGUST.SIP.Contexto;
using IDCL.AVGUST.SIP.Contexto.IDCL.AVGUST.SIP.Entity.Avgust;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace IDCL.AVGUST.SIP.Contexto.IDCL.AVGUST.SIP.Contexto.Configurations
{
    public partial class UsuarioPaiConfiguration : IEntityTypeConfiguration<UsuarioPai>
    {
        public void Configure(EntityTypeBuilder<UsuarioPai> entity)
        {
            entity.HasKey(e => new { e.IdUsuario, e.IdPais });

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

            entity.Property(e => e.IdPais).HasColumnName("idPais");

            entity.Property(e => e.PorDefault).HasColumnName("porDefault");

            entity.HasOne(d => d.IdPaisNavigation)
                .WithMany(p => p.UsuarioPais)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioPais_Pais");

            entity.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.UsuarioPais)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioPais_Usuario");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<UsuarioPai> entity);
    }
}
