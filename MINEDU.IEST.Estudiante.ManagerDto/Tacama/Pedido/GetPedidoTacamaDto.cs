﻿using IDCL.AVGUST.SIP.ManagerDto.Tacama.Cliente;
using System.ComponentModel.DataAnnotations.Schema;

namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Pedido
{
    public class GetPedidoTacamaDto
    {
        public int IdPedido { get; set; }
        public int IdEmpresa { get; set; }
        public int IdLocal { get; set; }
        public int CodPedido { get; set; }
        public string? CodPedidoCad { get; set; }
        public string? MonedaDescription { get; set; }
        public string FormaPagoDescription { get; set; }
        public DateTime Fecha { get; set; }
        public int? IdConsignatario { get; set; }
        public int? IdNotificar { get; set; }
        public int? IdConsFitosanitario { get; set; }
        public int IdFacturar { get; set; }
        public int? IdBroker { get; set; }
        public int? IdSemanaEmbarque { get; set; }
        public int? IdPaisOrigen { get; set; }
        public int? IdOrigen { get; set; }
        public int? IdPaisDestino { get; set; }
        public int? IdDestino { get; set; }
        public int? IdFlete { get; set; }
        public int? IdBlEmision { get; set; }
        public int? IdTipoCompra { get; set; }
        public int? IdIncotermsPrecio { get; set; }
        public int? IdIncoterms { get; set; }
        public string? IdMoneda { get; set; }
        public string? Observacion { get; set; }
        public string? Indicaciones { get; set; }
        public int? IdOperador { get; set; }
        public string Estado { get; set; } = null!;
        public string? Reserva { get; set; }
        public int? IdNaviera { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Etd { get; set; }
        public string? Barco { get; set; }
        public int? AlmacenIngreso { get; set; }
        public DateTime? FechaPosic { get; set; }
        public DateTime? FechaInspeccion { get; set; }
        public string? Contenedor { get; set; }
        public string? TermografosNum { get; set; }
        public string? TermografosNum2 { get; set; }

        public string? TermografosUbi { get; set; }

        public string? TermografosUbi2 { get; set; }

        public string? PrecintoOperador { get; set; }

        public string? PrecintoNaviera { get; set; }

        public string? PrecintoSenasa { get; set; }

        public string? PrecintoAduana { get; set; }

        public string? PrecintoOtro { get; set; }

        public string? NroGuia { get; set; }
        public string? NroDocReferencia { get; set; }
        public DateTime? FecFactura { get; set; }
        public string? NroFactura { get; set; }
        public string? NroBl { get; set; }
        public string? NroDam { get; set; }
        public int? IdFormaPago { get; set; }
        public int? IdTipCondicion { get; set; }
        public int? IdCondicion { get; set; }
        public bool? IndDsctoProntoPago { get; set; }
        public decimal? DsctoProntoPago { get; set; }
        public bool? IndBonificacion { get; set; }
        public bool? IndObsStock { get; set; }
        public string? ObsStock { get; set; }
        public bool? IndObsCredito { get; set; }
        public string? ObsCredito { get; set; }
        public int? IdVendedor { get; set; }

        public int? IdEstablecimiento { get; set; }

        public int? IdZona { get; set; }

        public bool? Tipo { get; set; }
        public string TipoDescription { get; set; }
        public decimal? TotsubTotal { get; set; }
        public decimal? TotDscto1 { get; set; }
        public decimal? TotDscto2 { get; set; }
        public decimal? TotDscto3 { get; set; }
        public decimal? TotIsc { get; set; }
        public decimal? TotIgv { get; set; }
        public decimal? TotTotal { get; set; }
        public int? IdSucursalCliente { get; set; }
        public string? PuntoPartida { get; set; }
        public string? PuntoLlegada { get; set; }
        public string? Referencia { get; set; }
        public string? Contacto { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string? HorarioEntrega { get; set; }
        public bool? EsAnticipo { get; set; }
        public int? TipoDoc { get; set; }
        public int? IdTransporte { get; set; }
        public string? IndCotPed { get; set; }
        public int? IdPedidoEnlace { get; set; }
        public string? TipoGeneracion { get; set; }
        public int? IdDivision { get; set; }
        public int? IdCanalVenta { get; set; }
        public decimal? PorDscto { get; set; }
        public bool? FlagListaActivo { get; set; }
        public int? IdListaPrecio { get; set; }
        public bool? CorreoEnviado { get; set; }
        public bool? IndFechaFinReserva { get; set; }
        public DateTime? FechaFinReserva { get; set; }
        public string? UsuarioGen { get; set; }
        public DateTime? FechaGen { get; set; }
        public string? NroGuiaGen { get; set; }
        public string? NroFacturaGen { get; set; }
        public int? Aprobacion { get; set; }
        public string? MensajeAprobacion { get; set; }
        public string? IdMonedaLineaCredito { get; set; }
        public decimal? TipCambio { get; set; }
        public decimal? LineaCredito { get; set; }
        public decimal? CreditoLetras { get; set; }
        public decimal? CreditoFacturas { get; set; }
        public decimal? CreditoDocumento { get; set; }
        public decimal? LineaDisponible { get; set; }
        public string? OrdenDeCompraNum { get; set; }
        public decimal? LetraNoAceptadas { get; set; }
        public decimal? LetraProtestadas { get; set; }
        public int? IdiomaImpresion { get; set; }
        public int? IdContacto { get; set; }
        public string? PuertoOrigen { get; set; }
        public string? PuertoDestino { get; set; }
        public int? DiasValidez { get; set; }
        public int? AprobacionPrecios { get; set; }
        public string? MensajeAprobacionPrecios { get; set; }
        public bool? IndAgencia { get; set; }
        public int? IdAgenciaEnvio { get; set; }
        public int? IdDireccion { get; set; }
        public string? UbigeoCot { get; set; }
        public int? AprobacionAlmacen { get; set; }
        public string? MensajeAprobacionAlmacen { get; set; }
        public bool? IndMailServicio { get; set; }
        public int? AprobacionTg { get; set; }
        public string? MensajeAprobacionTg { get; set; }
        public bool? IndMailTg { get; set; }

        public List<GetPedidoDetalleTacamaDto> ExpPedidoDets { get; set; }
        public GetClienteHeaderPedidoDto clienteHeader { get; set; }


    }
}
