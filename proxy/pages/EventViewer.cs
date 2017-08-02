using System;

namespace Cascade.WinCal.proxy.pages
{
    class EventViewer : BaseAutoIT
    {
        public static string APPLICATION_TITLE = "EventWindow";
        private MenuLocation eventViewerMenuLocation = new MenuLocation(116, 38);
        private MenuLocation eventViewerOption = new MenuLocation(133, 67);
        private MenuLocation closeBtn = new MenuLocation(12, 7);

        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public EventViewer()
        {
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = EventViewer.APPLICATION_TITLE;
            this.Open();
        }

        private new void Open()
        {
            if ( log.IsDebugEnabled )
            {
                log.Debug("Opening Event Viewer");
            }
            base._WinWaitActivate(WinCal.APPLICATION_TITLE);
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + eventViewerMenuLocation.positionX, WinCal.WINCAL_LOCATION.positionY + eventViewerMenuLocation.positionY, 1); // Help
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + eventViewerOption.positionX, WinCal.WINCAL_LOCATION.positionY + eventViewerOption.positionY, 1); // About Box

            base.Open();

            if ( log.IsDebugEnabled )
            {
                log.DebugFormat("WinCal X={0}, WinCal Y={1}", WinCal.WINCAL_LOCATION.positionX, WinCal.WINCAL_LOCATION.positionY);
                log.DebugFormat("Event Viewer X={0}, About Y={1}", base.windowLocation.positionX + closeBtn.positionX, base.windowLocation.positionY + closeBtn.positionY);
            }

        }

        public new void Close()
        {
            base.Close();
        }

        public new int IsActive()
        {
            return base.IsActive();
        }
    }
}
