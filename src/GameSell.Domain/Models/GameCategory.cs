using GameSell.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Domain.Models
{
    public class GameCategory:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public List<Game>? Games { get; set; }
    }
}
