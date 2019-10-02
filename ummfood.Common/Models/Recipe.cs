using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ummfood.Common.Models
{
    public class Recipe
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("readyInMinutes")]
        public int ReadyTime { get; set; }

        [JsonProperty("servings")]
        public int Servings { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
