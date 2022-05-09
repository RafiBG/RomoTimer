using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomoTimerForm.View;
using System;

namespace RomoTimerUnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRandomGeneratorIfBetweenTheGivenNumbers()
        {
            int min = 1;
            int max = 15;
            int value = RandomNumberGenerator.RandomNum(min, max);
            Assert.IsTrue(value > min && value <= max);
        }
    }
}
