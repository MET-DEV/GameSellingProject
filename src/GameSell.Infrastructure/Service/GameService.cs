using GameSell.Application.Repository;
using GameSell.Application.Service.Interfaces;
using GameSell.Application.Service.ResponseModel;
using GameSell.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Infrastructure.Service
{
    public class GameService : IGameService
    {
        public IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<Response> Add(Game game)
        {
            await _gameRepository.Add(game);
            return new SuccessResponse(true,"Game Added");
        }

        public async Task<Response> Delete(Game game)
        {
            await _gameRepository.Delete(game);
            return new SuccessResponse(true,"Game Deleted");
        }

        public async Task<Response> GetAll()
        {
            return new SuccessDataResponse<Task<List<Game>>>(true,"Games Listed",_gameRepository.GetAll());
        }

        public Task<Response> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> GetGamesWithDetails()
        {
            return  new SuccessDataResponse<Task<List<Game>>>(true, "Games Listed With Detail", _gameRepository.GetAllWithCategory());
        }

        public async Task<Response> Update(Game game)
        {
            await _gameRepository.Update(game);
            return new SuccessResponse(true,"Game Updated");
        }
    }
}
