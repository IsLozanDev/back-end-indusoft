using IDCL.AVGUST.SIP.Entity.Pedido;
using IDCL.AVGUST.SIP.Entity.Pedido.SpEntity;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Pedido
{
    public interface IPedidoRepository : IGenericRepository<PedidoCab>
    {
        Task<List<AvanceCobranzaZV>> ListarAvanceCobranzaZonaVendedor(int idEmpresa, string fechaInicio, string fechaFin);
        Task<List<ClientesAprobados>> ListarClientesAprobadosLCPorZona(int idEmpresa, int idZona);
        Task<List<ClientesAtendidos>> ListarClientesAtendidosLCPorZona(int idEmpresa, int idZona);
        Task<List<ClientesAtendidosSinLC>> ListarClientesAtendidosSinLC(int idEmpresa, int idZona);
        Task<List<ListarCobranzaPresupuestoZonaVendedor>> ListarCobranzaPresupuestoZonaVendedor(int idEmpresa, string anio, string mes, int idZona);
        Task<List<CostoArticulo>> ListarCostoArticulo(int idEmpresa, string idMoneda, string codArticulo, string fechaStock);
        Task<List<ListarCreditoZonaClienteVf>> ListarCreditoZonaClienteVf(int idEmpresa, int idZona);
        Task<List<CtaCteAtrazadaZona>> ListarCtaCteAtrazadaPorZona(int idEmpresa, int idZona, string fechaFiltro);
        Task<List<LetraPorAceptarZona>> ListarLetraPorAceptarZona(int idEmpresa, int idZona);
        Task<List<LineaCreditoDisponible>> ListarLineaCreditoDisponibleZonaCliente(int idEmpresa, int idZona);
        Task<List<SegmentoZona>> ListarSegmentoZona(int idEmpresa, string Anio, string Mes, int idZona, string Tipo);
        Task<List<ListarTopCliente>> ListarTopCliente(int idEmpresa, string Anio, string Mes, int idZona, string Tipo);
        Task<List<VentaClienteProducto>> ListarVentaClienteProducto(int idEmpresa, string Anio, string Mes, int idZona, int idCliente, string Tipo);
        Task<List<VentaProducto>> ListarVentaProducto(int idEmpresa, string Anio, string Mes, int idZona, string Tipo, string Formato);
        Task<List<ListaPptoVentaZonaVendedor>> ListarVentasPresupuestoZonaVendedor(int idEmpresa, string anio, string mes, int idZona, string Tipo);
        Task<List<ZonaVendendor>> ListarZonaVendedor(int idEmpresa, string Anio, string Mes, int idZona);
        Task<string> ObtenerNroPedido(int idEmpresa, int idLocal, string indCotPed);
    }
}