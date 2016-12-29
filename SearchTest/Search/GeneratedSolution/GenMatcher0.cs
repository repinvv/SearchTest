namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;
    using SearchTypes;

    public class GenMatcher0 : SearchCriteria, IMatcher
    {
        public GenMatcher0(SearchCriteria criteria)
        {
            NonClosedOnly = criteria.NonClosedOnly;
            NoAnswerOnly = criteria.NoAnswerOnly;
            BountiesOnly = criteria.BountiesOnly;
        }

        public bool Match(ref Post post)
        {
            return true;
        }
    }
}
