namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher25 : SearchCriteria, IMatcher
    {
        public GenMatcher25(SearchCriteria criteria)
        {
            NonClosedOnly = criteria.NonClosedOnly;
            NoAnswerOnly = criteria.NoAnswerOnly;
            BountiesOnly = criteria.BountiesOnly;
        }

        public bool Match(ref Post post)
        {
            if(post.IsClosed) return false;
            if(post.NewFlagValue1 != 4) return false;
            if(post.NewFlagValue2 != 5) return false;
            return true;
        }
    }
}
