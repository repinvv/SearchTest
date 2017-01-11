namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher4 : IMatcher
    {
        public bool Match(ref Post post)
        {
            if(post.BountyAmount == 0) return false;
            return true;
        }
    }
}
