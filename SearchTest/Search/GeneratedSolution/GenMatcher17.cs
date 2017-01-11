namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher17 : IMatcher
    {
        public bool Match(ref Post post)
        {
            if(post.IsClosed) return false;
            if(post.NewFlagValue2 != 5) return false;
            return true;
        }
    }
}
