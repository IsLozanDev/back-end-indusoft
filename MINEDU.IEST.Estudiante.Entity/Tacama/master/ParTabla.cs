﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
namespace IDCL.Tacama.Core.Entity.Tacama.master
{
    public partial class ParTabla
    {
        public int IdParTabla { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Nemotecnico { get; set; } = null!;
        public int Grupo { get; set; }
        public bool EsEditable { get; set; }
        public string EquivalenciaSunat { get; set; } = null!;
        public bool Estado { get; set; }
        public string? ValorCadena { get; set; }
        public int? ValorEntero { get; set; }
        public bool? FlagCorrelativo { get; set; }
        public string UsuarioRegistro { get; set; } = null!;
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }
    }
}