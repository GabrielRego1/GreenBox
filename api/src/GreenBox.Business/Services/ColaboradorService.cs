using GreenBox.Business.Interfaces;
using GreenBox.Business.Models;
using GreenBox.Business.Validations;

namespace GreenBox.Business.Services
{
    public class ColaboradorService : BaseService, IColaboradorService
    {
        private readonly IColaboradorRepository _colaboradorRepository;

        public ColaboradorService(INotificador notificador,
                                  IColaboradorRepository colaboradorRepository) : base(notificador)
        {
            _colaboradorRepository = colaboradorRepository;
        }

        public async Task Adicionar(Colaborador colaborador)
        {
            if (!ExecutarValidacao(new ColaboradorValidation(), colaborador)) return;

            await _colaboradorRepository.Adicionar(colaborador);
        }

        public async Task Atualizar(Colaborador colaborador)
        {
            if (!ExecutarValidacao(new ColaboradorValidation(), colaborador)) return;

            await _colaboradorRepository.Atualizar(colaborador);
        }

        public async Task Remover(Guid id)
        {
            await _colaboradorRepository.Remover(id);
        }

        public void Dispose()
        {
            _colaboradorRepository?.Dispose();
        }
    }
}
