using System.Collections.Generic;
using System.Linq;
using SearchTest.Search.NaiveSolution;

namespace SearchTest.Search.LambdaSolution
{
    public class SearchRoot : ISearch
    {
        public SearchResult Search(Post[] index, SearchCriteria criteria)
        {
            var matcher = CreateMatcher(criteria);
            return new SearchLoop2().Search(index, matcher);
        }

        private static MatcherDelegate CreateMatcher(SearchCriteria criteria)
        {
            var matchers = GetMatchers(criteria).ToList();

            if (matchers.Count == 0)
            {
                return Matchers.AnyPostMatcher;
            }
            
            if (matchers.Count == 1)
            {
                return matchers[0];
            }
            
            if (matchers.Count == 5)
            {
                return Matchers.Compose5(matchers);
            }
            
            return Matchers.Compose(matchers);
        }

        private static IEnumerable<MatcherDelegate> GetMatchers(SearchCriteria criteria)
        {
            if (criteria.NonClosedOnly)
            {
                yield return Matchers.OpenPostsMatcher;
            }

            if (criteria.NoAnswerOnly)
            {
                yield return Matchers.UnasweredMatcher;
            }

            if (criteria.BountiesOnly)
            {
                yield return Matchers.PostsWithBountiesMatcher;
            }

            if (criteria.NewFlag1)
            {
                yield return Matchers.NewFlag1Matcher;
            }

            if (criteria.NewFlag2)
            {
                yield return Matchers.NewFlag2Matcher;
            }
        }
    }
}
