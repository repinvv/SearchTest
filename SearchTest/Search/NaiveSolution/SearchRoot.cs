using SearchTypes;

namespace SearchTest.Search.NaiveSolution
{
    public class SearchRoot : ISearch
    {
        public SearchResult Search(Post[] index, SearchCriteria criteria)
        {
            var matcher = new Matcher(criteria);
            return new SearchLoop().Search(index, matcher);
        }
    }
}
