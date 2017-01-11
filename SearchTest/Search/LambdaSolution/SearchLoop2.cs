using SearchTest.Search.NaiveSolution;

namespace SearchTest.Search.LambdaSolution
{
    public class SearchLoop2
    {
        public SearchResult Search(Post[] index, MatcherDelegate matcher)
        {
            int count = 0;
            Post[] results = new Post[50];

            for (int i = 0; i < index.Length; i++)
            {
                if (matcher(ref index[i]))
                {
                    count++;
                    if (count < results.Length)
                    {
                        results[count - 1] = index[i];
                    }
                }
            }

            return new SearchResult {Count = count, Posts = results};
        }
    }
}