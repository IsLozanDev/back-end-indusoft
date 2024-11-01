using IDCL.AVGUST.SIP.Entity.Tacama.Cliente.store_procedure;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface ICustomerTacamaManager
    {
        Task<GetClienteByIdDto> GetClienteByIdAsync(int idCliente);
        Task<usp_ApiRecuperarClientePorId> GetClienteSpByIdAsync(int idPersona);
        Task<List<usp_ListarClientePorParametro>> GetListClientesParametrosAsync(int idEmpresa, string RazonSocial, string NroDocumento, bool activo, bool inactivo, int CanalVenta, int idVendedor, int Zona);
    }
}