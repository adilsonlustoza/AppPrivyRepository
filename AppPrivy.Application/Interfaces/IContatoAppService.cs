
using AppPrivy.CrossCutting.Agregation;
using System;
using System.Threading.Tasks;

namespace AppPrivy.Application.Interfaces
{
    public interface IContatoAppService
    {
        Task SendMail(ContactAgregation contato);

        Boolean GoogleCaptcha();

    }
}
