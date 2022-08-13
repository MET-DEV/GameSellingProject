using GameSell.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Domain.Dtos
{
    public class GameAddDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }
        public string Company { get; set; }
        public int GameCategoryId { get; set; }
        
    }

}
