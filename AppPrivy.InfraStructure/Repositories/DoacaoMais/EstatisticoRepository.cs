using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Entities.ObjectValue;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class EstatisticoRepository : RepositoryBase<Estatistico>, IEstatisticoRepository
    {

        public EstatisticoRepository(IContextManager contextManager) : base(contextManager)
        {
            
        }
              

        public async Task<IEnumerable<Estatistico>> ListaEstatistico()
        {
            return await this.GetAll();
        }

        public async Task<IEnumerable<Estatistico>> ListaEstatisticoPorTipo(TipoEstatisco tipoEstatisco)
        {
            return await this.Search(p => p.Tipo == tipoEstatisco);
        }
    }
}
