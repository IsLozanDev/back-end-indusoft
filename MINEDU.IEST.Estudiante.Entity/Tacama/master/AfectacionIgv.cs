﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
namespace IDCL.Tacama.Core.Entity.Tacama.master
{
    public partial class AfectacionIgv
    {
        public int IdEmpresa { get; set; }
        public int IdAfectacion { get; set; }
        public string? DesAfectacion { get; set; }
        public string? EquivalenciaSunat { get; set; }
        public bool? IndIgv { get; set; }
        /// <summary>
        /// 0=Activo 1=De baja
        /// </summary>
        public bool? IndEstado { get; set; }
        public DateTime? FecBaja { get; set; }
        public string? UsuarioRegistro { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}