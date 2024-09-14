using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using MINEDU.IEST.Estudiante.Repository.Base;
using IDCL.Tacama.Core.Entity.Tacama.master;


namespace IDCL.AVGUST.SIP.Repository.Tacama.Maestro
{
    public class PartablaTacamaRepository : GenericRepository<ParTabla>, IPartablaTacamaRepository
    {
        public PartablaTacamaRepository(DbTacamaContext context) : base(context)
        {

        }
    }
}
