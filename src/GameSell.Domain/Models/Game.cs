﻿using GameSell.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GameSell.Domain.Models
{
    public class Game:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }
        public string Company { get; set; }
        public int GameCategoryId { get; set; }
        public GameCategory? GameCategory { get; set; }



    }
}
