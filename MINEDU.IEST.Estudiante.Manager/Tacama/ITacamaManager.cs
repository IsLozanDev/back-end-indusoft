using IDCL.AVGUST.SIP.Entity.Tacama.SpEntity;
using IDCL.AVGUST.SIP.ManagerDto.Tacama;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Articulo;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.TramaDiario;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface ITacamaManager
    {
        Task<GetUsuarioTacamaDto> login(string usuario, string password);
        Task<string> getCredencials(int id);
        Task<List<GetTramaDiarioDto>> GetTramaListByIdPersona(int idPersona);
        Task<GetTramaDiarioDto> AddTramaDiaria(GetTramaDiarioDto model);
        Task<List<ListarPedidoNacional>> GetListarPedidoNacionalAsync(int idEmpresa, int idLocal, string codPedidoCad, bool todos, 
            DateTime fecInicial, DateTime fecFinal, string Estado, string RazonSocial, bool Tipo, int idVendedor, string indCotPed);
        Task<List<GetArticuloTacamaDto>> GetArticulosTacamaAsync(string filter);
        Task<List<GetClienteTacamaDto>> GetClientesFilterAsync(string filter);
    }
}