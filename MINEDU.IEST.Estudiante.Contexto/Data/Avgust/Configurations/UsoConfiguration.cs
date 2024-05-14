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
    public partial class UsoConfiguration : IEntityTypeConfiguration<Uso>
    {
        public void Configure(EntityTypeBuilder<Uso> entity)
        {
            entity.HasKey(e => new { e.IdArticulo, e.IdItem });

            entity.Property(e => e.IdArticulo).HasColumnName("idArticulo");

            entity.Property(e => e.IdItem).HasColumnName("idItem");

            entity.Property(e => e.Dosis)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IdCultivo).HasColumnName("idCultivo");

            entity.Property(e => e.IdNomCientificoPlaga).HasColumnName("idNomCientificoPlaga");

            entity.Property(e => e.NombreCientificoCultivo)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdArticuloNavigation)
                .WithMany(p => p.Usos)
                .HasForeignKey(d => d.IdArticulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usos_Articulo");

            entity.HasOne(d => d.IdCultivoNavigation)
                .WithMany(p => p.Usos)
                .HasForeignKey(d => d.IdCultivo)
                .HasConstraintName("FK_Usos_Cultivo");

            entity.HasOne(d => d.IdNomCientificoPlagaNavigation)
                .WithMany(p => p.Usos)
                .HasForeignKey(d => d.IdNomCientificoPlaga)
                .HasConstraintName("FK_Usos_CientificoPlaga");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Uso> entity);
    }
}
