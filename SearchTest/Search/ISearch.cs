using SearchTest.Search.NaiveSolution;

namespace SearchTest.Search
{
    public interface ISearch
    {
        SearchResult Search(Post[] index, SearchCriteria criteria);
    }
}
