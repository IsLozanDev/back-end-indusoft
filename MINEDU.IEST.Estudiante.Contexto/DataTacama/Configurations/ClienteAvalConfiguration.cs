﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using IDCL.Tacama.Core.Entity.Tacama.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace IDCL.Tacama.Core.Contexto.Configurations
{
    public partial class ClienteAvalConfiguration : IEntityTypeConfiguration<ClienteAval>
    {
        public void Configure(EntityTypeBuilder<ClienteAval> entity)
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdPersona, e.IdAval })
                .HasName("PK__ClienteA__7C4DE068BB263A3E");

            entity.ToTable("ClienteAval");

            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

            entity.Property(e => e.IdPersona).HasColumnName("idPersona");

            entity.Property(e => e.IdAval).HasColumnName("idAval");

            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

            entity.Property(e => e.NroDocumento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nroDocumento");

            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Telefonos)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Id)
                .WithMany(p => p.ClienteAvals)
                .HasForeignKey(d => new { d.IdPersona, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cliente_ClienteAval");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ClienteAval> entity);
    }
}
