using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using IDCL.Tacama.Core.Entity;
using Microsoft.EntityFrameworkCore;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.Tacama
{
    public class UsuarioTacRepository : GenericRepository<UsuarioTacama>, IUsuarioTacRepository
    {
        private readonly DbTacamaContext _context;

        public UsuarioTacRepository(DbTacamaContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<UsuarioTacama> Autenticar(string usuario, byte[] clave)
        {
            var query = await _context.Usuarios
                .Where(l => l.Credencial.ToUpper() == usuario.ToUpper() && l.Clave == clave)
                .Select(s => new UsuarioTacama
                {
                    IdPersona = s.IdPersona,
                    NombreCorto = s.Credencial,
                    UsuarioRols = s.UsuarioRols.Select(r => new UsuarioRol
                    {
                        IdRolNavigation = new Rol
                        {
                            IdRol = r.IdRol,
                            Nombre = r.IdRolNavigation.Nombre
                        }
                    }).ToList()
                }).FirstOrDefaultAsync();

            var infoVenedor = await _context.Vendedores.FirstOrDefaultAsync(l => l.IdPersona == query.IdPersona);

            if (infoVenedor != null)
            {
                var establecimiento = await _context.Establecimientos.FirstOrDefaultAsync(l => l.IdEstablecimiento == infoVenedor.IdEstablecimiento && l.IdEmpresa == infoVenedor.IdEmpresa);
                var venDivision = await _context.VenDivisions.FirstOrDefaultAsync(l => l.IdDivision == infoVenedor.IdDivision);
                var zonaTrabajo = await _context.ZonaTrabajos.FirstOrDefaultAsync(l => l.IdEstablecimiento == infoVenedor.IdEstablecimiento && l.IdZona == infoVenedor.IdZona && l.IdEmpresa == infoVenedor.IdEmpresa);
                infoVenedor.IdEstablecimientoNavigation = establecimiento;
                infoVenedor.IdDivisionNavigation = venDivision;
                infoVenedor.IdZonaNavigation = zonaTrabajo;
                query.IdVendedorNavigation = infoVenedor;
            }

            return query;
        }

        public async Task<UsuarioTacama> GetCredencials(int id) => await _context.Usuarios.FirstOrDefaultAsync(l => l.IdPersona == id);

    }
}
