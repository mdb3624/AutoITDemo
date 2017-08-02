using NUnit.Framework;

namespace Cascade.WinCal
{
    using Cascade.WinCal.proxy;
    using Cascade.WinCal.proxy.pages;

    [TestFixture]
    public class RegressionTests
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

        /*
                [Test, Description("Verify that Setup open file")]
                public void MainFormMenu_TPS1()
                {
                                FileOpen fileOpen = SUT.getFileOpen();
                                int result = fileOpen.IsActive();
                                fileOpen.Close();
                                Assert.AreEqual(1, result);
                }

                [Test, Description("Verify that bad setup file causes error dialog")]
                public void MainFormMenu_TPS2()
                {
                    FileOpen fileOpen = SUT.getFileOpen();
                    int result = fileOpen.loadBadSetupFile();
                    Assert.AreEqual(1, result);
                }

                [Test, Description("Verify that bad setup file causes error dialog")]
                public void MainFormMenu_TPS3()
                {
                    EventViewer eViewer = SUT.getEventViewer();
                    int result = eViewer.IsActive();
                    eViewer.Close();
                    Assert.AreEqual(1, result);

                    Assert.Fail("Not Implemented");
                }

                [Test, Description("Verify that bad setup file causes error dialog")]
                public void MainFormMenu_TPS4()
                {
                    Assert.Fail("Not Implemented");
                }
                [Test, Description("")]
                public void MainFormMenu_TPS5()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS6()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS7()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("Verify event viewer dialog starts up")]
                public void MainFormMenu_TPS8()
                {
                    EventViewer eViewer = SUT.getEventViewer();
                    int result = eViewer.IsActive();
                    eViewer.Close();
                    Assert.AreEqual(1, result);
                }

                [Test, Description("Verify event viewer dialog starts up")]
                public void MainFormMenu_TPS9()
                {
                    SystemInformationSummary test = SUT.getSystemInformationSummary();
                    int result = test.IsActive();
                    test.Close();
                    Assert.AreEqual(1, result);
                }

                [Test, Description("")]
                public void MainFormMenu_TPS10()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("Verify Calibration dialog starts up")]
                public void MainFormMenu_TPS11()
                {
                    Calibration test = SUT.getCalibration();
                    int result = test.IsActive();
                    test.Close();
                    Assert.AreEqual(1, result);
                }

                [Test, Description("")]
                public void MainFormMenu_TPS12()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS13()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS14()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS15()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS16()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS17()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS18()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS19()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS20()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS21()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS22()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS23()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS24()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS25()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS26()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS27()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS28()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS29()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS30()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS31()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS32()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS33()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS34()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS35()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS36()
                {
                    Assert.Fail("Not Implemented");
                }

                [Test, Description("")]
                public void MainFormMenu_TPS37()
                {
                    Assert.Fail("Not Implemented");
                }
        */

    }
}
