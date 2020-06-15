using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Product;
using Business;

namespace OrderProcessingSystem_TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        // There is a Business Rule that Agent Commission Can not be more that 10 $
        public void AgentCommisionTestMethod()
        {
            AgentCommisionSlip AgentCommisionSlip = new AgentCommisionSlip();
            bool Response = AgentCommisionSlip.AgentCommission(1, 9);
            Assert.AreEqual(true, true);

            Response = AgentCommisionSlip.AgentCommission(1, 15);
            Assert.AreEqual(false, false);
        }

        public void PromotionalVideoTestMethod()
        {
            Video Video = new Video();
            bool Response = Video.PromotinalVideo(1, "Learning To Ski");
            Assert.AreEqual(true, true);

            Response = Video.PromotinalVideo(1, "Learning To Ski123");
            Assert.AreEqual(false, false);
        }

    }
}
