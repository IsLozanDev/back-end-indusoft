namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente.Cmd
{
    public class CmdPersonaDireccionDto
    {
        public string DescripcionSucursal { get; set; } = null!;
        public string? CodUbigeo { get; set; }
        public int? TipoDireccion { get; set; }
        public int? TipoVia { get; set; }
        public string? NombreVia { get; set; }
        public int? TipoZona { get; set; }
        public string? NombreZona { get; set; }
        public string? NroVia { get; set; }
        public string? Manzana { get; set; }
        public string? Interior { get; set; }
        public string? Lote { get; set; }
        public string? Referencia { get; set; }
        public string DireccionCompleta { get; set; } = null!;
        public bool Estado { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? HorarioEntrega { get; set; }
        public int? IdAgenciaTransportista { get; set; }
        public string? Contacto { get; set; }
        public string? Cargo { get; set; }
    }
}
