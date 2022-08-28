using GreenBox.Business.Models;

namespace GreenBox.Business.Interfaces
{
    public interface IColaboradorService : IDisposable
    {
        Task Adicionar(Colaborador colaborador);
        Task Atualizar(Colaborador colaborador);
        Task Remover(Guid id);
    }
}