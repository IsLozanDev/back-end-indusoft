namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Articulo
{
    public class GetArticuloServicioPresentacionDto
    {
        public int IdPresentacion { get; set; }
        public string DesPresentacion { get; set; } = null!;
        public string DesPresentacionInterna { get; set; } = null!;
        public decimal Peso { get; set; }
        public decimal? PesoNeto { get; set; }
        public string? TipodePaleta { get; set; }
        public decimal? CajasPorPaleta { get; set; }
        public decimal? PaletaPorContenedor { get; set; }
        public decimal? CajasPorContenedor { get; set; }
    }
}
