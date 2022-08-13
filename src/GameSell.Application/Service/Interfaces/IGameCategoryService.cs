using GameSell.Application.Service.ResponseModel;
using GameSell.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Application.Service.Interfaces
{
    public interface IGameCategoryService
    {
        Task<DataResponse<List<GameCategory>>> GetAll();
        Task<DataResponse<GameCategory>> GetById(int id);
        Task<Response> Add(GameCategory gameCategory);
        Task<Response> Delete(GameCategory gameCategory);
        Task<Response> Update(GameCategory gameCategory);
    }
}
