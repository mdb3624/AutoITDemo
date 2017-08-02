using System;

namespace Cascade.WinCal.proxy.pages
{
    class About : BaseAutoIT
    {
        public static string APPLICATION_TITLE = "About WinCal XE";
        private MenuLocation helpMenuLocation = new MenuLocation(344, 39);
        private MenuLocation aboutMenuLocation = new MenuLocation(416, 287);
        private MenuLocation closeBtn = new MenuLocation(357, 432);

        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public About()
        {
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = About.APPLICATION_TITLE;
            this.Open();
        }

        private new void Open()
        {
            if ( log.IsDebugEnabled )
            {
                log.Debug("Opening About Box");
            }
            base._WinWaitActivate(WinCal.APPLICATION_TITLE);
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + helpMenuLocation.positionX, WinCal.WINCAL_LOCATION.positionY + helpMenuLocation.positionY, 1); // Help
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + aboutMenuLocation.positionX, WinCal.WINCAL_LOCATION.positionY + aboutMenuLocation.positionY, 1); // About Box

            base.Open();

            if ( log.IsDebugEnabled )
            {
                log.DebugFormat("WinCal X={0}, WinCal Y={1}", WinCal.WINCAL_LOCATION.positionX, WinCal.WINCAL_LOCATION.positionY);
                log.DebugFormat("About X={0}, About Y={1}", base.windowLocation.positionX + closeBtn.positionX, base.windowLocation.positionY + closeBtn.positionY);
            }

        }

        public int IsCopyRightCurrent()
        {
            string copyRightNotice = "Copyright 1995-" + DateTime.Now.Year.ToString();
            int result = 0;

            string aboutText = autoIT.WinGetText(About.APPLICATION_TITLE);
            result = Convert.ToInt32(aboutText.Contains(copyRightNotice));
            return result;
        }

        public new void Close()
        {
            autoIT.MouseClick("left", base.windowLocation.positionX + closeBtn.positionX, base.windowLocation.positionY + closeBtn.positionY, 1); // Help
        }

        public new int IsActive()
        {
            return base.IsActive();
        }
    }
}
