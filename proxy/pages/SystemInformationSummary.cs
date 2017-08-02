using System;

namespace Cascade.WinCal.proxy.pages
{
    class SystemInformationSummary : BaseAutoIT
    {
        public static string APPLICATION_TITLE = "System Information Summary";
        private MenuLocation eventViewerMenuLocation = new MenuLocation(121, 41);
        private MenuLocation systemInformationSummaryOption = new MenuLocation(147, 84);
        private MenuLocation closeBtn = new MenuLocation(12, 7);

        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SystemInformationSummary()
        {
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = SystemInformationSummary.APPLICATION_TITLE;
            this.Open();
        }

        private new void Open()
        {
            if ( log.IsDebugEnabled )
            {
                log.Debug("Opening System Information Summary");
            }
            base._WinWaitActivate(WinCal.APPLICATION_TITLE);
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + eventViewerMenuLocation.positionX, WinCal.WINCAL_LOCATION.positionY + eventViewerMenuLocation.positionY, 1); // Help
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + systemInformationSummaryOption.positionX, WinCal.WINCAL_LOCATION.positionY + systemInformationSummaryOption.positionY, 1); // About Box

            base.Open();

            if ( log.IsDebugEnabled )
            {
                log.DebugFormat("WinCal X={0}, WinCal Y={1}", WinCal.WINCAL_LOCATION.positionX, WinCal.WINCAL_LOCATION.positionY);
                log.DebugFormat("System Information Summary X={0}, About Y={1}", base.windowLocation.positionX + closeBtn.positionX, base.windowLocation.positionY + closeBtn.positionY);
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
