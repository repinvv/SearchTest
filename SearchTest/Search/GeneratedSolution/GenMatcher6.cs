namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher6 : IMatcher
    {
        public bool Match(ref Post post)
        {
            if(post.AnswerCount > 0) return false;
            if(post.BountyAmount == 0) return false;
            return true;
        }
    }
}
