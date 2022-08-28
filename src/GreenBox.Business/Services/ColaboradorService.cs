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

        public async Task Adicionar(Colaborador Colaborador)
        {
            if (!ExecutarValidacao(new ColaboradorValidation(), Colaborador)) return;

            await _colaboradorRepository.Adicionar(Colaborador);
        }

        public async Task Atualizar(Colaborador Colaborador)
        {
            if (!ExecutarValidacao(new ColaboradorValidation(), Colaborador)) return;

            await _colaboradorRepository.Atualizar(Colaborador);
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
