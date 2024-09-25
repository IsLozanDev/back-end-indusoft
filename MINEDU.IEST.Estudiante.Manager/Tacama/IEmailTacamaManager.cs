
namespace IDCL.AVGUST.SIP.Manager.Tacama
{
    public interface IEmailTacamaManager
    {
        Task<bool> SendEmailAsync(int idPedido);
    }
}