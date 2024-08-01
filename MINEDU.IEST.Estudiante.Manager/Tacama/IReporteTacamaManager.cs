using MINEDU.IEST.Estudiante.Inf_Utils.Dtos;

namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface IReporteTacamaManager
    {
        Task<GetPdfDto> GetConstanciaAsync(int idEmpresa, int idLocal, int idPedido);
        //Task<MemoryStream> GetConstanciaAsync(int idEmpresa, int idLocal, int idPedido);
    }
}