﻿using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama
{
    public class PedidoDetalleTacamaRepository : GenericRepository<ExpPedidoDet>, IPedidoDetalleTacamaRepository
    {
        public PedidoDetalleTacamaRepository(DbTacamaContext context) : base(context)
        {
        }
    }
}
