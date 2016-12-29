using SearchTest.Search.NaiveSolution;

namespace SearchTest.Search.LambdaSolution
{
    public class LambdaMatcher : SearchCriteria, IMatcher
    {
        public LambdaMatcher(SearchCriteria criteria)
        {
            NonClosedOnly = criteria.NonClosedOnly;
            NoAnswerOnly = criteria.NoAnswerOnly;
            BountiesOnly = criteria.BountiesOnly;
        }

        public bool Match(ref Post post)
        {
            if (NonClosedOnly && post.IsClosed) return false;
            if (NoAnswerOnly && post.AnswerCount > 0) return false;
            if (BountiesOnly && post.BountyAmount == 0) return false;

            return true;
        }
    }
}
