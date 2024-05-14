﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using IDCL.AVGUST.SIP.Entity.Calculator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace IDCL.AVGUST.SIP.Contextos.IDCL.AVGUST.SIP.Contexto.Configurations
{
    public partial class ListaPrecioItemConfiguration : IEntityTypeConfiguration<ListaPrecioItem>
    {
        public void Configure(EntityTypeBuilder<ListaPrecioItem> entity)
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdListaPrecio, e.Item });

            entity.ToTable("ListaPrecioItem");

            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

            entity.Property(e => e.IdListaPrecio).HasColumnName("idListaPrecio");

            entity.Property(e => e.Item)
                .ValueGeneratedOnAdd()
                .HasColumnName("item");

            entity.Property(e => e.Capacidad).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.Contenido).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.FechaModificacion).HasColumnType("smalldatetime");

            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

            entity.Property(e => e.Flgigv)
                .HasColumnName("flgigv")
                .HasComment("1=Activo, 0 = No Activo");

            entity.Property(e => e.Flgisc)
                .HasColumnName("flgisc")
                .HasComment("1= Activo , 0 = No Activo");

            entity.Property(e => e.Flgpromocion).HasColumnName("flgpromocion");

            entity.Property(e => e.IdArticulo)
                .HasColumnName("idArticulo")
                .HasComment("Articulo");

            entity.Property(e => e.IdTipoArticulo)
                .HasColumnName("idTipoArticulo")
                .HasComment("Tipo de Articulos");

            entity.Property(e => e.Igv)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("igv");

            entity.Property(e => e.Isc)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("isc");

            entity.Property(e => e.MontoDscto1).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.MontoDscto2).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.MontoDscto3).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.PorDscto1).HasColumnType("decimal(5, 2)");

            entity.Property(e => e.PorDscto2).HasColumnType("decimal(5, 2)");

            entity.Property(e => e.PorDscto3).HasColumnType("decimal(5, 2)");

            entity.Property(e => e.Porigv)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("porigv");

            entity.Property(e => e.Porisc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("porisc")
                .HasComment("25%,2.50 x Litro, N = 0");

            entity.Property(e => e.PrecioBruto).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.PrecioBrutoConte).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.PrecioValorVenta).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.PrecioVentaConte).HasColumnType("decimal(10, 2)");

            entity.Property(e => e.TipoImpSelectivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("P=Porcentaje,L=Litro,N=Ninguno");

            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Id)
                .WithMany(p => p.ListaPrecioItems)
                .HasForeignKey(d => new { d.IdEmpresa, d.IdArticulo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListaPrecioItem_ArticuloServ");

            entity.HasOne(d => d.IdNavigation)
                .WithMany(p => p.ListaPrecioItems)
                .HasForeignKey(d => new { d.IdEmpresa, d.IdListaPrecio })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListaPrecioItem_ListaPrecio");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ListaPrecioItem> entity);
    }
}
