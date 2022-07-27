using GameSell.Application.Repository;
using GameSell.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Infrastructure.Repository
{
    public class GameCategoryRepository:RepositoryBase<GameCategory,RepositoryContext>,IGameCategoryRepository
    {

    }
}
