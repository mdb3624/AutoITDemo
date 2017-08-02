using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.WinCal.proxy.pages
{
    class OpenFileError : BaseAutoIT
    {

        public static string APPLICATION_TITLE = "WinCal XE 4.8";
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OpenFileError()
        {
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = OpenFileError.APPLICATION_TITLE;
            this.Open();
        }

        public new int IsActive()
        {
            return base.IsActive();
        }

    }
}
