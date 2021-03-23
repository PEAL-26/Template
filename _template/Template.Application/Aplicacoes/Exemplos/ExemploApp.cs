using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using $safeprojectname$.Interfaces;
using $safeprojectname$.ViewModels;
using $safeprojectname$.Domain.Entidades;
using $safeprojectname$.Domain.Interfaces;
using $safeprojectname$.Infra.Data.Interfaces;

namespace $safeprojectname$.Aplicacoes
{
    public class ExemploApp : IExemploApp
    {
        private readonly IExemploServico _exemploServico;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public ExemploApp(IExemploServico anoLectivoServico, IMapper mapper, IUnitOfWork uow)
        {
            _exemploServico = anoLectivoServico;
            _mapper = mapper;
            _uow = uow;
        }

        #region "Guardar"
        public async Task Guardar(ExemploViewModel obj)
        {
            var anoLectivo = _mapper.Map<Exemplo>(obj);
            await _exemploServico.Guardar(anoLectivo);

            if (!await _uow.Commit())
                await _uow.Rollback();
        }

        public async Task Guardar(ICollection<ExemploViewModel> obj)
        {
            var anoLectivo = _mapper.Map<Exemplo>(obj);
            await _exemploServico.Guardar(anoLectivo);

            if (!await _uow.Commit())
                await _uow.Rollback();
        }
        #endregion

        #region "Remover"
        public async void Remover(ExemploViewModel obj)
        {

            var anoLectivo = _mapper.Map<Exemplo>(obj);
            _exemploServico.Remover(anoLectivo);

            if (!await _uow.Commit())
                await _uow.Rollback();
        }

        public async void Remover(ICollection<ExemploViewModel> obj)
        {
            foreach (var item in obj)
            {
                var anoLectivo = _mapper.Map<Exemplo>(item);
                _exemploServico.Remover(anoLectivo);
            }

            if (!await _uow.Commit())
                await _uow.Rollback();

        }
        #endregion

        #region "Listagens e Bucas"
        public async Task<ICollection<ExemploViewModel>> ListarTodos()
        {
            return _mapper.Map<ICollection<ExemploViewModel>>(await _exemploServico.ListarTodos());
        }

        public async Task<ExemploViewModel> BuscarPorId(int id)
        {
            return _mapper.Map<ExemploViewModel>(await _exemploServico.BuscarPorId(id));
        }

        #endregion
    }
}
