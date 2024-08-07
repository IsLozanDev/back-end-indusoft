using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama
{
    public interface IPersonaTacamaRepository : IGenericRepository<PersonaTacama>
    {
        Task<bool> GetPersonaByEmailAsync(string email);
    }
}