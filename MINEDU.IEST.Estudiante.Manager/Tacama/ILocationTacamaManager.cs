using IDCL.AVGUST.SIP.ManagerDto.Tacama.Location;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface ILocationTacamaManager
    {
        Task<List<GetUbigeoDto>> GetDistritoByProv(string prov);
        Task<List<GetUbigeoDto>> GetDpto();
        Task<List<GetUbigeoDto>> GetProvinciaByDpto(string dpto);
    }
}