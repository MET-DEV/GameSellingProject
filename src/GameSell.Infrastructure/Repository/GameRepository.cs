using GameSell.Application.Repository;
using GameSell.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Infrastructure.Repository
{
    public class GameRepository:RepositoryBase<Game,RepositoryContext>,IGameRepository
    {
        public async Task<List<Game>> GetAllWithCategory()
        {
            using (RepositoryContext context = new RepositoryContext())
            {
                return await context.Set<Game>().Include("GameCategory").ToListAsync();
            }
        }
    }
}
