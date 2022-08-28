using GreenBox.Business.Interfaces;
using GreenBox.Business.Models;
using GreenBox.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GreenBox.Data.Repositories
{
    public class ColaboradorRepository : Repository<Colaborador>, IColaboradorRepository
    {
        public ColaboradorRepository(GreenBoxDbContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Colaborador>> ObterRanking()
        {
            return await Db.Colaboradores
                .Where(c => c.Ativo)
                .OrderByDescending(c => c.Pontuacao)
                .ToListAsync();
        }
    }
}
