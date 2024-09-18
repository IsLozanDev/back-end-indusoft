
using Dapper;
using IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure;
using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers.Dapper;
using MINEDU.IEST.Estudiante.Repository.Base;
using System.Data;

namespace IDCL.AVGUST.SIP.Repository.Tacama
{
    public class ArticuloTacamaRepository : GenericRepository<ArticuloTacamaServ>, IArticuloTacamaRepository
    {
        private readonly DbTacamaContext context;
        private readonly IDapper _database;

        public ArticuloTacamaRepository(DbTacamaContext context, IDapper database) : base(context)
        {
            this.context = context;
            this._database = database;
        }

        public async Task<List<usp_ApiListarArticulosServicios>> GetListarArticulosServiciosApi(int idEmpresa, int idTipoArticulo, string Filtro)
        {
            var procedureName = "usp_ApiListarArticulosServicios";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idTipoArticulo", idTipoArticulo, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Filtro", Filtro, DbType.String, ParameterDirection.Input);
            var qResult = await _database.GetAll<usp_ApiListarArticulosServicios>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }
    }
}
