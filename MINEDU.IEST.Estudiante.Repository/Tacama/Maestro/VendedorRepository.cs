﻿using Dapper;
using IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure;
using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity.Tacama.master;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers.Dapper;
using MINEDU.IEST.Estudiante.Repository.Base;
using System.Data;

namespace IDCL.AVGUST.SIP.Repository.Tacama.Maestro
{
    public class VendedorRepository : GenericRepository<Vendedore>, IVendedorRepository
    {
        private readonly DbTacamaContext _context;
        private readonly IDapper _dapper;

        public VendedorRepository(DbTacamaContext context, IDapper dapper) : base(context)
        {
            this._context = context;
            this._dapper = dapper;
        }


        public async Task<usp_ApiRecuperarVendedorPorId> GetSpVendedorById(int idEmpresa, int idPersona)
        {
            var procedureName = "usp_ApiRecuperarVendedorPorId";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idPersona", idPersona, DbType.Int32, ParameterDirection.Input);

            var qResult = await _dapper.Get<usp_ApiRecuperarVendedorPorId>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }

        public async Task<List<usp_ApiListarVendedorCanal>> GetSpVendedorCanalesById(int idEmpresa, int idPersona)
        {
            var procedureName = "usp_ApiListarVendedorCanal";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idPersona", idPersona, DbType.Int32, ParameterDirection.Input);

            var qResult = await _dapper.GetAll<usp_ApiListarVendedorCanal>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }

    }
}