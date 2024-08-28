using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity.Tacama.master;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama.Location
{
    public class UbigeoTacamaRepository : GenericRepository<UbigeoSunat>, IUbigeoTacamaRepository
    {
        private readonly DbTacamaContext _context;

        public UbigeoTacamaRepository(DbTacamaContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<UbigeoSunat>> GetDptoAsync()
        {
            var query = _context.UbigeoSunats
                .GroupBy(u => u.IdUbigeo.Substring(0, 2))
                .Select(g => new UbigeoSunat
                {
                    IdUbigeo = g.Key,
                    description = g.First().Departamento
                })
                .OrderBy(p=>p.IdUbigeo)
                .ToList();
            return query;
        }

        public async Task<List<UbigeoSunat>> GetProvinciaByDptoAsync(string dpto)
        {
            var query = _context.UbigeoSunats
                .Where(p => p.IdUbigeo.StartsWith(dpto))
                .GroupBy(u => u.IdUbigeo.Substring(0, 4))
                .Select(g => new UbigeoSunat
                {
                    IdUbigeo = g.Key,
                    description = g.First().Provincia
                })
                .OrderBy(p => p.IdUbigeo)
                .ToList();

            return query;
        }

        public async Task<List<UbigeoSunat>> GetDistritoByProvinciaAsync(string prov)
        {
            var query = _context.UbigeoSunats
                .Where(p => p.IdUbigeo.StartsWith(prov))
                .Select(u => new UbigeoSunat
                {
                    IdUbigeo = u.IdUbigeo,
                    description = u.Distrito
                })
                .OrderBy(p => p.IdUbigeo)
                .ToList();

            return query;
        }

        public async Task<string> GetPuntoEntrebaByUbigeoAsync(string codUbigeo)
        {

            var query = _context.UbigeoSunats.Where(u => u.IdUbigeo == codUbigeo).FirstOrDefault();
            if (query == null)
            {
                return string.Empty;
            }
            return $"{query.Departamento} {query.Provincia} {query.Distrito}";
        }



    }
}
