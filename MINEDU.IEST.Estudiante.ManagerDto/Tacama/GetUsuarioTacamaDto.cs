namespace IDCL.AVGUST.SIP.ManagerDto.Tacama
{
    public class GetUsuarioTacamaDto
    {
        public int IdPersona { get; set; }
        public string? NombreCorto { get; set; }

        public List<GetUsuarioRolTacamaDto> roles { get; set; }

        public int idEstablecimiento { get; set; }
        public int idDivision { get; set; }
        public int idZona { get; set; }
        
        public string textEstablecimiento { get; set; }
        public string textDivision { get; set; }
        public string textZona { get; set; }
        public string token { get; set; }



    }
}
