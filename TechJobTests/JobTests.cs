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
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality"), new CoreCompetency("Persistence"));
            Assert.IsTrue(testJob3.Name == "Product tester");
            Assert.IsTrue(testJob3.EmployerName.Value == "ACME");
            Assert.IsTrue(testJob3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(testJob3.JobType.Value == "Quality");
            Assert.IsTrue(testJob3.JobCoreCompetency.Value == "Persistence");
        }
    }
}
