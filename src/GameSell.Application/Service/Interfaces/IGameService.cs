using GameSell.Application.Service.ResponseModel;
using GameSell.Domain.Dtos;
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
        Task<DataResponse<List<Game>>> GetGamesWithDetails();
        Task<DataResponse<List<Game>>> GetAll();
        Task<DataResponse<Game>> GetById(int id);
        Task<Response> Add(GameAddDto gameAddDto);
        Task<Response> Update(Game game);
        Task<Response> Delete(Game game);
    }
}
