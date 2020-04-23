using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class MTGhandtest
    {
        [TestMethod]
        public void calculateHandProbability()
        {
            //arrange
            MTGcommanderStatsClass stats = new MTGcommanderStatsClass();

            //act
            decimal probability = stats.calculateprobibilityofacceptiblehand(35, 2, 10, 1);

            //asserting
            // Assert.AreEqual(decimal (425/236302088), probability);
            Assert.AreEqual(48, probability);
        }
    }
}
