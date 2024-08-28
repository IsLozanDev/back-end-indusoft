using IDCL.Tacama.Core.Entity.Tacama.master;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama.Location
{
    public interface IUbigeoTacamaRepository : IGenericRepository<UbigeoSunat>
    {
        Task<List<UbigeoSunat>> GetDistritoByProvinciaAsync(string prov);
        Task<List<UbigeoSunat>> GetDptoAsync();
        Task<List<UbigeoSunat>> GetProvinciaByDptoAsync(string dpto);
        Task<string> GetPuntoEntrebaByUbigeoAsync(string codUbigeo);
    }
}