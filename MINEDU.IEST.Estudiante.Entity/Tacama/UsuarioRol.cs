﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable

namespace IDCL.Tacama.Core.Entity
{
    public partial class UsuarioRol
    {
        public int IdPersona { get; set; }
        public int IdRol { get; set; }
        public int IdEmpresa { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string UsuarioActualizacion { get; set; }

        public UsuarioTacama IdPersonaNavigation { get; set; }
        public Rol IdRolNavigation { get; set; }
    }
}