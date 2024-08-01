using IDCL.AVGUST.SIP.Entity.Tacama.SpEntity;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama.Procedure
{
    public interface IPedidoTacamaRepository: IGenericRepository<ExpPedidoCab>
    {
        Task<List<GetArticulosPorListaPrecioCanalStock>> GetArticulosPorListaPrecioCanalStock(int idEmpresa, 
            int idAlmacen, 
            int idTipoArticulo, 
            string Anio, 
            string Mes, 
            string codArticulo, 
            string nomArticulo, 
            int idListaPrecio, 
            bool conLote, 
            DateTime FechaStock, 
            int idCanalVenta = 0
            );

        Task<List<ListarPedidoNacional>> ListarPedidoNacional(int idEmpresa, int idLocal, 
            string codPedidoCad, bool todos, DateTime fecInicial, DateTime fecFinal, string Estado, 
            string RazonSocial, bool Tipo, int idVendedor, string indCotPed);
        
        Task<string> ObtenerNroPedido(int idEmpresa, int idLocal, string indCotPed);
        
        Task<ObtenerTipoCambio> ObtenerTipoCambioPorDia(string idMoneda, DateTime fecCambio);

        Task<GetSpArticuloServForPdf> GetSpArticuloServForPdf(int idEmpresa, int idArticulo);
        Task<GetSpPedidoCabNacional> GetSpPedidoCabNacional(int idEmpresa, int idLocal, int idPedido);
        Task<List<GetSpPedidoNacionalDet>> GetSpPedidoNacionalDet(int idEmpresa, int idLocal, int idPedido);
        Task<List<GetSpListarCuentasParaDoc>> GetSpListarCuentasParaDoc(int idEmpresa);
    }
}