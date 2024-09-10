using IDCL.AVGUST.SIP.Entity.Tacama.Cliente.store_procedure;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface ICustomerTacamaManager
    {
        Task<usp_ApiRecuperarClientePorId> GetClienteSpByIdAsync(int idPersona);
    }
}