using GreenBox.Business.Models;
namespace GreenBox.Business.Interfaces
{
    public interface IColaboradorRepository : IRepository<Colaborador>
    {
        public Task<IEnumerable<Colaborador>> ObterRanking();
    }
}
