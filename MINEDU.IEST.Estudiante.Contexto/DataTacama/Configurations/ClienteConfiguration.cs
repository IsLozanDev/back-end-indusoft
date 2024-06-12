﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using IDCL.Tacama.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace IDCL.Tacama.Core.Contexto.Configurations
{
    public partial class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.HasKey(e => new { e.IdPersona, e.IdEmpresa }).HasName("PK_Cliente_1");
            entity.ToTable("Cliente");
            entity.Property(e => e.IdPersona).HasColumnName("idPersona");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.Calificacion).HasDefaultValueSql("((388001))");
            entity.Property(e => e.CatCliente).HasColumnName("catCliente");
            entity.Property(e => e.FecBaja).HasColumnType("smalldatetime").HasColumnName("fecBaja");
            entity.Property(e => e.FecInicioEmpresa).HasColumnType("smalldatetime").HasColumnName("fecInicioEmpresa");
            entity.Property(e => e.FecInscripcion).HasColumnType("smalldatetime").HasColumnName("fecInscripcion");
            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime").HasDefaultValueSql("(getdate())");

            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

            entity.Property(e => e.IdCcostos).HasMaxLength(10).IsUnicode(false).HasColumnName("idCCostos");
            entity.Property(e => e.IndEstado).HasColumnName("indEstado").HasDefaultValueSql("((0))");
            entity.Property(e => e.IndVinculada).HasColumnName("indVinculada");

            entity.Property(e => e.SiglaComercial).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.TipConstitucion).HasColumnName("tipConstitucion").HasDefaultValueSql("('')");
            entity.Property(e => e.TipRegimen).HasColumnName("tipRegimen");

            entity.Property(e => e.UsuarioModificacion).HasMaxLength(20).IsUnicode(false).HasDefaultValueSql("('')");
            entity.Property(e => e.UsuarioRegistro).HasMaxLength(20).IsUnicode(false).HasDefaultValueSql("('')");
            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Clientes).HasForeignKey(d => d.IdPersona).HasConstraintName("FK_Cliente_Persona");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Cliente> entity);
    }
}