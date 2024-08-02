using IDCL.AVGUST.SIP.ManagerDto.Tacama.Maestro;

namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente
{
    public class GetClienteHeaderPedidoDto
    {
        
        public string NroTelefContacto { get; set; }
        public int IdCanalVenta { get; set; }
        public string NombreCanalVenta { get; set; }
        public int IdListaPrecio { get; set; }
        public string NombreListaPrecio { get; set; }
        public string Direccion { get; set; }
        public string Ruc { get; set; }
        public string NombreCliente { get; set; }
        public List<GetCondicionHeaderDto> condiciones { get; set; }

    }
}
