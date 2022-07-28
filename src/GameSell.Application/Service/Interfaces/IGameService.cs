using GameSell.Application.Service.ResponseModel;
using GameSell.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Application.Service.Interfaces
{
    public interface IGameService
    {
        Task<Response> GetGamesWithDetails();
        Task<Response> GetAll();
        Task<Response> GetById(int id);
        Task<Response> Add(Game game);
        Task<Response> Update(Game game);
        Task<Response> Delete(Game game);
    }
}
