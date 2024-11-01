namespace IDCL.AVGUST.SIP.Entity.Tacama.master.store_procedure
{
    public class usp_ApiListarArticulosServicios
    {
        public int idEmpresa { get; set; }
        public int idArticulo { get; set; }
        public string codArticulo { get; set; }
        public string nomArticulo { get; set; }
        public string nomArticuloEng { get; set; }
        public string nomCorto { get; set; }
        public int codTipoMedAlmacen { get; set; }
        public int codUniMedAlmacen { get; set; }
        public string nomUMedida { get; set; }
        public string indAfectoIgv { get; set; }
        public decimal porigv { get; set; }
    }
}
