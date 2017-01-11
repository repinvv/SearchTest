namespace SearchTest.Search.NaiveSolution
{
    public class SearchLoop
    {
        public SearchResult Search(Post[] index, IMatcher matcher)
        {
            int count = 0;
            Post[] results = new Post[50];

            for (int i = 0; i < index.Length; i++)
            {
                if (matcher.Match(ref index[i]))
                {
                    count++;
                    if (count <= results.Length)
                    {
                        results[count - 1] = index[i];
                    }
                }
            }

            return new SearchResult {Count = count, Posts = results};
        }
    }
}
