using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity.Tacama.Customer;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama.TacamCustomer
{
    public class ClienteRepLegalRepository : GenericRepository<ClienteRepLegal>, IClienteRepLegalRepository
    {
        public ClienteRepLegalRepository(DbTacamaContext context) : base(context)
        {
        }
    }
}
