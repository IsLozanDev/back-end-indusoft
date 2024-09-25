namespace IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure
{
    public class usp_ApiListarVendedoresZonai
    {
        public int idPersona { get; set; }
        public int idEmpresa { get; set; }
        public int idLocal { get; set; }
        public int idEstablecimiento { get; set; }
        public string DesEstablecimientos { get; set; }
        public int idZona { get; set; }
        public string DesZona { get; set; }
        public string idCCostos { get; set; }
        public int Porcentaje { get; set; }
    }
}
