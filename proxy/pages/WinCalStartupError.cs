using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.WinCal.proxy.pages
{
    class WinCalStartupError : BaseAutoIT
    {

        public static string APPLICATION_TITLE = "WinCal XE 4.8";
        private static string ERROR_CONTENT = "Is another instance of WinCal running?";
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WinCalStartupError()
        {
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = WinCalStartupError.APPLICATION_TITLE;
            this.Open();
        }

        public new int IsActive()
        {
            return base.IsActive();
        }

        public int IsError()
        {
            int result = 0;
            if (base.IsActive() == 1)
            {
                string errorContent = autoIT.WinGetText(WinCalStartupError.APPLICATION_TITLE);
                result = Convert.ToInt32(errorContent.Contains(ERROR_CONTENT));
            }
            return result;
        }

        public new void Close()
        {
            if (1 == autoIT.WinExists(WinCalStartupError.APPLICATION_TITLE)) {
                base._WinWaitActivate(WinCalStartupError.APPLICATION_TITLE);
                autoIT.MouseClick("left", base.windowLocation.positionX + 431, base.windowLocation.positionY + 778, 1);
            }
        }

    }
}
