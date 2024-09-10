using IDCL.AVGUST.SIP.Repository.Tacama;
using IDCL.AVGUST.SIP.Repository.Tacama.Location;
using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama
{
    public class MasterTacamaUnitOfWork : IUnitOfWork<DbTacamaContext>
    {
        private bool disposedValue;

        public IUbigeoTacamaRepository _ubigeoTacamaRepository { get; }
        public ICondicionasRepository _condicionasRepository { get; }

        private readonly DbTacamaContext _context;

        public MasterTacamaUnitOfWork(IUbigeoTacamaRepository ubigeoTacamaRepository, 
            DbTacamaContext context, 
            ICondicionasRepository condicionasRepository)
        {
            _ubigeoTacamaRepository = ubigeoTacamaRepository;
            _context = context;
            _condicionasRepository = condicionasRepository;
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
                    // TODO: dispose managed state (managed objects)
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MasterTacamaUnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
