using IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure;
using IDCL.Tacama.Core.Entity.Tacama.master;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama.Maestro
{
    public interface IVendedorRepository : IGenericRepository<Vendedore>
    {
        Task<List<usp_ApiListarDivision>> GetSpDivisionAsync(int idEmpresa);
        Task<usp_ApiRecuperarVendedorPorId> GetSpVendedorById(int idEmpresa, int idPersona);
        Task<List<usp_ApiListarVendedoresZonai>> GetSpVendedorByZonasAsync(int idEmpresa, int idPersona);
        Task<List<usp_ApiListarVendedorCanal>> GetSpVendedorCanalesById(int idEmpresa, int idPersona);
    }
}