using AutoMapper;
using IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Maestro.CondicioVenta;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;
using System;
using System.Threading.Tasks;

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


        public async Task<usp_ApiRecuperarVendedorPorId> GetSpVendedorById(int idEmpresa, int idPersona)
        {
            var response = new usp_ApiRecuperarVendedorPorId();

            var query = await _masterTacamaUnitOfWork._vendedorRepository.GetSpVendedorById(idEmpresa, idPersona);
            var canals = await _masterTacamaUnitOfWork._vendedorRepository.GetSpVendedorCanalesById(idEmpresa, idPersona);
            response = query;
            response.canales = canals;

            return response;



        }
    }
}
