namespace IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure
{
    public class usp_ApiListarVendedorCanal
    {
        public int idAlmacen { get; set; }
        public int idCanalVenta { get; set; }
        public int idListaPrecio { get; set; }
        public string nombreCanal { get; set; }
        public string nomListaPrecio { get; set; }
        public string Mercado { get; set; }
        public List<usp_ApiListarCanalVentaAlmacen> almacenes { get; set; }


    }
}