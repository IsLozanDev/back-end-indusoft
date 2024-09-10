using IDCL.AVGUST.SIP.Repository.Tacama;
using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using Microsoft.EntityFrameworkCore;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama
{
    public class CustomerTacamaUnitOfWork : IUnitOfWork<DbTacamaContext>
    {
        private bool disposedValue;
        private readonly DbTacamaContext _context;

        public IClienteRepository _clienteRepository { get; }

        public CustomerTacamaUnitOfWork(DbTacamaContext context, IClienteRepository clienteRepository)
        {
            this._context = context;
            _clienteRepository = clienteRepository;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
