using Dapper;
using IDCL.AVGUST.SIP.Entity.Tacama.SpEntity;
using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers.Dapper;
using MINEDU.IEST.Estudiante.Repository.Base;
using System.Data;

namespace IDCL.AVGUST.SIP.Repository.Tacama.Procedure
{
    public class PedidoTacamaRepository : GenericRepository<ExpPedidoCab>, IPedidoTacamaRepository
    {
        private readonly DbTacamaContext context;
        private readonly IDapper _database;

        public PedidoTacamaRepository(DbTacamaContext context, IDapper database) : base(context)
        {
            this.context = context;
            _database = database;
        }

        public async Task<List<ListarPedidoNacional>> ListarPedidoNacional(int idEmpresa, int idLocal, string codPedidoCad, bool todos, DateTime fecInicial, DateTime fecFinal,
            string Estado, string RazonSocial, bool Tipo, int idVendedor, string indCotPed)
        {
            var procedureName = "usp_ListarPedidoNacional";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idLocal", idLocal, DbType.Int32, ParameterDirection.Input);
            parameters.Add("codPedidoCad", codPedidoCad, DbType.String, ParameterDirection.Input);
            parameters.Add("todos", todos, DbType.Boolean, ParameterDirection.Input);
            parameters.Add("fecInicial", fecInicial, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("fecFinal", fecFinal, DbType.DateTime, ParameterDirection.Input);
            parameters.Add("Estado", Estado, DbType.String, ParameterDirection.Input);
            parameters.Add("RazonSocial", RazonSocial, DbType.String, ParameterDirection.Input);
            parameters.Add("Tipo", Tipo, DbType.Boolean, ParameterDirection.Input);
            parameters.Add("idVendedor", idVendedor, DbType.Int32, ParameterDirection.Input);
            parameters.Add("indCotPed", indCotPed, DbType.String, ParameterDirection.Input);

            var qResult = await _database.GetAll<ListarPedidoNacional>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }
    }
}
