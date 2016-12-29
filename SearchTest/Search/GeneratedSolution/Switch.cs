namespace SearchTest.Search.GeneratedSolution
{
    using Search.NaiveSolution;
    using System;
    using SearchTypes;

    public static class Switch
    {
        public static IMatcher GetMatcher(SearchCriteria criteria)
        {
            int matcherId = 0;
            if(criteria.NonClosedOnly)
            {
                matcherId += 1;
            }

            if(criteria.NoAnswerOnly)
            {
                matcherId += 2;
            }

            if(criteria.BountiesOnly)
            {
                matcherId += 4;
            }

            switch(matcherId)
            {
                case 7:
                    return new GenMatcher7(criteria);
                case 6:
                    return new GenMatcher6(criteria);
                case 5:
                    return new GenMatcher5(criteria);
                case 4:
                    return new GenMatcher4(criteria);
                case 3:
                    return new GenMatcher3(criteria);
                case 2:
                    return new GenMatcher2(criteria);
                case 1:
                    return new GenMatcher1(criteria);
                case 0:
                    return new GenMatcher0(criteria);
                default: 
                    throw new Exception("should never happen");
            }
        }
    }
}
