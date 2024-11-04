using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente.Cmd
{
    public class CmdPersonaClienteDto
    {
        [Required(ErrorMessage = "El Campo tipo persona es obligatorio")]
        [Min(1, ErrorMessage = "El valor del campo tipo persona no es valido")]
        public int TipoPersona { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string Ruc { get; set; }
        public string? ApePaterno { get; set; }
        public string? ApeMaterno { get; set; }
        public string? Nombres { get; set; }
        
        [Required(ErrorMessage = "El Campo tipo Documento es obligatorio")]
        [Min(1, ErrorMessage = "El valor del campo tipo documento no es valido")]
        public int? TipoDocumento { get; set; }
        [Required(ErrorMessage = "El Campo Nro Documento es obligatorio")]
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

        [Required(ErrorMessage = "La informacion de clientes es obligatorio")]
        public CmdClienteDto cliente { get; set; }

        [Required(ErrorMessage = "La informacion de direccion es obligatorio")]
        public List<CmdPersonaDireccionDto> direcciones { get; set; }

    }
}
