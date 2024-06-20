using IDCL.AVGUST.SIP.Repository.Tacama;
using IDCL.AVGUST.SIP.Repository.Tacama.Procedure;
using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama
{
    public class TacamaUnitOfWork : IUnitOfWork<DbTacamaContext>
    {
        private bool disposedValue;
        public IUsuarioTacRepository _usuarioTacRepository { get; }
        public ITramaDiarioRepository _tramaDiarioRepository { get; }
        public IPedidoTacamaRepository _pedidoTacamaRepository { get; }
        public IClienteRepository _clienteRepository { get; }
        public IArticuloTacamaRepository _articuloTacamaRepository { get; }


        private readonly DbTacamaContext _context;

        public TacamaUnitOfWork(IUsuarioTacRepository usuarioTacRepository,
            DbTacamaContext context,
            ITramaDiarioRepository tramaDiarioRepository,
            IPedidoTacamaRepository pedidoTacamaRepository,
            IClienteRepository clienteRepository,
            IArticuloTacamaRepository articuloTacamaRepository)
        {
            this._usuarioTacRepository = usuarioTacRepository;
            this._context = context;
            _tramaDiarioRepository = tramaDiarioRepository;
            _pedidoTacamaRepository = pedidoTacamaRepository;
            _clienteRepository = clienteRepository;
            _articuloTacamaRepository = articuloTacamaRepository;
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
        // ~TacamaUnitOfWork()
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
