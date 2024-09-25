using AutoMapper;
using IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure;
using IDCL.AVGUST.SIP.Entity.Tacama.SpEntity;
using IDCL.AVGUST.SIP.ManagerDto.Tacama;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Articulo;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Maestro;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Pedido;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Pedido.Cmd;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Persona;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.TramaDiario;
using IDCL.AVGUST.SIP.Repository.UnitOfWork.Tacama;
using IDCL.Tacama.Core.Entity;
using Microsoft.AspNetCore.Http;
using MINEDU.IEST.Estudiante.Inf_Utils.Constants;
using MINEDU.IEST.Estudiante.Inf_Utils.Dtos;
using MINEDU.IEST.Estudiante.Inf_Utils.Helpers;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public class TacamaManager : ITacamaManager
    {
        private readonly IMapper _mapper;
        private readonly TacamaUnitOfWork _tacamaUnitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ResourceDto _resourceDto;
        private readonly MasterTacamaUnitOfWork _masterTacamaUnitOfWork;

        public TacamaManager(IMapper mapper,
            TacamaUnitOfWork tacamaUnitOfWork,
            IHttpContextAccessor httpContextAccessor,
            ResourceDto resourceDto,
            MasterTacamaUnitOfWork masterTacamaUnitOfWork)
        {
            _mapper = mapper;
            _tacamaUnitOfWork = tacamaUnitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _resourceDto = resourceDto;
            _masterTacamaUnitOfWork = masterTacamaUnitOfWork;
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

        public async Task<GetUsuarioTacamaDto?> login(string usuario, string password)
        {
            try
            {
                var resp = new GetUsuarioTacamaDto();
                var clave = EncryptHelper.EncryptToByte(password);
                var query = await _tacamaUnitOfWork._usuarioTacRepository.Autenticar(usuario, clave);
                if (query != null)
                {
                    resp = _mapper.Map<GetUsuarioTacamaDto>(query);
                    resp.idEstablecimiento = query.IdVendedorNavigation.IdEstablecimiento.Value;
                    resp.idZona = query.IdVendedorNavigation.IdZona.Value;
                    resp.idDivision = query.IdVendedorNavigation.IdDivision.Value;

                    resp.textDivision = query.IdVendedorNavigation.IdDivisionNavigation?.DesDivision;
                    resp.textEstablecimiento = query.IdVendedorNavigation?.IdEstablecimientoNavigation?.Descripcion;
                    resp.textZona = query.IdVendedorNavigation?.IdZonaNavigation?.Descripcion;

                    resp.roles = _mapper.Map<List<GetUsuarioRolTacamaDto>>(query.UsuarioRols.Select(l => l.IdRolNavigation).ToList());
                    return resp;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> loginExt(string email)
        {
            try
            {
                var query = await _tacamaUnitOfWork._personaTacamaRepository.GetPersonaByEmailAsync(email);
                return query;

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
                return query.Take(20)
                    .OrderByDescending(l => l.Fecha)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CmdPedidoTacamaDto> SavePedido(CmdPedidoTacamaDto model)
        {
            var userName = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == "UserName")?.Value;

            var pedido = _mapper.Map<ExpPedidoCab>(model);
            var resp = new CmdPedidoTacamaDto();

            try
            {
                var cliente = _tacamaUnitOfWork._personaTacamaRepository.GetAll(l => l.Ruc == model.NroRucCliente).FirstOrDefault();

                if (cliente != null)
                {
                    pedido.IdFacturar = cliente.IdPersona;
                }
                else
                {
                    resp.EsError = true;
                    resp.MensajeError = "El ruc ingresado no existe o no es valido";
                    return resp;
                }

                if (pedido.IdPedido == 0)
                {
                    //Obtener Codigo Pedido 
                    var nroPedido = await _tacamaUnitOfWork._pedidoTacamaRepository.ObtenerNroPedido(10, 1, "P");

                    //Adicionales
                    pedido.IdEmpresa = 10;
                    pedido.IdLocal = 1;
                    pedido.CodPedidoCad = nroPedido;
                    pedido.UsuarioModificacion = pedido.UsuarioRegistro = userName;
                    pedido.FechaModificacion = pedido.FechaRegistro = DateTime.Now;
                    pedido.IndCotPed = "P";
                    pedido.IdTipCondicion = 1;
                    pedido.Estado = "P";
                    pedido.NroGuia = pedido.NroFactura = pedido.NroGuiaGen = pedido.NroFacturaGen = string.Empty;
                    pedido.FecFactura = null;
                    pedido.TipoGeneracion = "N";

                    var tc = await _tacamaUnitOfWork._pedidoTacamaRepository.ObtenerTipoCambioPorDia("02", pedido.Fecha.Date);
                    if (tc != null)
                        pedido.TipCambio = tc.valVenta;

                    pedido.ExpPedidoDets.ForEach(l =>
                    {
                        l.IdEmpresa = pedido.IdEmpresa;
                        l.IdLocal = pedido.IdLocal;
                        l.CantidadUnit = 0;
                        l.CantidadFinal = l.Cantidad;
                        l.UsuarioRegistro = l.UsuarioModificacion = pedido.UsuarioRegistro;
                        l.FechaRegistro = l.FechaModificacion = pedido.FechaRegistro;
                    });

                    _tacamaUnitOfWork._pedidoTacamaRepository.Insert(pedido);
                    await _tacamaUnitOfWork.SaveAsync();
                }
                else
                {
                    // Delete details existing             
                    var query = _tacamaUnitOfWork._pedidoTacamaRepository.GetAll(p => p.IdPedido == model.IdPedido, includeProperties: "ExpPedidoDets").FirstOrDefault();

                    var detailsForRemove = query.ExpPedidoDets;

                    detailsForRemove.ForEach(p =>
                    {
                        _tacamaUnitOfWork._pedidoDetalleTacamaRepository.Delete(p);
                    });

                    await _tacamaUnitOfWork.SaveAsync();


                    query.TotIgv = model.TotIgv;
                    query.TotsubTotal = model.TotsubTotal;
                    query.TotTotal = model.TotTotal;
                    query.TotDscto1 = model.TotDscto1;
                    query.ExpPedidoDets = _mapper.Map<List<ExpPedidoDet>>(model.ExpPedidoDets);


                    query.UsuarioModificacion = userName;
                    query.FechaModificacion = DateTime.Now;


                    query.ExpPedidoDets.ForEach(l =>
                    {
                        l.IdEmpresa = query.IdEmpresa;
                        l.IdLocal = query.IdLocal;
                        l.CantidadUnit = 0;
                        l.CantidadFinal = l.Cantidad;
                        l.UsuarioModificacion = query.UsuarioRegistro;
                        l.FechaModificacion = query.FechaRegistro;
                    });

                    _tacamaUnitOfWork._pedidoTacamaRepository.Update(query);
                    await _tacamaUnitOfWork.SaveAsync();
                }

                var result = _mapper.Map<CmdPedidoTacamaDto>(pedido);
                result.IdFacturar = pedido.IdPedido;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public async Task<bool> AddDuplicatePedidoAsync(int idPedidoOrigen)
        {
            var pedidoOrigen = _tacamaUnitOfWork._pedidoTacamaRepository.GetAll(l => l.IdPedido == idPedidoOrigen, includeProperties: "ExpPedidoDets").FirstOrDefault();
            var usuarioId = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == SecurityClaimType.IdUsuario)?.Value;
            var userName = _httpContextAccessor.HttpContext.User.Claims.FirstOrDefault(p => p.Type == SecurityClaimType.PersonId)?.Value;
            if (pedidoOrigen == null)
            {
                return false;
            }
            var pedidoClon = new ExpPedidoCab();
            pedidoClon = pedidoOrigen;


            //Obtener Codigo Pedido 
            var nroPedido = await _tacamaUnitOfWork._pedidoTacamaRepository.ObtenerNroPedido(10, 1, "P");

            pedidoOrigen.Estado = "P";

            pedidoOrigen.IdVendedor = Convert.ToInt32(usuarioId);
            pedidoOrigen.UsuarioModificacion = pedidoOrigen.UsuarioRegistro = userName;


            var tc = await _tacamaUnitOfWork._pedidoTacamaRepository.ObtenerTipoCambioPorDia("02", DateTime.Now.Date);
            if (tc != null)
                pedidoClon.TipCambio = tc.valVenta;

            pedidoClon.IdPedido = 0;
            pedidoClon.CodPedidoCad = string.Empty;

            _tacamaUnitOfWork._pedidoTacamaRepository.Insert(pedidoOrigen);
            await _tacamaUnitOfWork.SaveAsync();


            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a pedido for editing by its ID.
        /// </summary>
        /// <param name="idPedido">The ID of the pedido to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the pedido details.</returns>
        public async Task<GetPedidoTacamaDto> GetPedidoForEditAsync(int idPedido)
        {
            var query = await _tacamaUnitOfWork._pedidoTacamaRepository.GetPedidoAllByIdAsync(idPedido);
            var cliente = await this.GetCanalandConditionByIdClienteAsync(query.IdFacturar);
            var response = _mapper.Map<GetPedidoTacamaDto>(query);
            response.TipoDescription = response.Tipo.Value ? "Exportación" : "Nacional";
            response.clienteHeader = cliente;
            return response;
        }

        #endregion

        #region Clientes
        public async Task<List<GetClienteTacamaDto>> GetClientesFilterAsync(string filter)
        {
            var query = _tacamaUnitOfWork._clienteRepository.GetAllTake(
                (l => filter.Contains(l.SiglaComercial) || filter == ""),
                includeProperties: "IdPersonaNavigation", orderBy: l => l.OrderBy(s => s.SiglaComercial), PageSize: 15);

            var response = _mapper.Map<List<GetClienteTacamaDto>>(query);
            return response;
        }
        public async Task<List<GetListPersonaDto>> GetListClientesFilterAsync(string filter)
        {
            var query = _tacamaUnitOfWork._personaTacamaRepository
                .GetAllTake(l => !string.IsNullOrEmpty(l.RazonSocial.Trim()) &&
                (l.Ruc.Contains(filter) ||
                    l.RazonSocial.Contains(filter) ||
                    filter == ""
                ),
                includeProperties: "Clientes", orderBy: l => l.OrderBy(s => s.RazonSocial.Trim().TrimStart()), PageSize: 15);

            var response = _mapper.Map<List<GetListPersonaDto>>(query);

            return response;
        }
        public async Task<GetClienteHeaderPedidoDto> GetCanalandConditionByIdClienteAsync(int idcliente)
        {
            var query = _tacamaUnitOfWork._personaTacamaRepository
                .GetAll(p => p.IdPersona == idcliente,
                includeProperties: "PersonaDireccions,CanalesVenta.IdListaPrecioNav")
                .FirstOrDefault();
            var response = _mapper.Map<GetClienteHeaderPedidoDto>(query);
            response.NombreCliente = $"{response.Ruc} - {query.RazonSocial}";

            var canvalVenta = _tacamaUnitOfWork._canalVentaRepository.GetAll(p => p.IdCanalVenta == query.IdCanalVenta,
                includeProperties: "IdListaPrecioNav").FirstOrDefault();
            var condiciones = _tacamaUnitOfWork._condicionasRepository.GetAll(p => p.IdTipCondicion == 1);

            if (canvalVenta != null)
            {
                response.IdCanalVenta = canvalVenta.IdCanalVenta;
                response.NombreCanalVenta = canvalVenta.NombreCanal;
                response.IdListaPrecio = canvalVenta.IdListaPrecio.Value;
                response.NombreListaPrecio = canvalVenta.IdListaPrecioNav.Nombre;
            }

            var ubigeos = await _masterTacamaUnitOfWork._ubigeoTacamaRepository.GetPuntoEntrebaByUbigeoAsync(query.IdUbigeo);

            if (ubigeos != null)
            {
                response.puntoEntrega = ubigeos;
            }
            response.condiciones = _mapper.Map<List<GetCondicionHeaderDto>>(condiciones);

            return response;
        }

        #endregion

        #region Articulos
        public async Task<List<usp_ApiListarArticulosServicios>> GetListarArticulosServiciosApiSPAsync(int idEmpresa, int idTipoArticulo, string Filtro) =>
            await _tacamaUnitOfWork._articuloTacamaRepository.GetListarArticulosServiciosApi(idEmpresa, idTipoArticulo, Filtro);

        public async Task<List<GetArticuloTacamaDto>> GetArticulosTacamaAsync(string filter)
        {
            var query = _tacamaUnitOfWork._articuloTacamaRepository.GetAllTake(
                (l => filter.Contains(l.NomArticulo) || filter == ""),
                includeProperties: "ArticuloCategorium", orderBy: l => l.OrderBy(s => s.NomArticulo));

            var response = _mapper.Map<List<GetArticuloTacamaDto>>(query);

            return response;
        }
        public async Task<List<GetListArticuloDto>> GetListArticulosTacamaFiltersAsync(string filter)
        {
            var query = _tacamaUnitOfWork._articuloTacamaRepository
                .GetAllTake(
                (
                    l => l.CodArticulo.Contains(filter) ||
                    l.NomArticuloLargo.Contains(filter) ||
                    filter == ""
                ),
                orderBy: l => l.OrderBy(s => s.NomArticuloLargo.Trim().TrimStart()), PageSize: 15);

            var response = _mapper.Map<List<GetListArticuloDto>>(query);

            return response;
        }

        public async Task<List<GetArticuloSearchPedidoDto>> GetArticulosDetailsPedidoAsync(
            int idEmpresa,
            int idAlmacen,
            int idTipoArticulo,
            string Anio,
            string Mes,
            string codArticulo,
            string nomArticulo,
            int idListaPrecio,
            bool conLote,
            DateTime FechaStock,
            int idCanalVenta = 0)
        {
            var query = await _tacamaUnitOfWork._pedidoTacamaRepository.GetArticulosPorListaPrecioCanalStock(
                idEmpresa,
                idAlmacen,
                idTipoArticulo,
                Anio,
                Mes,
                codArticulo,
                nomArticulo,
                idListaPrecio,
                conLote,
                FechaStock,
                idCanalVenta);

            var response = _mapper.Map<List<GetArticuloSearchPedidoDto>>(query.Take(15));
            return response;
        }

        public async Task<List<GetArticuloSearchPedidoApiDto>> GetArticulosDetailsPedidoApiAsync(
            int idEmpresa,
            int idAlmacen,
            int idTipoArticulo,
            string Anio,
            string Mes,
            string codArticulo,
            string nomArticulo,
            int idListaPrecio,
            bool conLote,
            DateTime FechaStock,
            int idCanalVenta = 0)
        {
            var query = await _tacamaUnitOfWork._pedidoTacamaRepository.GetArticulosPorListaPrecioCanalStock(
                idEmpresa,
                idAlmacen,
                idTipoArticulo,
                Anio,
                Mes,
                codArticulo,
                nomArticulo,
                idListaPrecio,
                conLote,
                FechaStock,
                idCanalVenta);

            var response = _mapper.Map<List<GetArticuloSearchPedidoApiDto>>(query.Take(15));
            return response;
        }

        #endregion

    }
}
