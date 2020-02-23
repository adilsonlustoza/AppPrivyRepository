using AppPrivy.Application.Interfaces;
using AppPrivy.Application.ViewsModels;
using AppPrivy.Domain;
using AppPrivy.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppPrivy.Application
{
    public class PesquisaAppService : IPesquisaAppService
    {
        private readonly IPesquisaService _pesquisaService;
        private IMapper _mapper;
        private MapperConfiguration _config;

        public PesquisaAppService(IPesquisaService pesquisaService)
        {
            _pesquisaService = pesquisaService;
        }

        public void Add(PesquisaViewModel obj)
        {
            _config = new MapperConfiguration(cfg => { cfg.CreateMap<PesquisaViewModel, Pesquisa>(); });
            _mapper = _config.CreateMapper();
            _pesquisaService.Add(_mapper.Map<PesquisaViewModel, Pesquisa>(obj));
        }

        public void Remove(PesquisaViewModel obj)
        {
            _config = new MapperConfiguration(cfg => { cfg.CreateMap<PesquisaViewModel, Pesquisa>(); });
            _mapper = _config.CreateMapper();
            _pesquisaService.Remove(_mapper.Map<PesquisaViewModel, Pesquisa>(obj));
        }


        public void Update(PesquisaViewModel obj)
        {
            _config = new MapperConfiguration(cfg => { cfg.CreateMap<PesquisaViewModel, Pesquisa>(); });
            _mapper = _config.CreateMapper();
            _pesquisaService.Update(_mapper.Map<PesquisaViewModel, Pesquisa>(obj));
        }


        #region [-------------------------------------Query----------------------------------]
        public async Task<PesquisaViewModel> GetById(int id)
        {
            _config = new MapperConfiguration(cfg => { cfg.CreateMap<PesquisaViewModel, Pesquisa>(); });
            _mapper = _config.CreateMapper();
            return _mapper.Map<Pesquisa, PesquisaViewModel>(await _pesquisaService.GetById(id));
        }

        public async Task<ICollection<PesquisaViewModel>> GetAll(params Expression<Func<PesquisaViewModel, object>>[] children)
        {
            _config = new MapperConfiguration(cfg => { cfg.CreateMap<PesquisaViewModel, Pesquisa>(); });

            _mapper = _config.CreateMapper();

            var result = await _pesquisaService.GetAll();

            return _mapper.Map<ICollection<Pesquisa>, ICollection<PesquisaViewModel>>(result);
        }

        public async Task<ICollection<PesquisaViewModel>> Search(string propertie, params Expression<Func<PesquisaViewModel, object>>[] children)
        {
            try
            {

                var lstPesquisa = await _pesquisaService.Search(p => p.Descricao.Contains(propertie));

                if (lstPesquisa != null)
                {
                    _config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<Pesquisa, PesquisaViewModel>()
              .ReverseMap()
              .ForMember(dest => dest.IdentificadorUnico, opt => opt.Ignore())
              .ForMember(dest => dest.DataCadastro, opt => opt.Ignore());
                    });


                    _mapper = _config.CreateMapper();

                    return _mapper.Map<List<Pesquisa>, List<PesquisaViewModel>>(lstPesquisa.ToList());

                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<ICollection<PesquisaViewModel>> Search(Expression<Func<PesquisaViewModel, bool>> expression, params Expression<Func<PesquisaViewModel, object>>[] children)
        {
            throw new NotImplementedException();
        }

        #endregion

        public void Dispose()
        {
            _pesquisaService.Dispose();
        }
    }

}
