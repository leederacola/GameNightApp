using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GameNight.Models;

namespace GameNight.DAL
{
    public class GameNightInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GameNightContext>
    {
        protected override void Seed(GameNightContext context)
        {
            var games = new List<Game>
            {
                new Game{Title = "Blood Rage 2", MaxPlayer = 5 , MinPlayer = 2 },
                new Game{Title = "Lost Cities", MaxPlayer = 2 , MinPlayer = 2 },
                new Game{Title = "Cosmic Encounter", MaxPlayer = 5 , MinPlayer = 2 },
                new Game{Title = "Patch Work", MaxPlayer = 2 , MinPlayer = 2 },
                new Game{Title = "Inis", MaxPlayer = 4 , MinPlayer = 2 },
                new Game{Title = "Azul", MaxPlayer = 2 , MinPlayer = 4 },
                new Game{Title = "Ladies and Gentlemen", MaxPlayer = 4 , MinPlayer = 10 },
                new Game{Title = "The Resistance", MaxPlayer = 3 , MinPlayer = 8 }
            };

            games.ForEach(g => context.Games.Add(g));
            context.SaveChanges();

            var people = new List<Person>
            {
                new Person { Name = "Chad" },
                new Person { Name =  "Clettus" },
                new Person { Name = "Tonya" },
                new Person { Name = "Wanda" }
            };

            people.ForEach(p => context.People.Add(p));
            context.SaveChanges();

            var libraries = new List<Library>
            {
                new Library{ PersonID = 1, GameID = 1 },
                new Library{ PersonID = 1, GameID = 2 },
                new Library{ PersonID = 1, GameID = 3 },
                new Library{ PersonID = 1, GameID = 4 },
                new Library{ PersonID = 2, GameID = 5 },
                new Library{ PersonID = 2, GameID = 6 },
                new Library{ PersonID = 3, GameID = 7 },
                new Library{ PersonID = 3, GameID = 8 },
                new Library{ PersonID = 3, GameID = 2 },
                new Library{ PersonID = 4, GameID = 6 }
            };

            libraries.ForEach(l => context.Libraries.Add(l));
            context.SaveChanges();

            

        }
    }
}