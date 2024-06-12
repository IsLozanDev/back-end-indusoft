using IDCL.AVGUST.SIP.ManagerDto.Tacama.Persona;

namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente
{
    public class GetClienteTacamaDto
    {
        public int IdPersona { get; set; }
        public int IdEmpresa { get; set; }
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
        public GetPersonaTacamaDto IdPersonaNavigation { get; set; } = null!;
    }
}
