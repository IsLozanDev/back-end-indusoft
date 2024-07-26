namespace IDCL.AVGUST.SIP.ManagerDto.Tacama
{
    public class GetUsuarioTacamaDto
    {
        public int IdPersona { get; set; }
        public string? NombreCorto { get; set; }

        public List<GetUsuarioRolTacamaDto> roles { get; set; }
        public string token { get; set; }

    }
}
