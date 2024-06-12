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
    public partial class ComposicionConfiguration : IEntityTypeConfiguration<Composicion>
    {
        public void Configure(EntityTypeBuilder<Composicion> entity)
        {
            entity.HasKey(e => new { e.IdArticulo, e.Iditem });

            entity.ToTable("Composicion");

            entity.Property(e => e.IdArticulo).HasColumnName("idArticulo");

            entity.Property(e => e.Iditem).HasColumnName("iditem");

            entity.Property(e => e.FormuladorMolecular)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdArticuloNavigation)
                .WithMany(p => p.Composicions)
                .HasForeignKey(d => d.IdArticulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Composicion_Articulo");

            entity.HasOne(d => d.GrupoQuimicoNavegation)
                .WithMany(p => p.Composiciones)
                .HasForeignKey(d => d.idGrupoQuimico)
                .HasConstraintName("FK__Composici__idGru__76619304")
                .OnDelete(DeleteBehavior.Cascade);
                
            entity.HasOne(d => d.IngredienteActivoNavigation)
                .WithMany(p => p.Composicions)
                .HasForeignKey(d => d.IngredienteActivo)
                .HasConstraintName("FK_Composicion_IngredienteActivo");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Composicion> entity);
    }
}