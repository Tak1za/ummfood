using System;
using System.Collections.Generic;
using System.Text;

namespace ummfood.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int ReadyTime { get; set; }
        public int Servings { get; set; }
        public string Title { get; set; }
    }
}
