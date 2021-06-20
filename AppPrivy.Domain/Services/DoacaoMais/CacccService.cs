using AppPrivy.CrossCutting.Cache;
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Interfaces.Repositories.DoacaoMais;
using AppPrivy.Domain.Interfaces.Services.DoacaoMais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPrivy.Domain.Services.DoacaoMais
{
    public class CacccService : ServiceBase<Caccc>, ICacccService
    {
        private readonly ICacccRepository _cacccRepository;
        private readonly IBazarRepository _bazarRepository;
        private readonly IConteudoRepository _conteudoRepository;
        private readonly ICampanhaRepository _campanhaRepository;
        private readonly IContaBancariaRepository _contaBancariaRepository;
        private const string ListarConteudoContasPorCacccCache = "ListarConteudoContasPorCacccCache";
        private const string ListarCacccBazaresCache = "ListarCacccBazaresCache";
        private const string ListarCacccCache = "ListarCacccCache";


        public CacccService(
                            ICacccRepository cacccRepository,
                            IBazarRepository bazarRepository,
                            IConteudoRepository conteudoRepository,
                            ICampanhaRepository campanhaRepository,
                            IContaBancariaRepository contaBancariaRepository

            ) : base(cacccRepository)
        {
            _cacccRepository = cacccRepository;
            _bazarRepository = bazarRepository;
            _conteudoRepository = conteudoRepository;
            _campanhaRepository = campanhaRepository;
            _contaBancariaRepository = contaBancariaRepository;
        }

        public async Task<Caccc> ConteudoContasPorCaccc(int? CacccId)
        {
            try
            {
                if (!CacccId.HasValue)
                    throw new ApplicationException("Deve ser fornecido um CacccId válido.");

                var _caccca = await _cacccRepository.GetById(CacccId.Value);

                if (_caccca != null)
                {

                    var _conteudos = await _conteudoRepository.ListaConteudoCaccc(_caccca.CacccId);

                    var _contasBancarias = await _contaBancariaRepository.ListaContaBancariaCaccc(_caccca.CacccId);

                    if (_conteudos != null)
                        foreach (var itemConteudos in _conteudos)
                            _caccca.Conteudos.Add(itemConteudos);


                    if (_contasBancarias != null)
                        foreach (var itemContas in _contasBancarias)
                            _caccca.ContasBancarias.Add(itemContas);

                }

                return _caccca;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<Caccc> ConteudoContasPorNomeCaccc(string CacccNome)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CacccNome))
                    throw new ApplicationException("Deve ser fornecido um nome válido.");

                var _caccca = await _cacccRepository.Search(p => p.Nome.Trim().ToLower().Contains(CacccNome.Trim().ToLower()));


                if (_caccca == null || _caccca.Count > 1)
                    throw new ApplicationException("Sua consulta retornou um resultado inválido");

                var objCaccc = _caccca.FirstOrDefault();

                if (objCaccc != null)
                {
                    var _conteudos = await _conteudoRepository.ListaConteudoCaccc(objCaccc.CacccId);

                    var _contasBancarias = await _contaBancariaRepository.ListaContaBancariaCaccc(objCaccc.CacccId);

                    if (_conteudos != null)
                        foreach (var itemConteudos in _conteudos)
                            objCaccc.Conteudos.Add(itemConteudos);


                    if (_contasBancarias != null)
                        foreach (var itemContas in _contasBancarias)
                            objCaccc.ContasBancarias.Add(itemContas);



                    return objCaccc;
                }

                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public async Task<IEnumerable<Caccc>> ListarCaccc()
        {
            try
            {              

                if (TemporaryMemory.GetInstance().GetCache(ListarCacccCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListarCacccCache, await _cacccRepository.GetAll());
                return (IEnumerable<Caccc>)TemporaryMemory.GetInstance().GetCache(ListarCacccCache);


            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<IEnumerable<Caccc>> ListarConteudoContasPorCaccc()
        {
            try
            {
                ICollection<Caccc> _caccaList = null;
                ICollection<Conteudo> _conteudos = null;
                ICollection<ContaBancaria> _contasBancarias = null;


                if (TemporaryMemory.GetInstance().GetCache(ListarConteudoContasPorCacccCache) != null)
                    _caccaList = (ICollection<Caccc>)TemporaryMemory.GetInstance().GetCache(ListarConteudoContasPorCacccCache);
                else
                    _caccaList = await _cacccRepository.GetAll();

                if (_caccaList != null)
                {
                    foreach (var caccc in _caccaList)
                    {
                        if (caccc.Conteudos?.Count() <= 0)
                        {
                            _conteudos = await _conteudoRepository.ListaConteudoCaccc(caccc.CacccId);
                            if (_conteudos != null)
                                foreach (var itemConteudos in _conteudos)
                                    caccc.Conteudos.Add(itemConteudos);
                        }


                        if (caccc.ContasBancarias?.Count() <= 0)
                        {
                            _contasBancarias = await _contaBancariaRepository.ListaContaBancariaCaccc(caccc.CacccId);
                             if (_contasBancarias != null)
                                foreach (var itemContas in _contasBancarias)
                                    caccc.ContasBancarias.Add(itemContas);
                        }

                    }
                }

                if (TemporaryMemory.GetInstance().GetCache(ListarConteudoContasPorCacccCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListarConteudoContasPorCacccCache,  _caccaList);

                return _caccaList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public async Task<IEnumerable<Caccc>> ListarCacccBazares()
        {
            try
            {
                ICollection<Caccc> _cacccAll = null;             


                if (TemporaryMemory.GetInstance().GetCache(ListarCacccBazaresCache) != null)
                    _cacccAll = (ICollection<Caccc>)TemporaryMemory.GetInstance().GetCache(ListarCacccBazaresCache);
                else
                    _cacccAll = await _cacccRepository.GetAll();

              

                foreach (var itemCaccc in _cacccAll)
                {
                    if (itemCaccc.Bazares?.Count() <= 0)
                    {
                        var _bazares = await _bazarRepository.GetAllByCacccId(itemCaccc.CacccId);

                        if (_bazares != null && _bazares.Count()>0)
                        {
                            foreach (var itemBazar in _bazares)
                            {
                                itemCaccc.Bazares.Add(itemBazar);
                            }

                        }
                    }

                }

                if (TemporaryMemory.GetInstance().GetCache(ListarCacccBazaresCache) == null)
                    TemporaryMemory.GetInstance().CacheSave(ListarCacccBazaresCache, _cacccAll);

                return _cacccAll;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public async Task<IEnumerable<Caccc>> UltimasAtualizacoes()
        {
            try
            {
                var _cacccAll = await _cacccRepository.GetAll();

                foreach (var itemCaccc in _cacccAll)
                {
                    var _bazares = await _bazarRepository.GetAllByCacccId(itemCaccc.CacccId);

                    if (_bazares != null)
                    {
                        foreach (var itemBazar in _bazares)
                        {
                            itemCaccc.Bazares.Add(itemBazar);
                        }

                    }


                }

                return _cacccAll;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
    }


}

