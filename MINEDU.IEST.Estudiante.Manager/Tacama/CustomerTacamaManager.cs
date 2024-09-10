using AutoMapper;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;
using System;
using System.Threading.Tasks;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public class CustomerTacamaManager
    {
        private readonly IMapper _mapper;
        private readonly CustomerTacamaUnitOfWork _customerTacamaUnitOfWork;

        public CustomerTacamaManager(IMapper mapper, CustomerTacamaUnitOfWork customerTacamaUnitOfWork)
        {
            _mapper = mapper;
            _customerTacamaUnitOfWork = customerTacamaUnitOfWork;
        }

        public async Task<GetClienteTacamaDto> MyMethodAsync()
        {

            throw new NotImplementedException();
        }
    }
}
