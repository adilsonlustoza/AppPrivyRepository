﻿using AppPrivy.Domain.Entities.DoacaoMais;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Interfaces.Repositories.DoacaoMais
{
    public interface ICampanhaRepository : IRepositoryBase<Campanha>
    {
        Task<ICollection<Campanha>> ListarCampanhasCaccc(int? CacccId);
    }
}
