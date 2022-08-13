using GameSell.Application.Repository;
using GameSell.Application.Service.Interfaces;
using GameSell.Application.Service.ResponseModel;
using GameSell.Domain.Dtos;
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

        public async Task<Response> Add(GameAddDto gameAddDto)
        {
            Game game = GameAddDtoToGame(gameAddDto);
            await _gameRepository.Add(game);
            return new SuccessResponse("Game Added");
        }

        public async Task<Response> Delete(Game game)
        {
            await _gameRepository.Delete(game);
            return new SuccessResponse("Game Deleted");
        }

        public async Task<DataResponse<List<Game>>> GetAll()
        {
            return  new SuccessDataResponse<List<Game>>("Games Listed",await _gameRepository.GetAll());
        }

        public async Task<DataResponse<Game>> GetById(int id)
        {
            return new SuccessDataResponse<Game>("Game listed with id", await _gameRepository.Get(g => g.Id == id));
        }

        public async Task<DataResponse<List<Game>>> GetGamesWithDetails()
        {
            return new SuccessDataResponse<List<Game>>("Game listed with details",await _gameRepository.GetAllWithCategory());
        }

        public async Task<Response> Update(Game game)
        {
            await _gameRepository.Update(game);
            return new SuccessResponse("Game Updated");
        }



        private Game GameAddDtoToGame(GameAddDto gameAddDto)
        {
            Game game = new Game();
            game.Id = gameAddDto.Id;
            game.Name = gameAddDto.Name;
            game.Price = gameAddDto.Price;
            game.Description = gameAddDto.Description;
            game.CreationDate = DateTime.Now;
            game.GameCategoryId = gameAddDto.GameCategoryId;
            game.Company = gameAddDto.Company;
            return game;
        }


    }
}
