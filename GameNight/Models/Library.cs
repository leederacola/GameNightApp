using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameNight.Models
{
    public class Library
    {
        public int ID { get; set; }
        public int GameID { get; set; }
        public int PersonID { get; set; }

        public virtual Game Game { get; set; }
        public virtual Person  Person { get; set; }
    
    }
}