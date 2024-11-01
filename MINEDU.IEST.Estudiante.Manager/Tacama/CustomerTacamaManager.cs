using AutoMapper;
using IDCL.AVGUST.SIP.Entity.Tacama.Cliente.store_procedure;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;
using System;
using System.Threading.Tasks;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public class CustomerTacamaManager : ICustomerTacamaManager
    {
        private readonly IMapper _mapper;
        private readonly CustomerTacamaUnitOfWork _customerTacamaUnitOfWork;

        public CustomerTacamaManager(IMapper mapper, CustomerTacamaUnitOfWork customerTacamaUnitOfWork)
        {
            _mapper = mapper;
            _customerTacamaUnitOfWork = customerTacamaUnitOfWork;
        }

        public async Task<usp_ApiRecuperarClientePorId> GetClienteSpByIdAsync(int idPersona)
        {
            var response = new usp_ApiRecuperarClientePorId();

            var cliente = await _customerTacamaUnitOfWork._clienteRepository.GetClienteByIdAsync(10, idPersona);
            if (cliente == null)
            {
                return null;
            }


            var direccion = await _customerTacamaUnitOfWork._clienteRepository.GetClienteDireccionAsync(idPersona);
            var contacto = await _customerTacamaUnitOfWork._clienteRepository.GetClienteContactoAsync(10, idPersona);

            response = cliente;
            response.direcciones = direccion;
            response.contactos = contacto;

            return response;

        }

        public async Task<List<usp_ListarClientePorParametro>> GetListClientesParametrosAsync(int idEmpresa, string RazonSocial, string NroDocumento, bool activo, bool inactivo, int CanalVenta, int idVendedor, int Zona)
        {
            var query = await _customerTacamaUnitOfWork._clienteRepository.GetListClientesByParameters(idEmpresa, RazonSocial, NroDocumento, activo, inactivo, CanalVenta, idVendedor, Zona);
            return query;
        }
    }
}
