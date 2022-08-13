using GameSell.Application.Repository;
using GameSell.Application.Service.Interfaces;
using GameSell.Application.Service.ResponseModel;
using GameSell.Domain.Dtos;
using GameSell.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameSell.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private IGameService _gameService;
        private IGameCategoryRepository gameCategoryRepository;



        public GamesController( IGameCategoryRepository gameCategoryRepository, IGameService gameService)
        {
 
            this.gameCategoryRepository = gameCategoryRepository;
            _gameService = gameService;
        }
        [HttpGet]
        public async Task<DataResponse<List<Game>>> GetGames()
        {
            return await _gameService.GetGamesWithDetails();
        }
        [HttpGet("/getById")]
        public async  Task<DataResponse<Game>> GetById(int id)
        {
            return await _gameService.GetById(id);
        }
        [HttpPost]
        public async Task<Response> AddGame(GameAddDto gameAddDto)
        {
            return await _gameService.Add(gameAddDto);
        }
        [HttpDelete]
        public async Task<Response> DeleteGame(Game game)
        {
            return await _gameService.Delete(game);
        }
        [HttpPatch]
        public async Task<Response> UpdateGame(Game game)
        {
            return await _gameService.Update(game);
        }
       
    }
}
