﻿using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity.Tacama.Customer;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama.TacamCustomer
{
    public class ClienteContactoRepository : GenericRepository<ClienteContacto>, IClienteContactoRepository
    {
        public ClienteContactoRepository(DbTacamaContext context) : base(context)
        {
        }
    }
}
