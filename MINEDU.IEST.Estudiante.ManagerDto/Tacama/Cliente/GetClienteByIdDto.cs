using IDCL.AVGUST.SIP.ManagerDto.Tacama.Persona;

namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente
{
    public class GetClienteByIdDto
    {

        //Personas
        public int IdPersona { get; set; }
        public int TipoPersona { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string Ruc { get; set; }
        public string? ApePaterno { get; set; }
        public string? ApeMaterno { get; set; }
        public string? Nombres { get; set; }
        public int? TipoDocumento { get; set; }
        public string? NroDocumento { get; set; }
        public string? Telefonos { get; set; }
        public string? Fax { get; set; }
        public string? Correo { get; set; }
        public string? Web { get; set; }
        public string? DireccionCompleta { get; set; }
        public int? IdPais { get; set; }
        public string? IdUbigeo { get; set; }
        public bool? PrincipalContribuyente { get; set; }
        public bool? AgenteRetenedor { get; set; }
        public int? IdCanalVenta { get; set; }
        public bool? Estado { get; set; }

        //Cliente
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

        //Direccion
        public List<GetDireccionTacamaDto> direcciones { get; set; }

        //Contacto
        public List<GetClienteContactoDto> contactos { get; set; }


    }
}
