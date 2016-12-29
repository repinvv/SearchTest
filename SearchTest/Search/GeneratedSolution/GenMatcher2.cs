namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;
    using SearchTypes;

    public class GenMatcher2 : SearchCriteria, IMatcher
    {
        public GenMatcher2(SearchCriteria criteria)
        {
            NonClosedOnly = criteria.NonClosedOnly;
            NoAnswerOnly = criteria.NoAnswerOnly;
            BountiesOnly = criteria.BountiesOnly;
        }

        public bool Match(ref Post post)
        {
            if(post.AnswerCount > 0) return false;
            return true;
        }
    }
}
