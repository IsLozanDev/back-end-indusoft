using IDCL.AVGUST.SIP.Repository.Tacama;
using IDCL.AVGUST.SIP.Repository.Tacama.TacamCustomer;
using IDCL.Tacama.Core.Contexto.IDCL.Tacama.Core.Contexto;
using MINEDU.IEST.Estudiante.Repository.Base;

namespace IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama
{
    public class CustomerTacamaUnitOfWork : IUnitOfWork<DbTacamaContext>
    {
        private bool disposedValue;
        private readonly DbTacamaContext _context;

        public IClienteRepository _clienteRepository { get; }
        public IClienteContactoRepository _clienteContactoRepository { get; }
        public IClienteAgenciaEnvioRepository _clienteAgenciaEnvioRepository { get; }
        public IClienteRepLegalRepository _clienteRepLegalRepository { get; }
        public IClienteAseguradoraRepository _clienteAseguradoraRepository { get; }
        public IClienteAvalRepository _clienteAvalRepository { get; }
        public IPersonaDireccionTacamaRepository _personaDireccionTacama { get; }

        public CustomerTacamaUnitOfWork(DbTacamaContext context,
            IClienteRepository clienteRepository,
            IClienteContactoRepository clienteContactoRepository,
            IClienteAgenciaEnvioRepository clienteAgenciaEnvioRepository,
            IClienteRepLegalRepository clienteRepLegalRepository,
            IClienteAseguradoraRepository clienteAseguradoraRepository,
            IClienteAvalRepository clienteAvalRepository,
            IPersonaDireccionTacamaRepository personaDireccionTacama)
        {
            this._context = context;
            _clienteRepository = clienteRepository;
            _clienteContactoRepository = clienteContactoRepository;
            _clienteAgenciaEnvioRepository = clienteAgenciaEnvioRepository;
            _clienteRepLegalRepository = clienteRepLegalRepository;
            _clienteAseguradoraRepository = clienteAseguradoraRepository;
            _clienteAvalRepository = clienteAvalRepository;
            _personaDireccionTacama = personaDireccionTacama;
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
