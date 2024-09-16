namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Articulo
{
    public class GetArticuloSearchPedidoApiDto
    {
        public int idArticulo { get; set; }
        public string codArticulo { get; set; }
        public string nomArticulo { get; set; }
        public int idTipoArticulo { get; set; }
        public double Contenido { get; set; }
        public double Capacidad { get; set; }
        public int codTipoMedAlmacen { get; set; }
        public int codUniMedAlmacen { get; set; }
        public int idTipoMedEnvase { get; set; }
        public int idUniMedEnvase { get; set; }
        public int codTipoMedPresentacion { get; set; }
        public int codUniMedPresentacion { get; set; }
        public double Stock { get; set; }
        public double StockFisico { get; set; }
        public double StockComprometido { get; set; }
        public string Lote { get; set; }
        public int TipoAfectacion { get; set; }
        public string indAfectoIsc { get; set; }
        public string indAfectoIgv { get; set; }
        public string numVerPlanCuentas { get; set; }
        public string codCuentaAdm { get; set; }
        public string codCuentaVta { get; set; }
        public string codCuentaPro { get; set; }
        public string indManejaUnmMayor { get; set; }
        public string indManejaUnmMenor { get; set; }
        public string nomUMedida { get; set; }
        public string nomUMedidaEnv { get; set; }
        public string nomUMedidaPres { get; set; }
        public double PrecioBruto { get; set; }
        public double PorDscto1 { get; set; }
        public double PorDscto2 { get; set; }
        public double PorDscto3 { get; set; }
        public double MontoDscto1 { get; set; }
        public double MontoDscto2 { get; set; }
        public double MontoDscto3 { get; set; }
        public double PrecioValorVenta { get; set; }
        public string flgisc { get; set; }
        public string TipoImpSelectivo { get; set; }
        public double porisc { get; set; }
        public double isc { get; set; }
        public string flgigv { get; set; }
        public double porigv { get; set; }
        public double igv { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioVentaConte { get; set; }
        public double PrecioBrutoConte { get; set; }
        public string indDetraccion { get; set; }
        public string tipDetraccion { get; set; }
        public string LoteProveedor { get; set; }
        public DateTime FechaPrueba { get; set; }
        public string LoteAlmacen { get; set; }
        public double PesoUnitario { get; set; }
        public string codBarra { get; set; }
        public string codBarra2 { get; set; }
        public string codBarra3 { get; set; }
        public string codBarra4 { get; set; }
        public string codBarra5 { get; set; }
    }
}
