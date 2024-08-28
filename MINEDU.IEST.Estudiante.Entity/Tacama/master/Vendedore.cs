﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System.ComponentModel.DataAnnotations.Schema;

namespace IDCL.Tacama.Core.Entity.Tacama.master
{
    public partial class Vendedore
    {
        public int IdPersona { get; set; }
        public int IdEmpresa { get; set; }
        public int? IdVendedor { get; set; }
        public string? CodVendedor { get; set; }
        public bool? IndEstado { get; set; }
        public DateTime? FecBaja { get; set; }
        public bool? IndSupervisor { get; set; }
        public bool? ManejaCartera { get; set; }
        public int? IdDivision { get; set; }
        public int? IdEstablecimiento { get; set; }
        public int? IdZona { get; set; }
        public string? Cargo { get; set; }
        public string? NombreCotizacion { get; set; }
        public string? TipoVendedor { get; set; }
        public string? UsuarioRegistro { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        [NotMapped]
        public Establecimiento? IdEstablecimientoNavigation { get; set; }
        [NotMapped]
        public VenDivision? IdDivisionNavigation { get; set; }
        [NotMapped]
        public ZonaTrabajo? IdZonaNavigation { get; set; }
    }
}