﻿using Dapper;
using IDCL.AVGUST.SIP.Contexto.IDCL.AVGUST.SIP.Entity.Avgust;
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

        public async Task<string> ObtenerNroPedido(int idEmpresa, int idLocal, string indCotPed)
        {
            var procedureName = "usp_ObtenerNroPedido";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idLocal", idLocal, DbType.Int32, ParameterDirection.Input);
            parameters.Add("indCotPed", indCotPed, DbType.String, ParameterDirection.Input);
            var qResult = await _database.Get<string>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }

        public async Task<ObtenerTipoCambio> ObtenerTipoCambioPorDia(string idMoneda, DateTime fecCambio)
        {
            var procedureName = "usp_ObtenerTipoCambioPorDia";
            var parameters = new DynamicParameters();
            parameters.Add("idMoneda", idMoneda, DbType.String, ParameterDirection.Input);
            parameters.Add("fecCambio", fecCambio, DbType.Date, ParameterDirection.Input);
            var qResult = await _database.Get<ObtenerTipoCambio>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }


        public async Task<List<GetArticulosPorListaPrecioCanalStock>> GetArticulosPorListaPrecioCanalStock(
            int idEmpresa,
            int idAlmacen,
            int idTipoArticulo,
            string Anio,
            string Mes,
            string codArticulo,
            string nomArticulo,
            int idListaPrecio,
            bool conLote,
            DateTime FechaStock,
            int idCanalVenta = 0)
        {

            var procedureName = "usp_ArticulosPorListaPrecioCanalStock";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idAlmacen", idAlmacen, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idTipoArticulo", idTipoArticulo, DbType.Int32, ParameterDirection.Input);
            parameters.Add("Anio", Anio, DbType.String, ParameterDirection.Input);
            parameters.Add("Mes", Mes, DbType.String, ParameterDirection.Input);
            parameters.Add("codArticulo", codArticulo, DbType.String, ParameterDirection.Input);
            parameters.Add("nomArticulo", nomArticulo, DbType.String, ParameterDirection.Input);
            parameters.Add("idListaPrecio", idListaPrecio, DbType.Int32, ParameterDirection.Input);
            parameters.Add("conLote", conLote, DbType.Boolean, ParameterDirection.Input);
            parameters.Add("FechaStock", FechaStock, DbType.Date, ParameterDirection.Input);
            parameters.Add("idCanalVenta ", idCanalVenta, DbType.Int32, ParameterDirection.Input);
            var qResult = await _database.GetAll<GetArticulosPorListaPrecioCanalStock>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }

        public async Task<GetSpPedidoCabNacional> GetSpPedidoCabNacional(int idEmpresa, int idLocal, int idPedido)
        {
            var procedureName = "usp_RecuperarPedidoCabNacional";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idLocal", idLocal, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idPedido", idPedido, DbType.Int32, ParameterDirection.Input);

            var qResult = await _database.Get<GetSpPedidoCabNacional>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }
        
        public async Task<List<GetSpPedidoNacionalDet>> GetSpPedidoNacionalDet(int idEmpresa, int idLocal, int idPedido)
        {
            var procedureName = "usp_RecuperarPedidoNacionalDet";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idLocal", idLocal, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idPedido", idPedido, DbType.Int32, ParameterDirection.Input);

            var qResult = await _database.GetAll<GetSpPedidoNacionalDet>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }
        
        public async Task<GetSpArticuloServForPdf> GetSpArticuloServForPdf(int idEmpresa, int @idArticulo)
        {
            var procedureName = "usp_ObtenerArticuloServ";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);
            parameters.Add("idArticulo", @idArticulo, DbType.Int32, ParameterDirection.Input);

            var qResult = await _database.Get<GetSpArticuloServForPdf>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }
        
        public async Task<List<GetSpListarCuentasParaDoc>> GetSpListarCuentasParaDoc(int idEmpresa)
        {
            var procedureName = "usp_ListarCuentasParaDoc";
            var parameters = new DynamicParameters();
            parameters.Add("idEmpresa", idEmpresa, DbType.Int32, ParameterDirection.Input);

            var qResult = await _database.GetAll<GetSpListarCuentasParaDoc>(procedureName, parameters, CommandType.StoredProcedure);
            return qResult;
        }

    }
}
