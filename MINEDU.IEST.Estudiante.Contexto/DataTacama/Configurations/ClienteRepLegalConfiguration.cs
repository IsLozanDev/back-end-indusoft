﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using IDCL.Tacama.Core.Entity.Tacama.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace IDCL.Tacama.Core.Contexto.Configurations
{
    public partial class ClienteRepLegalConfiguration : IEntityTypeConfiguration<ClienteRepLegal>
    {
        public void Configure(EntityTypeBuilder<ClienteRepLegal> entity)
        {
            entity.HasKey(e => new { e.IdPersona, e.IdEmpresa, e.IdItem });

            entity.ToTable("ClienteRepLegal");

            entity.Property(e => e.IdPersona).HasColumnName("idPersona");

            entity.Property(e => e.IdItem)
                .ValueGeneratedOnAdd()
                .HasColumnName("idItem");

            entity.Property(e => e.ApeMaterno).HasMaxLength(50);

            entity.Property(e => e.ApePaterno).HasMaxLength(50);

            entity.Property(e => e.Extension)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.Property(e => e.NombreImagen)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NombreReal)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nombres).HasMaxLength(50);

            entity.Property(e => e.NroDoc).HasMaxLength(25);

            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Id)
                .WithMany(p => p.ClienteRepLegals)
                .HasForeignKey(d => new { d.IdPersona, d.IdEmpresa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteRepLegal_Cliente");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ClienteRepLegal> entity);
    }
}
