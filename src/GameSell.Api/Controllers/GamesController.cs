using GameSell.Application.Repository;
using GameSell.Application.Service.Interfaces;
using GameSell.Application.Service.ResponseModel;
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
        public async Task<Response> GetGames()
        {
            return await _gameService.GetGamesWithDetails();
        }
        [HttpPost("/game")]
        public async Task<Response> AddGame(Game game)
        {
            return await _gameService.Add(game);
        }
        [HttpPost("/gamecategory")]
        public async Task<int> AddGameCategory(GameCategory gameCategory) 
        { 
            
            return await gameCategoryRepository.Add(gameCategory); 
        }
    }
}
