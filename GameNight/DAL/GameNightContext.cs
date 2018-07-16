using GameNight.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GameNight.DAL
{
    public class GameNightContext : DbContext
    {
        // specificing connection string as ---GameNightContext---
        public GameNightContext() : base("GameNightContext")
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Library> Libraries { get; set; }
        

        // prevents table names Games -- makes sures Game is tabvle name not Games
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}