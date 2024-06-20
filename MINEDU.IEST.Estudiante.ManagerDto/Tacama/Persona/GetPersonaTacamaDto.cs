namespace IDCL.AVGUST.SIP.ManagerDto.Tacama.Persona
{
    public  class GetPersonaTacamaDto
    {
        public int IdPersona { get; set; }
        public int TipoPersona { get; set; }
        public string RazonSocial { get; set; } = null!;
        public string Ruc { get; set; } = null!;
        public string? ApePaterno { get; set; }
        public string? ApeMaterno { get; set; }
        public string? Nombres { get; set; }
        public int? TipoDocumento { get; set; }
        public string? NroDocumento { get; set; }
        public string? Telefonos { get; set; }
        public string? Fax { get; set; }
        public string? Correo { get; set; }
        public string? Web { get; set; }
        public string? DireccionCompleta { get; set; }
        public int? IdPais { get; set; }
        public string? IdUbigeo { get; set; }
        public bool? PrincipalContribuyente { get; set; }
        public bool? AgenteRetenedor { get; set; }
        public int? IdCanalVenta { get; set; }
        public bool? Estado { get; set; }


        public List<GetDireccionTacamaDto> PersonaDireccions { get; set; }
    }
}
