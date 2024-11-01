using IDCL.AVGUST.SIP.Entity.Tacama.Cliente.store_procedure;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface ICustomerTacamaManager
    {
        Task<usp_ApiRecuperarClientePorId> GetClienteSpByIdAsync(int idPersona);
        Task<List<usp_ListarClientePorParametro>> GetListClientesParametrosAsync(int idEmpresa, string RazonSocial, string NroDocumento, bool activo, bool inactivo, int CanalVenta, int idVendedor, int Zona);
    }
}