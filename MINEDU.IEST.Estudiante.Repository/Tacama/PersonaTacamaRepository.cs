using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity;
using Microsoft.EntityFrameworkCore;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama
{
    public class PersonaTacamaRepository : GenericRepository<PersonaTacama>, IPersonaTacamaRepository
    {
        private readonly DbTacamaContext _context;

        public PersonaTacamaRepository(DbTacamaContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<bool> GetPersonaByEmailAsync(string email)
        {
            var query = from p in _context.Personas
                        join u in _context.Usuarios on p.IdPersona equals u.IdPersona
                        where p.Correo == email
                        select p.IdPersona;

            var response = await query.FirstOrDefaultAsync();

            return response != default;
        }
    }
}
