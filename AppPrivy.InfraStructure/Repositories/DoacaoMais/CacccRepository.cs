using AppPrivy.Domain.Entities.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPrivy.Data.Interface;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Data.Repositories;
using AppPrivy.Domain.Entities.ObjectValue;

namespace AppPrivy.Data.Repositories.DoacaoMais
{
    public class CacccRepository : RepositoryBaseDoacaoMais<Caccc>, ICacccRepository
    {
        private readonly IContextManager _contextManager;

        public CacccRepository(IContextManager contextManager):base(contextManager)
        {
            _contextManager = contextManager;
        }


        //public new int ExecuteCommand(string command, object[] obj)
        //{
        //    return _contextManager.DoacaoMaisContext().Database.ExecuteSqlCommand(command, obj);
        //}

       
    }
}
