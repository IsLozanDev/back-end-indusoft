﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
namespace IDCL.Tacama.Core.Entity.Tacama.Customer
{
    public partial class ClienteAseguradora
    {
        public int IdPersona { get; set; }
        public int IdEmpresa { get; set; }
        public int IdItem { get; set; }
        public DateTime? Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public int? IdAseguradora { get; set; }
        public string? IdMoneda { get; set; }
        public decimal? Monto { get; set; }
        public string? UsuarioRegistro { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Cliente Id { get; set; } = null!;
    }
}