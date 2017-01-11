namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher2 : IMatcher
    {
        public bool Match(ref Post post)
        {
            if(post.AnswerCount > 0) return false;
            return true;
        }
    }
}
