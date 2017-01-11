namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher8 : IMatcher
    {
        public bool Match(ref Post post)
        {
            if(post.NewFlagValue1 != 4) return false;
            return true;
        }
    }
}
