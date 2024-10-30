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

            var partabla = _masterTacamaUnitOfWork._partablaTacamaRepository.GetAll(l => l.Grupo == 381000 && l.IdParTabla > 381000);


            response.ForEach(l =>
            {
                switch (l.IdTipCondicion)
                {
                    case 1: l.IdCondicionText = "FACTURAS Y BOLETAS"; break;
                    case 2: l.IdCondicionText = "NOTA DE CREDITO"; break;
                    case 3: l.IdCondicionText = "NOTA DE DEBITO"; break;
                }

                var part = partabla.FirstOrDefault(p => p.IdParTabla == l.IdClasificacion);
                if (part != null)
                {
                    l.IdClasificacionDescription = part.Descripcion;
                }
            });
            return response;
        }

        public async Task<usp_ApiRecuperarVendedorPorId?> GetSpVendedorById(int idEmpresa, int idPersona)
        {
            var response = new usp_ApiRecuperarVendedorPorId();

            var query = await _masterTacamaUnitOfWork._vendedorRepository.GetSpVendedorById(idEmpresa, idPersona);
            if (query == null)
            {
                return null;
            }
            var canals = await _masterTacamaUnitOfWork._vendedorRepository.GetSpVendedorCanalesById(idEmpresa, idPersona);

            foreach (var l in canals)
            {
                var almacenes = await _masterTacamaUnitOfWork._vendedorRepository.GetSpCanalAlmacences(l.idCanalVenta, idEmpresa);
                l.almacenes = almacenes;
            }

            var zonas = await _masterTacamaUnitOfWork._vendedorRepository.GetSpVendedorByZonasAsync(idEmpresa, idPersona);

            foreach (var l in zonas)
            {
                var zonasEst = await _masterTacamaUnitOfWork._vendedorRepository.GetSpEstablicimientoZonas(idEmpresa, idPersona, l.idEstablecimiento);
                l.EstZonas = zonasEst;
            }

            response = query;
            response.canales = canals;
            response.zonas = zonas;
            return response;
        }

        public async Task<List<usp_ApiListarDivision>> GetListDivisionesAsync(int idEmpresa) =>
            await _masterTacamaUnitOfWork._vendedorRepository.GetSpDivisionAsync(idEmpresa);
    }
}
