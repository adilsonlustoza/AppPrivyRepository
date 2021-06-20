using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Entities.ObjectValue;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface IEstatisticoRepository: IRepositoryBase<Estatistico>
    {
            Task<IEnumerable<Estatistico>> ListaEstatistico();
            Task<IEnumerable<Estatistico>> ListaEstatisticoPorTipo(TipoEstatisco tipoEstatisco);
        
    }
}
