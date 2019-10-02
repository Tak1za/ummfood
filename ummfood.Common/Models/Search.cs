using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ummfood.Common.Models
{
    public class Search
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public IEnumerable<Recipe> Recipes {get ;set;}
    }
}
