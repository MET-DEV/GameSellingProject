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
    public class GameCategoryService:IGameCategoryService
    {
        public IGameCategoryRepository _gameCategoryRepository;

        public GameCategoryService(IGameCategoryRepository gameCategoryRepository)
        {
            _gameCategoryRepository = gameCategoryRepository;
        }

        public async Task<Response> Add(GameCategory gameCategory)
        {
            await _gameCategoryRepository.Add(gameCategory);
            return new SuccessResponse("Game Added");
        }

        public async Task<Response> Delete(GameCategory gameCategory)
        {
            await _gameCategoryRepository.Delete(gameCategory);
            return new SuccessResponse("Game Deleted");
        }

        public async Task<DataResponse<List<GameCategory>>> GetAll()
        {
            return new SuccessDataResponse<List<GameCategory>>("Games Listed", await _gameCategoryRepository.GetAll());
        }

        public async Task<DataResponse<GameCategory>> GetById(int id)
        {
            return new SuccessDataResponse<GameCategory>("Game listed with id", await _gameCategoryRepository.Get(g => g.Id == id));
        }

      

        public async Task<Response> Update(GameCategory gameCategory)
        {
            await _gameCategoryRepository.Update(gameCategory);
            return new SuccessResponse("Game Updated");
        }
    }
}
