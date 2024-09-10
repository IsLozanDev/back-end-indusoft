namespace IDCL.AVGUST.SIP.Entity.Tacama.Cliente.store_procedure
{
    public class usp_ApiRecuperarClientePorId
    {
        public int idPersona { get; set; }
        public int idEmpresa { get; set; }
        public int TipoCliente { get; set; }
        public string nomTipoCliente { get; set; }
        public int TipoPersona { get; set; }
        public string nomTipoPersona { get; set; }
        public int TipoDocumento { get; set; }
        public string nomTipoDocumento { get; set; }
        public string RUC { get; set; }
        public string NroDocumento { get; set; }
        public string RazonSocial { get; set; }
        public string SiglaComercial { get; set; }
        public string Nombres { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public DateTime? fecInscripcion { get; set; }
        public DateTime? fecInicioEmpresa { get; set; }
        public string idCCostos { get; set; }
        public string desCCostos { get; set; }
        public string CategoriaCliente { get; set; }
        public string nomCategoriaCliente { get; set; }
        public string indVinculada { get; set; }
        public string AgenteRetenedor { get; set; }
        public int tipConstitucion { get; set; }
        public string nomConstitucion { get; set; }
        public string tipRegimen { get; set; }
        public string nomRegimen { get; set; }
        public string catCliente { get; set; }
        public string nomcatCliente { get; set; }
        public int idCanalVenta { get; set; }
        public string nombreCanal { get; set; }
        public int Zona { get; set; }
        public string nomZona { get; set; }
        public int Calificacion { get; set; }
        public string nomCalificacion { get; set; }
        public int idPais { get; set; }
        public string nomPais { get; set; }
        public string idUbigeo { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string DireccionCompleta { get; set; }
        public string telefonos { get; set; }
        public string Fax { get; set; }
        public string Correo { get; set; }
        public string Web { get; set; }
        public string indEstado { get; set; }
        public DateTime? fecBaja { get; set; }

        public List<usp_ApiListarPersonaDireccion> direcciones { get; set; }
        public List<usp_ApiListarClienteContacto> contactos { get; set; }

    }

}
