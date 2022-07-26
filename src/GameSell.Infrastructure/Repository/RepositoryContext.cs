using GameSell.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSell.Infrastructure.Repository
{
    public class RepositoryContext : DbContext
    {

        protected override  void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GameShopDB;Trusted_Connection=true");

        }
        public DbSet<Game> Games{ get; set; }
    }
}
