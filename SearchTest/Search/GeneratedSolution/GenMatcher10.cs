namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;

    public class GenMatcher10 : SearchCriteria, IMatcher
    {
        public GenMatcher10(SearchCriteria criteria)
        {
            NonClosedOnly = criteria.NonClosedOnly;
            NoAnswerOnly = criteria.NoAnswerOnly;
            BountiesOnly = criteria.BountiesOnly;
        }

        public bool Match(ref Post post)
        {
            if(post.AnswerCount > 0) return false;
            if(post.NewFlagValue1 != 4) return false;
            return true;
        }
    }
}
