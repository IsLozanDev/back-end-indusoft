﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using IDCL.Tacama.Core.Entity.Tacama.master;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace IDCL.Tacama.Core.Contexto.Configurations
{
    public partial class AfectacionIgvConfiguration : IEntityTypeConfiguration<AfectacionIgv>
    {
        public void Configure(EntityTypeBuilder<AfectacionIgv> entity)
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdAfectacion });

            entity.ToTable("AfectacionIgv");

            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

            entity.Property(e => e.IdAfectacion).HasColumnName("idAfectacion");

            entity.Property(e => e.DesAfectacion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EquivalenciaSunat)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.FecBaja)
                .HasColumnType("smalldatetime")
                .HasColumnName("fecBaja");

            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

            entity.Property(e => e.IndEstado)
                .HasColumnName("indEstado")
                .HasComment("0=Activo 1=De baja");

            entity.Property(e => e.IndIgv).HasColumnName("indIgv");

            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(20)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AfectacionIgv> entity);
    }
}
