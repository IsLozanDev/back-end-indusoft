using AutoMapper;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Maestro.CondicioVenta;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public class MasterTacamaManager : IMasterTacamaManager
    {
        private readonly IMapper _mapper;
        private readonly MasterTacamaUnitOfWork _masterTacamaUnitOfWork;

        public MasterTacamaManager(IMapper mapper, MasterTacamaUnitOfWork _masterTacamaUnitOfWork)
        {
            _mapper = mapper;
            this._masterTacamaUnitOfWork = _masterTacamaUnitOfWork;
        }

        public async Task<List<GetCondicioVentaDto>> GetListCondicionesFilterAsync(string filter)
        {
            var query = _masterTacamaUnitOfWork._condicionasRepository.GetAll(l => l.DesCondicion.Contains(filter) || filter == "");
            var response = _mapper.Map<List<GetCondicioVentaDto>>(query);
            response.ForEach(l =>
            {
                switch (l.IdTipCondicion)
                {
                    case 1: l.IdCondicionText = "FACTURAS Y BOLETAS"; break;
                    case 2: l.IdCondicionText = "NOTA DE CREDITO"; break;
                    case 3: l.IdCondicionText = "NOTA DE DEBITO"; break;
                }
            });
            return response;

        }
    }
}
