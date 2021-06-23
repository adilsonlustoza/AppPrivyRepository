using AppPrivy.CrossCutting.Operations;
using AppPrivy.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.Domain
{
    public class PesquisaService : IPesquisaService
    {
        private readonly IPesquisaRepository _pesquisaRepository;

        public PesquisaService(IPesquisaRepository pesquisaRepository)
        {
            _pesquisaRepository = pesquisaRepository;

        }

        public async Task<Pesquisa> Add(Pesquisa obj)
        {

            try
            {

              return await  _pesquisaRepository.Add(obj);

            }
            catch (Exception e)
            {

                throw e;
            }



        }

        public async Task Update(Pesquisa obj)
        {
           await _pesquisaRepository.Update(obj);
        }

        public async Task Remove(Pesquisa obj)
        {
            await _pesquisaRepository.Remove(obj);
        }

        public void Dispose()
        {
            this.Dispose();
        }


        public async Task<Pesquisa> GetById(int id)
        {
            try
            {
                return await _pesquisaRepository.GetById(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<ICollection<Pesquisa>> Search(Expression<Func<Pesquisa, bool>> expression, params Expression<Func<Pesquisa, object>>[] children)
        {
            try
            {
                return await _pesquisaRepository.Search(expression, children);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

      

        public async Task<ICollection<Pesquisa>> GetAll(params Expression<Func<Pesquisa, object>>[] children)
        {
            return await _pesquisaRepository.GetAll(children);
        }

        public async Task<int?> SaveChangesAsync()
        {
            return await _pesquisaRepository.SaveChangesAsync();
        }
    }
}

