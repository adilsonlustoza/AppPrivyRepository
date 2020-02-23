using AppPrivy.CrossCutting.Agregation;
using System.Threading.Tasks;

namespace AppPrivy.Domain
{
    public interface IContatoService
    {
        Task SendMail(ContactAgregation contato);
    }
}
