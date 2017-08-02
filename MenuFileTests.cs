using NUnit.Framework;

namespace Cascade.WinCal
{
    using System.Threading;
    using Cascade.WinCal.proxy;
    using Cascade.WinCal.proxy.pages;

    [TestFixture, Description("Testing File Menu options")]
    public class MenuFileTests
    {

        private static WinCal SUT = new WinCal();

        [OneTimeSetUp]
        public void Initialize()
        {
            SUT.Open();
        }

        [OneTimeTearDown]
        public void Shutdown()
        {
            SUT.Close();
        }

        [Test, Description("Verify that bad setup file causes error dialog")]
        public void SaveInvalidSetupFile()
        {
            FileOpen test = SUT.getFileOpen();
            int result = test.IsActive();
            Assert.AreEqual(1, result); // Make sure that File Open Dialog open
            result = test.loadBadSetupFile(); // Attempt to save invalid System Setup file
            Assert.AreEqual(1, result);
        }

    }

}
