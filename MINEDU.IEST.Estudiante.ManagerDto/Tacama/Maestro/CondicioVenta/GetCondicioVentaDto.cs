namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Maestro.CondicioVenta
{
    public class GetCondicioVentaDto
    {
        public int IdTipCondicion { get; set; }
        public int IdCondicion { get; set; }
        public string IdCondicionText { get; set; }
        public string? DesCondicion { get; set; }
        public string? DesCondicionIngles { get; set; }
        public int? IdClasificacion { get; set; }
        public string? DesDias { get; set; }
        public bool? GeneraLetra { get; set; }
        public bool? Credito { get; set; }
        public bool? SeCobra { get; set; }
        public bool? ManejaUnidad { get; set; }
        public bool? TGratuita { get; set; }
        public bool? ConImpuesto { get; set; }
        public bool? NcDescuentos { get; set; }
        public bool? TFilial { get; set; }
        public bool? IndCreditoCobranza { get; set; }
        public bool? IndDias { get; set; }
        public bool? TPromocion { get; set; }
        public int? IdListaPrecio { get; set; }
        public bool? FlagListaActivo { get; set; }
        public bool? IndIngreso { get; set; }
    }
}
