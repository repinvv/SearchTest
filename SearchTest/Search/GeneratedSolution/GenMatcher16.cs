namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher16 : IMatcher
    {
        public bool Match(ref Post post)
        {
            if(post.NewFlagValue2 != 5) return false;
            return true;
        }
    }
}
