using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchTest.Search.LambdaSolution;

namespace SearchTest.Tests
{
    [TestClass]
    public class LambdaSolutionTest : BaseTest
    {
        [TestInitialize]
        public void CreateTarget()
        {
            target = new SearchRoot();
        }

        [TestMethod]
        public void LambdaSolutionValidity() => ValidityTest();

        [TestMethod]
        public void LambdaSolutionPerformance() => PerformanceMeasurement();
    }
}
