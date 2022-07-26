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

        public GamesController(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }
        [HttpGet]
        public async Task<List<Game>> GetGames()
        {
            return await gameRepository.GetAll();
        }
    }
}
