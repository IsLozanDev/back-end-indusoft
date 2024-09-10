using IDCL.AVGUST.SIP.ManagerDto.Tacama.Maestro.CondicioVenta;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface IMasterTacamaManager
    {
        Task<List<GetCondicioVentaDto>> GetListCondicionesFilterAsync(string filter);
    }
}