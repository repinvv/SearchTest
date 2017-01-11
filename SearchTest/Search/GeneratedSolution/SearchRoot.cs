using SearchTest.Search.NaiveSolution;

namespace SearchTest.Search.GeneratedSolution
{
    public class SearchRoot : ISearch
    {
        public SearchResult Search(Post[] index, SearchCriteria criteria)
        {
            return Switch.Search(index, criteria);
        }
    }
}
