namespace IDCL.AVGUST.SIP.Entity.Tacama.SpEntity
{
    public class ObtenerTipoCambio
    {
        public string idMoneda { get; set; }
        public int idCambio { get; set; }
        public DateTime fecCambio { get; set; }
        public decimal valCompra { get; set; }
        public decimal valVenta { get; set; }
        public decimal valVentaCaja { get; set; }
        public decimal valCompraCaja { get; set; }
    }
}
