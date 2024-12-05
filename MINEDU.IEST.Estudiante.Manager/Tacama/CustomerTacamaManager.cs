using AutoMapper;
using IDCL.AVGUST.SIP.Entity.Tacama.Cliente.store_procedure;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente.Cmd;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;
using IDCL.Tacama.Core.Entity;
using IDCL.Tacama.Core.Entity.Tacama.Customer;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public class CustomerTacamaManager : ICustomerTacamaManager
    {
        private readonly IMapper _mapper;
        private readonly CustomerTacamaUnitOfWork _customerTacamaUnitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly TacamaUnitOfWork _tacamaUnitOfWork;

        public CustomerTacamaManager(IMapper mapper,
            CustomerTacamaUnitOfWork customerTacamaUnitOfWork,
            IHttpContextAccessor httpContextAccessor,
            TacamaUnitOfWork tacamaUnitOfWork)
        {
            _mapper = mapper;
            _customerTacamaUnitOfWork = customerTacamaUnitOfWork;
            this._httpContextAccessor = httpContextAccessor;
            this._tacamaUnitOfWork = tacamaUnitOfWork;
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


        #region Crud - Clientes

        public async Task<GetClienteByIdDto> GetClienteByIdAsync(int idCliente)
        {
            try
            {
                var response = new GetClienteByIdDto();
                var query = _customerTacamaUnitOfWork._clienteRepository.GetAll(l => l.IdPersona == idCliente, includeProperties: "IdPersonaNavigation").FirstOrDefault();
                if (query == null)
                {
                    return null;
                }
                response = _mapper.Map<GetClienteByIdDto>(query);

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<int> SaveClienteAsync(CmdPersonaClienteDto model)
        {
            try
            {
                var persona = _mapper.Map<PersonaTacama>(model);
                var cliente = _mapper.Map<Cliente>(model.cliente);
                var direccion = _mapper.Map<List<PersonaDireccion>>(model.direcciones);
                var contactos = _mapper.Map<List<ClienteContacto>>(model.cliente.contactos);

                var userName = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "UserName")?.Value;
                var fecha = DateTime.Now;
                persona.UsuarioRegistro = persona.UsuarioModificacion = userName;
                persona.FechaRegistro = persona.FechaModificacion = fecha;

                int idEmpresa = 10;

                persona.Clientes = new List<Cliente> { cliente };
                persona.Clientes.ForEach(l =>
                {
                    l.UsuarioRegistro = l.UsuarioModificacion = userName;
                    l.FechaRegistro = l.FechaModificacion = fecha;
                    l.IdEmpresa = idEmpresa;

                    l.ClienteContactos = contactos;
                    l.ClienteContactos.ForEach(c =>
                    {
                        c.UsuarioRegistro = c.UsuarioModificacion = userName;
                        c.FechaRegistro = c.FechaModificacion = fecha;
                        c.IdEmpresa = idEmpresa;
                    });
                });

                persona.PersonaDireccions = direccion;
                persona.PersonaDireccions.ForEach(l =>
                {
                    l.UsuarioRegistro = l.UsuarioModificacion = userName;
                    l.FechaRegistro = l.FechaModificacion = fecha;
                });              


                //save persona base
                _tacamaUnitOfWork._personaTacamaRepository.Insert(persona);
                _tacamaUnitOfWork.Save();

              
                if (persona == null)
                {
                    throw new Exception("Error al mapear la persona");
                }

                return persona.IdPersona;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
