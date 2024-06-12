﻿using AutoMapper;
using IDCL.AVGUST.SIP.Entity.Tacama.SpEntity;
using IDCL.AVGUST.SIP.ManagerDto.Tacama;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Articulo;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.TramaDiario;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;
using IDCL.Tacama.Core.Entity;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public class TacamaManager : ITacamaManager
    {
        private readonly IMapper _mapper;
        private readonly TacamaUnitOfWork _tacamaUnitOfWork;

        public TacamaManager(IMapper mapper, TacamaUnitOfWork tacamaUnitOfWork)
        {
            _mapper = mapper;
            _tacamaUnitOfWork = tacamaUnitOfWork;
        }

        public async Task<string> getCredencials(int id)
        {

            string clave = string.Empty;
            var query = _tacamaUnitOfWork._usuarioTacRepository.GetAll(l => l.IdPersona == id).FirstOrDefault();
            if (query != null)
            {
                clave = EncryptHelper.Decrypt(query.Clave);
            }

            return clave;
        }

        #region Seguridad

        public async Task<GetUsuarioTacamaDto> login(string usuario, string password)
        {
            try
            {
                var resp = new GetUsuarioTacamaDto();

                var clave = EncryptHelper.EncryptToByte(password);
                UsuarioTacama query = await _tacamaUnitOfWork._usuarioTacRepository.Autenticar(usuario, clave);
                if (query == null)
                {
                    resp.EsError = true;
                    resp.MensajeError = "Usuario y/o Clave no valido";
                    return resp;
                }
                var entidad = _mapper.Map<GetUsuarioTacamaDto>(query);
                entidad.roles = _mapper.Map<List<GetUsuarioRolTacamaDto>>(query.UsuarioRols.Select(l => l.IdRolNavigation).ToList());
                return entidad;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        #endregion

        #region Tramas
        public async Task<List<GetTramaDiarioDto>> GetTramaListByIdPersona(int idPersona)
        {
            try
            {
                var query = _tacamaUnitOfWork._tramaDiarioRepository.GetAll(p => p.IdPersona == idPersona);
                return _mapper.Map<List<GetTramaDiarioDto>>(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<GetTramaDiarioDto> AddTramaDiaria(GetTramaDiarioDto model)
        {
            try
            {
                var entidad = _mapper.Map<TramaDiario>(model);
                _tacamaUnitOfWork._tramaDiarioRepository.Insert(entidad);
                await _tacamaUnitOfWork.SaveAsync();
                return _mapper.Map<GetTramaDiarioDto>(entidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region Gestion - Pedidos


        public async Task<List<ListarPedidoNacional>> GetListarPedidoNacionalAsync(int idEmpresa, int idLocal, string codPedidoCad, bool todos, DateTime fecInicial, DateTime fecFinal,
            string Estado, string RazonSocial, bool Tipo, int idVendedor, string indCotPed)
        {

            try
            {
                var query = await _tacamaUnitOfWork._pedidoTacamaRepository.ListarPedidoNacional(idEmpresa, idLocal, codPedidoCad, todos, fecInicial, fecFinal, Estado, RazonSocial, Tipo, idVendedor, indCotPed);
                return query;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<List<GetArticuloTacamaDto>> GetArticulosTacamaAsync(string filter)
        {
            var query = _tacamaUnitOfWork._articuloTacamaRepository.GetAllTake(
                (l => filter.Contains(l.NomArticulo) || filter == ""),
                includeProperties: "ArticuloCategorium", orderBy: l => l.OrderBy(s => s.NomArticulo));

            var response = _mapper.Map<List<GetArticuloTacamaDto>>(query);

            return response;
        }


        public async Task<List<GetClienteTacamaDto>> GetClientesFilterAsync(string filter)
        {
            var query = _tacamaUnitOfWork._clienteRepository.GetAllTake(
                (l => filter.Contains(l.SiglaComercial) || filter == ""),
                includeProperties: "IdPersonaNavigation", orderBy: l => l.OrderBy(s => s.SiglaComercial), PageSize: 15);

            var response = _mapper.Map<List<GetClienteTacamaDto>>(query);
            return response;
        }


        #endregion



    }
}