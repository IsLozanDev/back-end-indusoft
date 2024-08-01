public class GetSpArticuloServForPdf
{
    public int IdEmpresa { get; set; }
    public int IdArticulo { get; set; }
    public string NomArticulo { get; set; }
    public string NomArticuloEng { get; set; }
    public string NomArticuloLargo { get; set; }
    public string NomCorto { get; set; }
    public string? CodSerie { get; set; }
    public string IndCodBarra { get; set; }
    public string CodBarra { get; set; }
    public string CodBarra2 { get; set; }
    public string CodBarra3 { get; set; }
    public string CodBarra4 { get; set; }
    public string CodBarra5 { get; set; }
    public int CodTipoMedAlmacen { get; set; }
    public int CodUniMedAlmacen { get; set; }
    public int IdTipoMedEnvase { get; set; }
    public int IdUniMedEnvase { get; set; }
    public int CodTipoMedPresentacion { get; set; }
    public int CodUniMedPresentacion { get; set; }
    public string IndCodSunat { get; set; }
    public int IdTipoArticulo { get; set; }
    public string Nemo { get; set; }
    public string NomUMedidaEnv { get; set; }
    public string NomUMedidaPres { get; set; }
    public string CodCategoria { get; set; }
    public string FlagActivo { get; set; }
    public DateTime? FecCese { get; set; }
    public decimal Contenido { get; set; }
    public decimal Capacidad { get; set; }
    public decimal PesoUnitario { get; set; }
    public string IndLineaVenta { get; set; }
    public string CodLineaVenta { get; set; }
    public int IdTipo { get; set; }
    public string Combinar { get; set; }
    public string NombreReal { get; set; }
    public string NombreImagen { get; set; }
    public string Extension { get; set; }
    public string IndDetraccion { get; set; }
    public string TipDetraccion { get; set; }
    public string UsuarioRegistro { get; set; }
    public DateTime FechaRegistro { get; set; }
    public string UsuarioModificacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public string CodArticulo { get; set; }
    public string NumVerPlanCuentas { get; set; }
    public string CodCuentaAdm { get; set; }
    public string CodCuentaVta { get; set; }
    public string CodCuentaPro { get; set; }
    public int CodMarca { get; set; }
    public string? DesMarca { get; set; }
    public int CodModelo { get; set; }
    public string? DesModelo { get; set; }
    public string CodigoSunat { get; set; }
    public string IndAfectoIgv { get; set; }
    public int TipoAfectacion { get; set; }
    public string IndAfectoIsc { get; set; }
    public string IndConcepto { get; set; }
    public int IdConcepto { get; set; }
    public int IdArticuloBase { get; set; }
    public int IdPresentacion { get; set; }
    public string? DesConcepto { get; set; }
    public string? CodConcepto { get; set; }
    public string IndManejaUnmMayor { get; set; }
    public string IndManejaUnmMenor { get; set; }
    public string IndCodEquivalente { get; set; }
    public string CodEquivalente { get; set; }
    public string IndMedida { get; set; }
    public decimal Ancho { get; set; }
    public decimal Largo { get; set; }
    public decimal Calibre { get; set; }
    public decimal Gramaje { get; set; }
    public string DesColor { get; set; }
    public int CodColor { get; set; }
    public int IdFormato { get; set; }
    public int FactorEmpaque { get; set; }
}