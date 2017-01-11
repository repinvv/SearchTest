namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher1 : IMatcher
    {
        public bool Match(ref Post post)
        {
            if(post.IsClosed) return false;
            return true;
        }
    }
}
