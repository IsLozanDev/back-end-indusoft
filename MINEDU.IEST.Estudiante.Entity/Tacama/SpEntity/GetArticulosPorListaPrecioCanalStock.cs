namespace IDCL.AVGUST.SIP.Entity.Tacama.SpEntity
{
    public class GetArticulosPorListaPrecioCanalStock
    {
        public int IdArticulo { get; set; }
        public string CodArticulo { get; set; }
        public string NomArticulo { get; set; }
        public int IdTipoArticulo { get; set; }
        public double Contenido { get; set; }
        public double Capacidad { get; set; }
        public int CodTipoMedAlmacen { get; set; }
        public int CodUniMedAlmacen { get; set; }
        public int IdTipoMedEnvase { get; set; }
        public int IdUniMedEnvase { get; set; }
        public int CodTipoMedPresentacion { get; set; }
        public int CodUniMedPresentacion { get; set; }
        public double Stock { get; set; }
        public double StockFisico { get; set; }
        public double StockComprometido { get; set; }
        public string Lote { get; set; }
        public int TipoAfectacion { get; set; }
        public string IndAfectoIsc { get; set; }
        public string IndAfectoIgv { get; set; }
        public string NumVerPlanCuentas { get; set; }
        public string CodCuentaAdm { get; set; }
        public string CodCuentaVta { get; set; }
        public string CodCuentaPro { get; set; }
        public string IndManejaUnmMayor { get; set; }
        public string IndManejaUnmMenor { get; set; }
        public string NomUMedida { get; set; }
        public string NomUMedidaEnv { get; set; }
        public string NomUMedidaPres { get; set; }
        public double PrecioBruto { get; set; }
        public double PorDscto1 { get; set; }
        public double PorDscto2 { get; set; }
        public double PorDscto3 { get; set; }
        public double MontoDscto1 { get; set; }
        public double MontoDscto2 { get; set; }
        public double MontoDscto3 { get; set; }
        public double PrecioValorVenta { get; set; }
        public string Flgisc { get; set; }
        public string TipoImpSelectivo { get; set; }
        public double Porisc { get; set; }
        public double Isc { get; set; }
        public string Flgigv { get; set; }
        public double Porigv { get; set; }
        public double Igv { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioVentaConte { get; set; }
        public double PrecioBrutoConte { get; set; }
        public string IndDetraccion { get; set; }
        public string TipDetraccion { get; set; }
        public string LoteProveedor { get; set; }
        public DateTime FechaPrueba { get; set; }
        public string LoteAlmacen { get; set; }
        public double PesoUnitario { get; set; }
        public string CodBarra { get; set; }
        public string CodBarra2 { get; set; }
        public string CodBarra3 { get; set; }
        public string CodBarra4 { get; set; }
        public string CodBarra5 { get; set; }
    }
}
