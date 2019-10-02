using System;
using System.Collections.Generic;

namespace ummfood.Models
{
    public class Search
    {
        public int Number { get; set; }
        public IEnumerable<Recipe> Recipes {get ;set;}

        public int TotalResults { get; set; }
    }
}
