﻿using SearchTest.Search.NaiveSolution;

namespace SearchTest.Search.GeneratedSolution
{
    public class SearchRoot : ISearch
    {
        public SearchResult Search(Post[] index, SearchCriteria criteria)
        {
            var matcher = Switch.GetMatcher(criteria);
            return new SearchLoop().Search(index, matcher);
        }
    }
}
