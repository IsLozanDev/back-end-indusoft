namespace MINEDU.IEST.Estudiante.Inf_Utils.Dtos
{
    public class ResourceDto
    {
        public string UrlFileBase { get; set; }
        public string Documents { get; set; }
        public string ImagesUser { get; set; }
        public bool IsDev { get; set; }
        public string storage { get; set; }
        public string template_correo { get; set; }
    }

    public class ConfigJwt
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Secret { get; set; }
    }
}
