using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        Job testJob1 = new Job();
        Job testJob2 = new Job();

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(testJob1.Id < testJob2.Id && (testJob1.Id + 1) == testJob2.Id);
        }
    }
}
