using Dapper;
using IDCL.AVGUST.SIP.Entity.Tacama.Cliente.store_procedure;
using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers.Dapper;
using MINEDU.IEST.Estudiante.Repository.Base;
using System;
using System.Data;

namespace IDCL.AVGUST.SIP.Repository.Tacama
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        private readonly DbTacamaContext _context;
        private readonly IDapper _database;

        public ClienteRepository(DbTacamaContext context, IDapper database) : base(context)
        {
            this._context = context;
            _database = database;
        }

        public async Task<usp_ApiRecuperarClientePorId> GetClienteByIdAsync(int idEmpresa, int idPersona)
        {

            var procedureName = "usp_ApiRecuperarClientePorId";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idPersona", idPersona, DbType.Int32, ParameterDirection.Input);

            var qResult = await _database.Get<usp_ApiRecuperarClientePorId>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }

        public async Task<List<usp_ApiListarClienteContacto>> GetClienteContactoAsync(int idEmpresa, int idPersona)
        {
            var procedureName = "usp_ApiListarClienteContacto";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idPersona", idPersona, DbType.Int32, ParameterDirection.Input);

            var qResult = await _database.GetAll<usp_ApiListarClienteContacto>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }


        public async Task<List<usp_ApiListarPersonaDireccion>> GetClienteDireccionAsync(int idPersona)
        {
            var procedureName = "usp_ApiListarPersonaDireccion";
            var parameters = new DynamicParameters();
            parameters.Add("idPersona", idPersona, DbType.Int32, ParameterDirection.Input);

            var qResult = await _database.GetAll<usp_ApiListarPersonaDireccion>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }

        public async Task<List<usp_ListarClientePorParametro>> GetListClientesByParameters(int idEmpresa, string RazonSocial, string NroDocumento, bool activo, bool inactivo, int CanalVenta, int idVendedor, int Zona)
        {
            var procedureName = "usp_ListarClientePorParametro";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("RazonSocial", RazonSocial, DbType.String, ParameterDirection.Input);
            parameters.Add("NroDocumento", NroDocumento, DbType.String, ParameterDirection.Input);
            parameters.Add("activo", activo, DbType.Boolean, ParameterDirection.Input);
            parameters.Add("inactivo", inactivo, DbType.Boolean, ParameterDirection.Input);
            parameters.Add("CanalVenta", CanalVenta, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idVendedor", idVendedor, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Zona", Zona, DbType.Int32, ParameterDirection.Input);

            try
            {

            var qResult = await _database.GetAll<usp_ListarClientePorParametro>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
