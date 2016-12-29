using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchTest.Search.NaiveSolution;

namespace SearchTest.Tests
{
    [TestClass]
    public class NaiveSolutionTest : BaseTest
    {
        [TestInitialize]
        public void CreateTarget()
        {
            target = new SearchRoot();
        }

        [TestMethod]
        public void NaiveSolutionValidity() => ValidityTest();

        [TestMethod]
        public void NaiveSolutionPerformance() => PerformanceMeasurement();
    }
}
