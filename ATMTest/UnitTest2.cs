using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleATM;

namespace ATMTest
{
    [TestClass]
    public class UnitTest2
    {
        BackEndSimulator sim = new BackEndSimulator();

        //positive test result
        [TestMethod]

        public void TestMethodBackendSimulatorPositive()
        {
            //existing Account number
            var a = sim.QueryAccount("1234");
            
            Assert.AreEqual((a == null)? false: true, true);

        }

        //negative test result
        [TestMethod]
        public void TestMethodBackendSimulatorNegative()
        {
            //non-existing Account number
            var a = sim.QueryAccount("3456");

            Assert.AreEqual((a == null) ? false : true, true);
        }

    }
}
