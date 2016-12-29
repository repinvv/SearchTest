using System;
using System.Collections.Generic;
using System.Linq;
using SearchTest.Search;
using SearchTest.Search.NaiveSolution;
using SearchTypes;

namespace SearchTest.Tests
{
    internal static class PostExtension
    {
        public static IEnumerable<Post> GetPosts(this SearchResult result)
        {
            return result.Posts.Take(Math.Min(result.Posts.Length, result.Count));
        }
    }
}
