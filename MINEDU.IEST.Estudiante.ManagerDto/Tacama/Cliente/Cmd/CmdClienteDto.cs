namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente.Cmd
{
    public class CmdClienteDto
    {
        public string? SiglaComercial { get; set; }
        public int? TipoCliente { get; set; }
        public DateTime? FecInscripcion { get; set; }
        public DateTime? FecInicioEmpresa { get; set; }
        public int? TipConstitucion { get; set; }
        public int? TipRegimen { get; set; }
        public int? CatCliente { get; set; }
        public bool? IndEstado { get; set; }
        public DateTime? FecBaja { get; set; }
        public bool? IndVinculada { get; set; }
        public int? Zona { get; set; }
        public string? IdCcostos { get; set; }
        public int Calificacion { get; set; }
        public List<CmdClienteContactoDto> contactos { get; set; }
    }
}
