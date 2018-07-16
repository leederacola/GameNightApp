using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameNight.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int MinPlayer { get; set; }
        public int MaxPlayer { get; set; } 
        public int ReleaseYear { get; set; }
    }
}