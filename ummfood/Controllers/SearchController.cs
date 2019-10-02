using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ummfood.Common.Interfaces;
using ummfood.Common.Models;
using System.Net.Http;

namespace ummfood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearch _search;
        public string baseUrl = "https://api.spoonacular.com/";

        public SearchController(ISearch search)
        {
            _search = search;
        }

        [HttpGet]
        [Route("/api/recipes/search")]
        public async Task<ActionResult<Search>> GetRecipe([FromQuery]string query)
        {
            try
            {
                var data = await _search.GetRecipe(query);
                return Ok(data);
            }
            catch(Exception e)
            {
                throw new Exception(e.ToString());
            }
            
        }
    }
}