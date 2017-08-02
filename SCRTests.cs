using NUnit.Framework;

namespace Cascade.WinCal
{
    using System.Threading;
    using Cascade.WinCal.proxy;
    using Cascade.WinCal.proxy.pages;

    [TestFixture, Description("Testing File Menu options")]
    public class SCRTests
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

        [Test,Description("01882: WinCal copyright incorrect")]
        public void SCR_01882()
        {
            About aboutBox = SUT.getAboutBox();
            int activeForm = aboutBox.IsActive();
            Assert.AreEqual(1, activeForm);
            int result = aboutBox.IsCopyRightCurrent();
            aboutBox.Close();
            Assert.AreEqual(1, result);
        }

    }

}
