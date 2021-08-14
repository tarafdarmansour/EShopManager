using EshopManager.Application.Requests.Mail;
using System.Threading.Tasks;

namespace EshopManager.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}