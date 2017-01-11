using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchTest.Search;
using SearchTest.Search.NaiveSolution;

namespace SearchTest.Tests
{
    public abstract class BaseTest
    {
        protected ISearch target;
        private Post[] validity;
        private Dictionary<SearchCriteria, int[]> validityAnswers;
        private Post[] performance;
        private SearchCriteria[] perfCriterias;

        [TestInitialize]
        public void CreatePosts()
        {
            validity = PostCreation.CreateValidityPosts();
            validityAnswers = PostCreation.CreateValidityAnswers();
            performance = PostCreation.CreatePerformancePosts();
            perfCriterias = PostCreation.CreatePerfCriterias();
        }

        public void ValidityTest()
        {
            foreach (var validityAnswer in validityAnswers)
            {
                var result = target.Search(validity, validityAnswer.Key);
                Assert.AreEqual(validityAnswer.Value.Length, result.Count);
                var foundIds = result.GetPosts().Select(x => x.Id).ToArray();
                CollectionAssert.AreEquivalent(validityAnswer.Value, foundIds);
            }
        }

        public void PerformanceMeasurement()
        {
            for (int i = 0; i < perfCriterias.Length; i++)
            {
                Measure(perfCriterias[i], i);
            }
        }

        private void Measure(SearchCriteria perfCriteria, int i)
        {
            SearchResult result = null;
            TimeSpan elapsed = TimeSpan.MaxValue;
            for (int j = 0; j < 3; j++)
            {
                var watch = Stopwatch.StartNew();
                result = target.Search(performance, perfCriteria);
                watch.Stop();
                PostCreation.Validate(perfCriteria, result);
                elapsed = elapsed > watch.Elapsed
                    ? watch.Elapsed
                    : elapsed;
            }

            Console.WriteLine($"found {result.Count}, criteria index {i}, elapsed {elapsed}");
        }
    }
}
