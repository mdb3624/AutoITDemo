namespace Cascade.WinCal.proxy.pages
{
    class BaseAutoIT
    {

        private static readonly log4net.ILog log =
    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected string application_title { get; set; }
        protected string windowHandle { get; set; }

        protected MenuLocation windowLocation;

        protected AutoItX3Lib.AutoItX3 autoIT = new AutoItX3Lib.AutoItX3();

        protected BaseAutoIT() { }

        public void Open()
        {
            if (log.IsDebugEnabled)
            {
                log.Debug("opening " + application_title);
            }
            _WinWaitActivate(application_title);
            windowLocation = new MenuLocation(autoIT.WinGetPosX(application_title), autoIT.WinGetPosY(application_title));
            if ( log.IsDebugEnabled )
            {
                log.DebugFormat("{0} handle is {1}", application_title, autoIT.WinGetHandle(application_title) );
            }
            windowHandle = autoIT.WinGetHandle(application_title);
        }

        public void Close()
        {
            if ( log.IsDebugEnabled )
            {
                log.Debug("closing " + application_title);
            }
            if ( 0 == autoIT.WinClose(application_title) )
            {
                if (log.IsDebugEnabled)
                {
                    log.Debug("Error closing " + application_title);
                }
            }
        }

        protected void _WinWaitActivate(string title)
        {
            if (log.IsDebugEnabled)
            {
                log.Debug("Waiting for " + application_title + " to Launch");
            }
            autoIT.WinActivate(title);
            autoIT.WinWaitActive(title);
        }

        protected int IsActive()
        {
            return autoIT.WinActive(application_title);
        }

    }
}
