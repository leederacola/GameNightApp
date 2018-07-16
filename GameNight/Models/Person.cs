using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameNight.Models
{
    public class Person
    {
        public int ID { get; set; }   
        public string Name { get; set; }
        
        public virtual ICollection<Library> Libraries { get; set; }

    }
}