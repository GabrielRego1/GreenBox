using GreenBox.Business.Interfaces;
using GreenBox.Business.Models;
using GreenBox.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBox.Data.Repositories
{
    internal class ColaboradorRepository : Repository<Colaborador>, IColaboradorRepository
    {
        public ColaboradorRepository(GreenBoxDbContext db) : base(db)
        {
        }
    }
}
