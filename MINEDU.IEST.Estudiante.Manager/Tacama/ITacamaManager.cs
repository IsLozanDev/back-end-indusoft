using IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure;
using IDCL.AVGUST.SIP.Entity.Tacama.SpEntity;
using IDCL.AVGUST.SIP.ManagerDto.Tacama;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Articulo;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Pedido;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Pedido.Cmd;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Persona;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.TramaDiario;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface ITacamaManager
    {
        Task<GetUsuarioTacamaDto?> login(string usuario, string password);
        Task<string> getCredencials(int id);
        Task<List<GetTramaDiarioDto>> GetTramaListByIdPersona(int idPersona);
        Task<GetTramaDiarioDto> AddTramaDiaria(GetTramaDiarioDto model);
        Task<List<ListarPedidoNacional>> GetListarPedidoNacionalAsync(int idEmpresa, int idLocal, string codPedidoCad, bool todos, 
            DateTime fecInicial, DateTime fecFinal, string Estado, string RazonSocial, bool Tipo, int idVendedor, string indCotPed);
        Task<List<GetArticuloTacamaDto>> GetArticulosTacamaAsync(string filter);
        Task<List<GetClienteTacamaDto>> GetClientesFilterAsync(string filter);
        Task<CmdPedidoTacamaDto> SavePedido(CmdPedidoTacamaDto model);
        Task<List<GetListPersonaDto>> GetListClientesFilterAsync(string filter);
        Task<List<GetListArticuloDto>> GetListArticulosTacamaFiltersAsync(string filter);
        Task<GetClienteHeaderPedidoDto> GetCanalandConditionByIdClienteAsync(int idcliente);
        Task<List<GetArticuloSearchPedidoDto>> GetArticulosDetailsPedidoAsync(
            int idEmpresa, int idAlmacen, int idTipoArticulo, string Anio, string Mes, string codArticulo, string nomArticulo, int idListaPrecio, bool conLote, DateTime FechaStock, int idCanalVenta = 0);


        Task<List<GetArticuloSearchPedidoApiDto>> GetArticulosDetailsPedidoApiAsync(
            int idEmpresa, int idAlmacen, int idTipoArticulo, string Anio, string Mes, string codArticulo, string nomArticulo, int idListaPrecio, bool conLote, DateTime FechaStock, int idCanalVenta = 0);


        Task<GetPedidoTacamaDto> GetPedidoForEditAsync(int idPedido);
        Task<int> loginExt(string email);
        Task<List<usp_ApiListarArticulosServicios>> GetListarArticulosServiciosApiSPAsync(int idEmpresa, int idTipoArticulo, string Filtro);
    }
}