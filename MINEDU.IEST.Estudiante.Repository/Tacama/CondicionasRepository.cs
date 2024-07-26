using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama
{
    public class CondicionasRepository :  GenericRepository<Condicion>, ICondicionasRepository
    {
        public CondicionasRepository(DbTacamaContext context) : base(context)
        {

        }
    }
}
