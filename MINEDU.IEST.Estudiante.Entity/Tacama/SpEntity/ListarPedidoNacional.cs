namespace IDCL.AVGUST.SIP.Entity.Tacama.SpEntity
{
    public class ListarPedidoNacional
    {
        public long idEmpresa { get; set; }

        public long idLocal { get; set; }

        public long idPedido { get; set; }

        public string codPedidoCad { get; set; }

        public DateTime Fecha { get; set; }

        public long idFacturar { get; set; }

        public string desFacturar { get; set; }

        public long idNotificar { get; set; }

        public object desNotificador { get; set; }

        public string idMoneda { get; set; }

        public string desMoneda { get; set; }

        public string Observacion { get; set; }

        public string Estado { get; set; }

        public string desEstado { get; set; }

        public long Tipo { get; set; }

        public long idVendedor { get; set; }

        public string Vendedor { get; set; }

        public long idDivision { get; set; }

        public long idEstablecimiento { get; set; }

        public long idZona { get; set; }

        public string NemoTipoDoc { get; set; }

        public long idFormaPago { get; set; }

        public long TipoDoc { get; set; }

        public string nrofactura { get; set; }

        public object nroGuia { get; set; }

        public long idPedidoEnlace { get; set; }

        public string tipoGeneracion { get; set; }

        public object CorreoEnviado { get; set; }

        public string UsuarioRegistro { get; set; }

        public DateTime fechaRegistro { get; set; }

        public string UsuarioModificacion { get; set; }

        public DateTime fechaModificacion { get; set; }

        public long indObsStock { get; set; }

        public string desindObsStock { get; set; }

        public long indObsCredito { get; set; }

        public string desindObsCredito { get; set; }

        public long indBonificacion { get; set; }

        public string desindBonificacion { get; set; }

        public bool? indDsctoProntoPago { get; set; }

        public long DsctoProntoPago { get; set; }

        public double totsubTotal { get; set; }

        public double totIgv { get; set; }

        public double totDsctos { get; set; }

        public long totTotal { get; set; }

        public long indFechaFinReserva { get; set; }

        public object FechaFinReserva { get; set; }

        public object UsuarioGen { get; set; }

        public object FechaGen { get; set; }

        public object NroGuiaGen { get; set; }

        public object nroFacturaGen { get; set; }

        public string idMonedaLineaCredito { get; set; }

        public long tipCambio { get; set; }

        public long LineaCredito { get; set; }

        public long CreditoLetras { get; set; }

        public long CreditoFacturas { get; set; }

        public long CreditoDocumento { get; set; }

        public long LineaDisponible { get; set; }

        public string OrdenDeCompraNum { get; set; }

        public long LetraNoAceptadas { get; set; }

        public long LetraProtestadas { get; set; }

        public long IdPaisOrigen { get; set; }

        public long idPaisDestino { get; set; }

        public long idIncoterms { get; set; }

        public long IdiomaImpresion { get; set; }

        public long idContacto { get; set; }

        public DateTime FechaEntrega { get; set; }

        public long Aprobacion { get; set; }

        public string MensajeAprobacion { get; set; }

        public string desAprobacion { get; set; }

        public long AprobacionPrecios { get; set; }

        public string MensajeAprobacionPrecios { get; set; }

        public string desAprobacionPrecios { get; set; }

        public long AprobacionAlmacen { get; set; }

        public object MensajeAprobacionAlmacen { get; set; }

        public string desAprobacionAlmacen { get; set; }

        public long AprobacionTg { get; set; }

        public object MensajeAprobacionTg { get; set; }

        public string DesAprobacionTg { get; set; }

        public long idCanalVenta { get; set; }

        public string nombreCanal { get; set; }

        public long TipoCanal { get; set; }

        public long Facturado { get; set; }

        public string desCondicion { get; set; }

        public string PuntoLlegada { get; set; }
    }
}
