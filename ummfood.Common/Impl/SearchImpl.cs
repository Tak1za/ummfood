using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using ummfood.Common.Interfaces;
using ummfood.Common.Models;

namespace ummfood.Common.Impl
{
    public class SearchImpl : ISearch
    {
        private readonly IConfiguration _configuration;
        private string _apiKey;
        public SearchImpl(IConfiguration configuration)
        {
            _configuration = configuration;
            FillSettings();
        }

        void FillSettings() {
            _apiKey = _configuration["Food:ApiKey"];
        }
        
        public async Task<Search> GetRecipe(string query)
        {
            string requestUrl = string.Format("https://api.spoonacular.com/recipes/search?apiKey={0}&query={1}", _apiKey, query);
            using (var client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(requestUrl))
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<Search>(content);
                    return data;
                }
            }
        }
    }
}
