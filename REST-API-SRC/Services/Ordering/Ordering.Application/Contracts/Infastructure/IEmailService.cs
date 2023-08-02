using Ordering.Application.Modals;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
