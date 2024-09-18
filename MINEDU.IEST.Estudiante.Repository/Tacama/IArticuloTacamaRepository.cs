using IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama
{
    public interface IArticuloTacamaRepository : IGenericRepository<ArticuloTacamaServ>
    {
        Task<List<usp_ApiListarArticulosServicios>> GetListarArticulosServiciosApi(int idEmpresa, int idTipoArticulo, string Filtro);
    }
}