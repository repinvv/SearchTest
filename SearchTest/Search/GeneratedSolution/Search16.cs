namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public static class Search16
    {
        public static SearchResult Search(Post[] index)
        {
            int count = 0;
            Post[] results = new Post[50];

            for (int i = 0; i < index.Length; i++)
            {
                if(index[i].NewFlagValue2 != 5) continue;

                count++;
                if (count <= results.Length)
                {
                    results[count - 1] = index[i];
                }                
            }

            return new SearchResult {Count = count, Posts = results};
        }
    }
}