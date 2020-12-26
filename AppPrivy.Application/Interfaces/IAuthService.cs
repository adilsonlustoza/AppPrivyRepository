using Appointment.Application.ViewsModels;
using System.Threading.Tasks;

namespace AppPrivy.Application.Interfaces
{
    public interface IAuthService
    {
        Task<UserToken> BuildToken(UserToken userInfo);
    }
}
