namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;
    using SearchTypes;

    public class GenMatcher7 : SearchCriteria, IMatcher
    {
        public GenMatcher7(SearchCriteria criteria)
        {
            NonClosedOnly = criteria.NonClosedOnly;
            NoAnswerOnly = criteria.NoAnswerOnly;
            BountiesOnly = criteria.BountiesOnly;
        }

        public bool Match(ref Post post)
        {
            if(post.IsClosed) return false;
            if(post.AnswerCount > 0) return false;
            if(post.BountyAmount == 0) return false;
            return true;
        }
    }
}
