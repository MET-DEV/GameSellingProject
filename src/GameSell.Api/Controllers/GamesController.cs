using GameSell.Application.Repository;
using GameSell.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameSell.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private IGameRepository gameRepository;
        private IGameCategoryRepository gameCategoryRepository;



        public GamesController(IGameRepository gameRepository, IGameCategoryRepository gameCategoryRepository)
        {
            this.gameRepository = gameRepository;
            this.gameCategoryRepository = gameCategoryRepository;
        }
        [HttpGet]
        public async Task<List<Game>> GetGames()
        {
            return await gameRepository.GetAllWithCategory();
        }
        [HttpPost("/game")]
        public async Task<int> AddGame(Game game)
        {
            return await gameRepository.Add(game);
        }
        [HttpPost("/gamecategory")]
        public async Task<int> AddGameCategory(GameCategory gameCategory) 
        { 
            
            return await gameCategoryRepository.Add(gameCategory); 
        }
    }
}
