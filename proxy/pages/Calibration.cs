using System;

namespace Cascade.WinCal.proxy.pages
{
    class Calibration : BaseAutoIT
    {
        public static string APPLICATION_TITLE = "Calibration";
        private MenuLocation calibrationMenuLocation = new MenuLocation(185, 36);
        private MenuLocation menuOption = new MenuLocation(182, 61);
        private MenuLocation closeBtn = new MenuLocation(12, 7);

        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Calibration()
        {
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = Calibration.APPLICATION_TITLE;
            this.Open();
        }

        private new void Open()
        {
            if ( log.IsDebugEnabled )
            {
                log.Debug("Opening Calibration");
            }
            base._WinWaitActivate(WinCal.APPLICATION_TITLE);
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + calibrationMenuLocation.positionX, WinCal.WINCAL_LOCATION.positionY + calibrationMenuLocation.positionY, 1); 
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + menuOption.positionX, WinCal.WINCAL_LOCATION.positionY + menuOption.positionY, 1); 

            base.Open();

            if ( log.IsDebugEnabled )
            {
                log.DebugFormat("WinCal X={0}, WinCal Y={1}", WinCal.WINCAL_LOCATION.positionX, WinCal.WINCAL_LOCATION.positionY);
                log.DebugFormat("Calibration X={0}, About Y={1}", base.windowLocation.positionX + closeBtn.positionX, base.windowLocation.positionY + closeBtn.positionY);
            }

        }

        public new void Close()
        {
            base.Close();
    //        autoIT.MouseClick("left", base.windowLocation.positionX + closeBtn.positionX, base.windowLocation.positionY + closeBtn.positionY, 1); // Help
        }

        public new int IsActive()
        {
            return base.IsActive();
        }
    }
}
