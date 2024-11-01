namespace IDCL.AVGUST.SIP.Entity.Tacama.Cliente.store_procedure
{
    public class usp_ListarClientePorParametro
    {
        public int IdEmpresa { get; set; }
        public int? IdCanalVenta { get; set; }
        public string NombreCanal { get; set; }
        public int IdPersona { get; set; }
        public string SiglaComercial { get; set; }
        public string RazonSocial { get; set; }
        public string TipoPersonaDes { get; set; }
        public string TipoDocumentoDes { get; set; }
        public string RUC { get; set; }
        public string NombreVendedor { get; set; }
        public string DireccionCompleta { get; set; }
        public string DesPais { get; set; }
        public string Departamento { get; set; }
        public string DesTel { get; set; }
        public string Correo { get; set; }
        public string IndEstado { get; set; }
        public string? IdCCostos { get; set; }
        public string IndVinculada { get; set; }
        //public string UsuarioRegistro { get; set; }
        //public DateTime FechaRegistro { get; set; }
        //public string UsuarioModificacion { get; set; }
        //public DateTime FechaModificacion { get; set; }
        public string Nombres { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string AgenteRetenedor { get; set; }
    }
}
