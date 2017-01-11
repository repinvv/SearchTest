using System.Collections.Generic;
using System.Linq;
using SearchTest.Search.NaiveSolution;

namespace SearchTest.Search.LambdaSolution
{
    public static class Matchers
    {
        public static bool OpenPostsMatcher(ref Post post)
        {
            return !post.IsClosed;
        }

        public static bool UnasweredMatcher(ref Post post)
        {
            return post.AnswerCount == 0;
        }

        public static bool PostsWithBountiesMatcher(ref Post post)
        {
            return post.BountyAmount > 0;
        }

        public static bool NewFlag1Matcher(ref Post post)
        {
            return post.NewFlagValue1 == 4;
        }

        public static bool NewFlag2Matcher(ref Post post)
        {
            return post.NewFlagValue2 == 5;
        }

        public static bool AnyPostMatcher(ref Post post)
        {
            return true;
        }

        public static MatcherDelegate Compose(IEnumerable<MatcherDelegate> matchers)
        {
            var _matchers = matchers.ToArray();
            var length = _matchers.Length;

            return (ref Post post) =>
            {
                for (var i = 0; i < length; i++)
                {
                    if (!_matchers[i](ref post))
                    {
                        return false;
                    }
                }

                return true;
            };
        }

        public static MatcherDelegate Compose2(IReadOnlyList<MatcherDelegate> matchers)
        {
            var m0 = matchers[0];
            var m1 = matchers[1];

            return (ref Post post) => m0(ref post) && m1(ref post);
        }

        public static MatcherDelegate Compose3(IReadOnlyList<MatcherDelegate> matchers)
        {
            var m0 = matchers[0];
            var m1 = matchers[1];
            var m2 = matchers[2];

            return (ref Post post) => m0(ref post) && m1(ref post) && m2(ref post);
        }

        public static MatcherDelegate Compose5(IReadOnlyList<MatcherDelegate> matchers)
        {
            var m0 = matchers[0];
            var m1 = matchers[1];
            var m2 = matchers[2];
            var m3 = matchers[3];
            var m4 = matchers[4];

            return Compose5(m0, m1, m2, m3, m4);
        }

        public static MatcherDelegate Compose5(MatcherDelegate m1, MatcherDelegate m2, MatcherDelegate m3, MatcherDelegate m4, MatcherDelegate m5)
        {
            return (ref Post post) => m1(ref post) && m2(ref post) && m3(ref post) && m4(ref post) && m5(ref post);
        }
    }
}
