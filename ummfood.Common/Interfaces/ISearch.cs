using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ummfood.Common.Models;

namespace ummfood.Common.Interfaces
{
    public interface ISearch
    {
        public Task<Search> GetRecipe(string query);
    }
}
