namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Articulo
{
    public  class GetArticuloTacamaCategoriaDto
    {
        
        public string CodCategoria { get; set; } = null!;        
        public string NombreCategoria { get; set; } = null!;        
        public int NumNivel { get; set; }        
        public string IndUltimoNivel { get; set; } = null!;        
        public string? CodCategoriaSup { get; set; }        
        public bool? IndCuenta { get; set; }        
        public string? NumVerPlanCuentas { get; set; }        
        public string? CodCuentaAdm { get; set; }        
        public string? CodCuentaVta { get; set; }        
        public string? CodCuentaPro { get; set; }        
        public string? CodCuentaConsumo { get; set; }        
        public string? CodCuentaVenta { get; set; }        
        public string? CodCuentaVenta12 { get; set; }        
        public string? CodCuentaCompra { get; set; }        
        public string? CodCuentaPorRecibir { get; set; }        
        public string? CodCuentaVentaRelacionada { get; set; }
        public string? CodCuentaVentaDscto { get; set; }        
        public int? IdTipoArticuloAsoc { get; set; }        
        public string? CodCategoriaAsoc { get; set; }        
        public bool? IndManejaUnmMayor { get; set; }        
        public bool IndManejaUnmMenor { get; set; }        
    }
}
