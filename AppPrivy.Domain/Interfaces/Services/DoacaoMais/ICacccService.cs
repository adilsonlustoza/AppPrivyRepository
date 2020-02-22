using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Entities.ObjectValue;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Services.DoacaoMais
{
    public interface ICacccService:IServiceBase<Caccc>
    {
         Task<IEnumerable<Caccc>> ListarCacccBazares();

         Task<IEnumerable<Caccc>> ListarConteudoContasPorCaccc();

         Task<Caccc> ConteudoContasPorNomeCaccc(string caccc); 

         Task<Caccc> ConteudoContasPorCaccc(int? CacccId);
             
     
  


    }
}
