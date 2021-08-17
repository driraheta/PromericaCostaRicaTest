using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Pattern
    {
        public int Id { get; set; }
        public int Make_id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Doors { get; set; }
    }
}
