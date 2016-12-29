using SearchTest.Search.NaiveSolution;
using SearchTypes;

namespace SearchTest.Search
{
    public interface ISearch
    {
        SearchResult Search(Post[] index, SearchCriteria criteria);
    }
}
