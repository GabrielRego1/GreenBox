using GreenBox.Business.Interfaces;
using GreenBox.Business.Models;
using GreenBox.Data.Contexts;
namespace GreenBox.Data.Repositories
{
    public class ColaboradorRepository : Repository<Colaborador>, IColaboradorRepository
    {
        public ColaboradorRepository(GreenBoxDbContext db) : base(db)
        {
        }
    }
}
