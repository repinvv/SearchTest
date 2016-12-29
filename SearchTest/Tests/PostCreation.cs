using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchTest.Search;
using SearchTest.Search.NaiveSolution;

namespace SearchTest.Tests
{
    public class PostCreation
    {
        const int staticPostsAmount = 30000000;
        const int positiveThreshold = 100;
        const int randomRange = 10000;
        private static Post[] perfPosts;
        private static Dictionary<SearchCriteria, int[]> results = new Dictionary<SearchCriteria, int[]>();

        public static Post[] CreateValidityPosts()
        {
            return new[]
            {
                new Post {Id = 0, IsClosed = true, AnswerCount = 1, BountyAmount = 0},
                new Post {Id = 1, IsClosed = false, AnswerCount = 1, BountyAmount = 0},
                new Post {Id = 2, IsClosed = true, AnswerCount = 0, BountyAmount = 0},
                new Post {Id = 3, IsClosed = true, AnswerCount = 1, BountyAmount = 1},
                new Post {Id = 4, IsClosed = false, AnswerCount = 0, BountyAmount = 0},
                new Post {Id = 5, IsClosed = true, AnswerCount = 0, BountyAmount = 1},
                new Post {Id = 6, IsClosed = false, AnswerCount = 1, BountyAmount = 1},
                new Post {Id = 7, IsClosed = false, AnswerCount = 0, BountyAmount = 1},
            };
        }

        public static Dictionary<SearchCriteria, int[]> CreateValidityAnswers()
        {
            return new Dictionary<SearchCriteria, int[]>
            {
                {new SearchCriteria(), new[] {0, 1, 2, 3, 4, 5, 6, 7}},

                {new SearchCriteria {NonClosedOnly = true}, new[] {1, 4, 6, 7}},
                {new SearchCriteria {NoAnswerOnly = true}, new[] {2, 4, 5, 7}},
                {new SearchCriteria {BountiesOnly = true}, new[] {3, 5, 6, 7}},

                {new SearchCriteria {NonClosedOnly = true, NoAnswerOnly = true}, new[] {4, 7}},
                {new SearchCriteria {NoAnswerOnly = true, BountiesOnly = true}, new[] {5, 7}},
                {new SearchCriteria {NonClosedOnly = true, BountiesOnly = true}, new[] {6, 7}},

                {
                    new SearchCriteria {NonClosedOnly = true, NoAnswerOnly = true, BountiesOnly = true},
                    new[] {7}
                },
            };
        }

        public static Post[] CreatePerformancePosts()
        {
            if (perfPosts != null)
            {
                return perfPosts;
            }

            perfPosts = new Post[staticPostsAmount];
            var random = new Random();
            for (int i = 0; i < perfPosts.Length; i++)
            {
                perfPosts[i] = new Post
                {
                    Id = i,
                    AnswerCount = CreateAnswerCount(IsPositive(random)),
                    BountyAmount = CreateBounty(IsPositive(random)),
                    IsClosed = CreateClosed(IsPositive(random))
                };
            }
            return perfPosts;
        }

        private static bool CreateClosed(bool isPositive)
        {
            return !isPositive;
        }

        private static int CreateBounty(bool isPositive)
        {
            return isPositive ? 1 : 0;
        }

        private static int CreateAnswerCount(bool isPositive)
        {
            return isPositive ? 0 : 1;
        }

        private static bool IsPositive(Random random)
        {
            return random.Next(randomRange) < positiveThreshold;
        }

        public static SearchCriteria[] CreatePerfCriterias()
        {
            return new[]
            {
                new SearchCriteria {BountiesOnly = true},
                new SearchCriteria {NoAnswerOnly = true},
                new SearchCriteria {NonClosedOnly = true},
                new SearchCriteria {NonClosedOnly = true, NoAnswerOnly = true, BountiesOnly = true},
            };
        }

        public static void Validate(SearchCriteria perfCriteria, SearchResult result)
        {
            var ids = result.GetPosts().Select(x => x.Id).ToArray();
            if (!results.ContainsKey(perfCriteria))
            {
                results[perfCriteria] = ids;
                return;
            }

            CollectionAssert.AreEquivalent(results[perfCriteria], ids);
        }
    }
}
