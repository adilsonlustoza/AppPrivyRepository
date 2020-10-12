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
        private readonly IBoletimRepository _campanhaRepository;
        private readonly IContaBancariaRepository _contaBancariaRepository;

        public CacccService(
                            ICacccRepository cacccRepository,
                            IBazarRepository bazarRepository,
                            IConteudoRepository conteudoRepository,
                            IBoletimRepository campanhaRepository,
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

        public async Task<IEnumerable<Caccc>> ListarConteudoContasPorCaccc()
        {
            try
            {


                var _caccaList = await _cacccRepository.GetAll();

                if (_caccaList != null)
                {
                    foreach (var caccc in _caccaList)
                    {

                        var _conteudos = await _conteudoRepository.ListaConteudoCaccc(caccc.CacccId);

                        var _contasBancarias = await _contaBancariaRepository.ListaContaBancariaCaccc(caccc.CacccId);

                        if (_conteudos != null)
                            foreach (var itemConteudos in _conteudos)
                                caccc.Conteudos.Add(itemConteudos);


                        if (_contasBancarias != null)
                            foreach (var itemContas in _contasBancarias)
                                caccc.ContasBancarias.Add(itemContas);

                    }
                }

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

