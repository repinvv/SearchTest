namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher23 : SearchCriteria, IMatcher
    {
        public GenMatcher23(SearchCriteria criteria)
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
            if(post.NewFlagValue2 != 5) return false;
            return true;
        }
    }
}
