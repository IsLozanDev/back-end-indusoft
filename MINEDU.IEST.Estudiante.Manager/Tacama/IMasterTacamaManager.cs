using IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Maestro.CondicioVenta;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface IMasterTacamaManager
    {
        Task<List<GetCondicioVentaDto>> GetListCondicionesFilterAsync(string filter);
        Task<List<usp_ApiListarDivision>> GetListDivisionesAsync(int idEmpresa);
        Task<usp_ApiRecuperarVendedorPorId?> GetSpVendedorById(int idEmpresa, int idPersona);
    }
}