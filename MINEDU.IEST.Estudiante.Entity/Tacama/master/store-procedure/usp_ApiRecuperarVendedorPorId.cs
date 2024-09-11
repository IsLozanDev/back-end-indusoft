namespace IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure
{
    public class usp_ApiRecuperarVendedorPorId
    {
        public int idPersona { get; set; }
        public int idEmpresa { get; set; }
        public string codVendedor { get; set; }
        public string indEstado { get; set; }
        public string indSupervisor { get; set; }
        public string ManejaCartera { get; set; }
        public int idDivision { get; set; }
        public string desDivision { get; set; }
        public int idEstablecimiento { get; set; }
        public string desEstablecimiento { get; set; }
        public int idZona { get; set; }
        public string desZona { get; set; }
        public string Cargo { get; set; }
        public string NombreCotizacion { get; set; }
        public string RazonSocial { get; set; }
        public string ApeMaterno { get; set; }
        public string ApePaterno { get; set; }
        public string Nombres { get; set; }
        public string NroDocumento { get; set; }
        public string Correo { get; set; }
        public string idUbigeo { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string DireccionCompleta { get; set; }
        public DateTime? fecBaja { get; set; }

        public List<usp_ApiListarVendedorCanal> canales { get; set; }

    }
}
