﻿using AutoMapper;
using IDCL.AVGUST.SIP.Entity.Tacama.SpEntity;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Articulo;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente;
using IDCL.AVGUST.SIP.ManagerDto.Tacama.Maestro;
using IDCL.Tacama.Core.Entity;

namespace IDCL.AVGUST.SIP.Manager.MappingDto
{
    public class AutoMapperTacama: Profile
    {
        public AutoMapperTacama()
        {
            #region Pedidos


            #endregion

            #region Clientes

            CreateMap<PersonaTacama, GetClienteHeaderPedidoDto>()
                .ForMember(dest => dest.IdCanalVenta, source => source.MapFrom(s => s.CanalesVenta.FirstOrDefault().IdCanalVenta))
                
                .ForMember(dest => dest.NombreCanalVenta, source => source.MapFrom(s => s.CanalesVenta.FirstOrDefault().NombreCanal))
                .ForMember(dest => dest.IdListaPrecio, source => source.MapFrom(s => s.CanalesVenta.FirstOrDefault().IdListaPrecioNav.IdListaPrecio))
                .ForMember(dest => dest.NombreListaPrecio, source => source.MapFrom(s => s.CanalesVenta.FirstOrDefault().IdListaPrecioNav.Nombre))
                .ForMember(dest => dest.Direccion, source => source.MapFrom(s => s.DireccionCompleta));
            #endregion

            #region Maestros
            CreateMap<Condicion, GetCondicionHeaderDto>()
                          .ForMember(dest => dest.Id, source => source.MapFrom(s => s.IdCondicion))
                          .ForMember(dest => dest.Descripcion, source => source.MapFrom(s => s.DesCondicion));


            #endregion

            #region Articulos

            CreateMap<GetArticulosPorListaPrecioCanalStock, GetArticuloSearchPedidoDto>();

            #endregion
        }
    }
}
