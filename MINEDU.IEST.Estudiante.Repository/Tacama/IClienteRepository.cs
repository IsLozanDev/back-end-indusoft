using IDCL.AVGUST.SIP.Entity.Tacama.Cliente.store_procedure;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        Task<usp_ApiRecuperarClientePorId> GetClienteByIdAsync(int idEmpresa, int idPersona);
        Task<List<usp_ApiListarClienteContacto>> GetClienteContactoAsync(int idEmpresa, int idPersona);
        Task<List<usp_ApiListarPersonaDireccion>> GetClienteDireccionAsync(int idPersona);
    }
}