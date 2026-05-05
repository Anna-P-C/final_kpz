using System;
using System.Collections.Generic;
using System.Linq;
using RecipeFinder.Models;

namespace RecipeFinder.Services
{
    public class NameSearchStrategy : ISearchStrategy
    {
        public IEnumerable<Recipe> Filter(IEnumerable<Recipe> source, string query)
        {
            if (source == null)
            {
                return Enumerable.Empty<Recipe>();
            }

            if (string.IsNullOrWhiteSpace(query))
            {
                return source;
            }

            return source.Where(recipe =>
                recipe.Title.Contains(query, StringComparison.OrdinalIgnoreCase));
        }
    }
}
