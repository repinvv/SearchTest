namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher26 : IMatcher
    {
        public bool Match(ref Post post)
        {
            if(post.AnswerCount > 0) return false;
            if(post.NewFlagValue1 != 4) return false;
            if(post.NewFlagValue2 != 5) return false;
            return true;
        }
    }
}
