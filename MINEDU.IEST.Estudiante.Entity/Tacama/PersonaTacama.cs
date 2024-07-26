﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
namespace IDCL.Tacama.Core.Entity
{
    public partial class PersonaTacama
    {
        public int IdPersona { get; set; }
        public int TipoPersona { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string Ruc { get; set; }
        public string? ApePaterno { get; set; }
        public string? ApeMaterno { get; set; }
        public string? Nombres { get; set; }
        public int? TipoDocumento { get; set; }
        public string? NroDocumento { get; set; }
        public string? Telefonos { get; set; }
        public string? Fax { get; set; }
        public string? Correo { get; set; }
        public string? Web { get; set; }
        public string? DireccionCompleta { get; set; }
        public int? IdPais { get; set; }
        public string? IdUbigeo { get; set; }
        public bool? PrincipalContribuyente { get; set; }
        public bool? AgenteRetenedor { get; set; }
        public int? IdCanalVenta { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModificacion { get; set; }

        public List<Cliente> Clientes { get; set; }
        public List<PersonaDireccion> PersonaDireccions { get; set; }
        public List<VenCanalVentum>? CanalesVenta { get; set; }

    }
}