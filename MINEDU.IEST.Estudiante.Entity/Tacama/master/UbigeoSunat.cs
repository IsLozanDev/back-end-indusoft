﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System.ComponentModel.DataAnnotations.Schema;

namespace IDCL.Tacama.Core.Entity.Tacama.master
{
    public partial class UbigeoSunat
    {
        public string IdUbigeo { get; set; } = null!;
        public string Departamento { get; set; } = null!;
        public string Provincia { get; set; } = null!;
        public string Distrito { get; set; } = null!;
        public string? CodPostal { get; set; }
        public bool? IndBaja { get; set; }
        public int? IdPais { get; set; }
        public string UsuarioRegistro { get; set; } = null!;
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModificacion { get; set; } = null!;
        public DateTime FechaModificacion { get; set; }

        [NotMapped]
        public string description { get; set; }
    }
}