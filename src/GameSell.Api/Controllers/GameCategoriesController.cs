using GameSell.Application.Service.Interfaces;
using GameSell.Application.Service.ResponseModel;
using GameSell.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameSell.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameCategoriesController : ControllerBase
    {
        private IGameCategoryService _gameCategoryService;

        public GameCategoriesController(IGameCategoryService gameCategoryService)
        {
            _gameCategoryService = gameCategoryService;
        }

        [HttpGet]
        public async Task<DataResponse<List<GameCategory>>> GetCategories()
        {
            return await _gameCategoryService.GetAll();
        }
        [HttpGet("getById")]
        public async Task<DataResponse<GameCategory>> GetById(int id)
        {
            return await _gameCategoryService.GetById(id);
        }
        [HttpPost]
        public async Task<Response> AddGameCategory(GameCategory gameCategory)
        {
            return await _gameCategoryService.Add(gameCategory);
        }
        [HttpPatch]
        public async  Task<Response> UpdateGameCategory(GameCategory gameCategory)
        {
            return await _gameCategoryService.Update(gameCategory);
        }
        [HttpDelete]
        public async Task<Response> DeleteGameCategory(GameCategory gameCategory)
        {
            return await _gameCategoryService.Delete(gameCategory);
        }
    }
}
