using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.InfraStructure.Interface;

namespace AppPrivy.InfraStructure.Repositories.DoacaoMais
{
    public class CacccRepository : RepositoryBase<Caccc>, ICacccRepository
    {
        private readonly IContextManager _contextManager;

        public CacccRepository(IContextManager contextManager) : base(contextManager)
        {
            _contextManager = contextManager;
        }


        //public new int ExecuteCommand(string command, object[] obj)
        //{
        //    return _contextManager.DoacaoMaisContext().Database.ExecuteSqlCommand(command, obj);
        //}


    }
}
