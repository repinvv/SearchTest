using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchTest.Search.GeneratedSolution;

namespace SearchTest.Tests
{
    [TestClass]
    public class GenSolutionTest : BaseTest
    {
        [TestInitialize]
        public void CreateTarget()
        {
            target = new SearchRoot();
        }

        [TestMethod]
        public void GenSolutionValidity() => ValidityTest();

        [TestMethod]
        public void GenSolutionPerformance() => PerformanceMeasurement();
    }
}
