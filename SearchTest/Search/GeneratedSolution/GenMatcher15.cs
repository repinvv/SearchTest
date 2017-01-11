namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher15 : IMatcher
    {
        public bool Match(ref Post post)
        {
            if(post.IsClosed) return false;
            if(post.AnswerCount > 0) return false;
            if(post.BountyAmount == 0) return false;
            if(post.NewFlagValue1 != 4) return false;
            return true;
        }
    }
}
