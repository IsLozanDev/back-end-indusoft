using AutoMapper;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Location;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;
using IDCL.Tacama.Core.Entity.Tacama.master;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public class LocationTacamaManager : ILocationTacamaManager
    {
        private readonly IMapper _mapper;
        private readonly MasterTacamaUnitOfWork _masterTacamaUnitOfWork;

        public LocationTacamaManager(IMapper mapper, MasterTacamaUnitOfWork masterTacamaUnitOfWork)
        {
            _mapper = mapper;
            _masterTacamaUnitOfWork = masterTacamaUnitOfWork;
        }

        public async Task<List<GetUbigeoDto>> GetDpto() => _mapper.Map<List<GetUbigeoDto>>(await _masterTacamaUnitOfWork._ubigeoTacamaRepository.GetDptoAsync());
        public async Task<List<GetUbigeoDto>> GetProvinciaByDpto(string dpto) => _mapper.Map<List<GetUbigeoDto>>(await _masterTacamaUnitOfWork._ubigeoTacamaRepository.GetProvinciaByDptoAsync(dpto));
        public async Task<List<GetUbigeoDto>> GetDistritoByProv(string prov) => _mapper.Map<List<GetUbigeoDto>>(await _masterTacamaUnitOfWork._ubigeoTacamaRepository.GetDistritoByProvinciaAsync(prov));


    }
}
