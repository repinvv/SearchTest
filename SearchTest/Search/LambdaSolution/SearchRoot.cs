using SearchTest.Search.NaiveSolution;
using SearchTypes;

namespace SearchTest.Search.LambdaSolution
{
    public class SearchRoot : ISearch
    {
        public SearchResult Search(Post[] index, SearchCriteria criteria)
        {
            var matcher = new LambdaMatcher(criteria);
            return new SearchLoop().Search(index, matcher);
        }
    }
}
