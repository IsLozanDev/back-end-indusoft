using IDCL.AVGUST.SIP.Entity.Tacama.SpEntity;

namespace IDCL.AVGUST.SIP.Repository.Tacama.Procedure
{
    public interface IPedidoTacamaRepository
    {
        Task<List<ListarPedidoNacional>> ListarPedidoNacional(int idEmpresa, int idLocal, string codPedidoCad, bool todos, DateTime fecInicial, DateTime fecFinal, string Estado, 
            string RazonSocial, bool Tipo, int idVendedor, string indCotPed);
    }
}