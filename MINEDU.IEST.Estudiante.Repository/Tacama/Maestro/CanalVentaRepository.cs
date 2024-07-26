using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama.Maestro
{
    public class CanalVentaRepository : GenericRepository<VenCanalVentum>, ICanalVentaRepository
    {
        public CanalVentaRepository(DbTacamaContext context) : base(context)
        {
        }
    }
}
