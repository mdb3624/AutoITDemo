using NUnit.Framework;

namespace Cascade.WinCal
{
    using Cascade.WinCal.proxy;
    using Cascade.WinCal.proxy.pages;

    [TestFixture]
    public class MenuWizardsTests
    {

        private static WinCal SUT = new WinCal();

        public void Initialize()
        {
            SUT.Open();
        }

        [OneTimeTearDown]
        public void Shutdown()
        {
            SUT.Close();
        }
    }
}
