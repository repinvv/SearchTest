namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher13 : SearchCriteria, IMatcher
    {
        public GenMatcher13(SearchCriteria criteria)
        {
            NonClosedOnly = criteria.NonClosedOnly;
            NoAnswerOnly = criteria.NoAnswerOnly;
            BountiesOnly = criteria.BountiesOnly;
        }

        public bool Match(ref Post post)
        {
            if(post.IsClosed) return false;
            if(post.BountyAmount == 0) return false;
            if(post.NewFlagValue1 != 4) return false;
            return true;
        }
    }
}