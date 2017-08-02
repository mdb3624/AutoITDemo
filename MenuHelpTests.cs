using NUnit.Framework;

namespace Cascade.WinCal
{
    using System.Threading;
    using Cascade.WinCal.proxy;
    using Cascade.WinCal.proxy.pages;

    [TestFixture]
    public class MenuHelpTests
    {

        private static WinCal SUT = new WinCal();

        [OneTimeSetUp]
        public void Initialize()
        {
            //SUT.Open();
        }

        [OneTimeTearDown]
        public void Shutdown()
        {
            SUT.Close();
        }

    }

}
