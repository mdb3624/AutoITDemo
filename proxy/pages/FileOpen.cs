using System;

namespace Cascade.WinCal.proxy.pages
{
    class FileOpen : BaseAutoIT
    {
        public static string APPLICATION_TITLE = "Open";
        private MenuLocation fileMenuLocation = new MenuLocation(28, 40);
        private MenuLocation openSystemSetupMenuLocation = new MenuLocation(49, 57);
        private MenuLocation closeBtn = new MenuLocation(357, 432);

        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public FileOpen()
        {
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = FileOpen.APPLICATION_TITLE;
            this.Open();
        }

        private new void Open()
        {
            if ( log.IsDebugEnabled )
            {
                log.Debug("Opening File Open Dialog");
            }
            base._WinWaitActivate(WinCal.APPLICATION_TITLE);
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + fileMenuLocation.positionX, WinCal.WINCAL_LOCATION.positionY + fileMenuLocation.positionY, 1); // Help
            autoIT.MouseClick("left", WinCal.WINCAL_LOCATION.positionX + openSystemSetupMenuLocation.positionX, WinCal.WINCAL_LOCATION.positionY + openSystemSetupMenuLocation.positionY, 1); // About Box

            base.Open();

            if ( log.IsDebugEnabled )
            {
                log.DebugFormat("WinCal X={0}, WinCal Y={1}", WinCal.WINCAL_LOCATION.positionX, WinCal.WINCAL_LOCATION.positionY);
                log.DebugFormat("About X={0}, About Y={1}", base.windowLocation.positionX + closeBtn.positionX, base.windowLocation.positionY + closeBtn.positionY);
            }

        }

        public new int IsActive()
        {
            return base.IsActive();
        }

        public int loadBadSetupFile()
        {
            int result = 0;

            autoIT.MouseClick("left", base.windowLocation.positionX + 492, base.windowLocation.positionY + 155, 1); //Select File 
            autoIT.MouseClick("left", base.windowLocation.positionX + 492, base.windowLocation.positionY + 155, 1); // Click File

            OpenFileError errorBox = new OpenFileError();
            errorBox.Open();
            result = errorBox.IsActive();
            errorBox.Close();

            return result;
        }
    }
}
