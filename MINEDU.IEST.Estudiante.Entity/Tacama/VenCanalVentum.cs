﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
namespace IDCL.Tacama.Core.Entity
{
    public partial class VenCanalVentum
    {
        public int IdEmpresa { get; set; }
        public int IdCanalVenta { get; set; }
        public string? NombreCanal { get; set; }
        public int? TipoCanal { get; set; }
        public int? ClaseCanal { get; set; }
        public string? Mercado { get; set; }
        public string? TipoCalculo { get; set; }
        public int? IdListaPrecio { get; set; }
        public bool? FlagListaActivo { get; set; }
        public int? GerenciaResponsable { get; set; }
        public int? TipAlmacen { get; set; }
        public int? IdAlmacen { get; set; }
        public bool? IndEstado { get; set; }
        public bool? IndBloqueaLista { get; set; }
        public bool? IndBloqueaAlmacen { get; set; }
        public decimal? MargenMenor { get; set; }
        public decimal? MargenMayor { get; set; }
        public bool? NoUsaAprobacionCredito { get; set; }
        public string? IndTipoPedido { get; set; }
        public string? UsuarioRegistro { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public ListaPrecioTacama? IdListaPrecioNav { get; set; }
        public PersonaTacama PersonaCanalVenta { get; set; }

    }
}