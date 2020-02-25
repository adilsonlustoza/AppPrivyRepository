
using AppPrivy.CrossCutting.Agregation;
using System.Threading.Tasks;

namespace AppPrivy.Application.Interfaces
{
    public interface IContatoAppService
    {
        Task SendMail(ContactAgregation contato);

        bool GoogleCaptcha();

    }
}
