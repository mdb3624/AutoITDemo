using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using Cascade.WinCal.proxy.pages;

namespace Cascade.WinCal.proxy
{
    class WinCal : BaseAutoIT
    {
        public static string APPLICATION_TITLE = "Cascade Microtech WinCal XE 4.8";
        private static string APPLICATION = "C:/software/cmicro/WinCal XE_4.8/57/SysBin/WinCal.exe";
        public static MenuLocation WINCAL_LOCATION;
        private Dictionary<string, MenuLocation> menuItems = new Dictionary<string, MenuLocation>();
        private Dictionary<string, MenuLocation> helpMenuItems = new Dictionary<string, MenuLocation>();
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WinCal()
        {
            if (log.IsDebugEnabled)
            {
                log.Debug("Launching WinCal.....");
            }            
            Initialize();
        }

        private void Initialize()
        {
            base.application_title = WinCal.APPLICATION_TITLE;

/*
 * Make sure that WinCal is not currently running.
 */
            Process[] processes = Process.GetProcessesByName("WinCal");
            if (processes.Length > 0)
            {
                log.Debug("Wincal currently running");
                log.DebugFormat("Process: {0} ID: {1}", processes[0].ProcessName, processes[0].Id);
                processes[0].Kill();
            }

// Start up WinCal now
            autoIT.Run(WinCal.APPLICATION);

            if (log.IsDebugEnabled)
            {
                log.DebugFormat("WinCal error window {0}",autoIT.WinExists(WinCalStartupError.APPLICATION_TITLE));
            }

            if ( 1 == autoIT.WinExists(WinCalStartupError.APPLICATION_TITLE) )
            {
                WinCalStartupError error = new WinCalStartupError();
                error.Close();
                Initialize();
            }

            base.Open();
            WINCAL_LOCATION = new MenuLocation(base.windowLocation.positionX, base.windowLocation.positionY);

            buildMenuItems();
            buildHelpItems();

        }

        private void buildMenuItems()
        {
            menuItems.Add("File", new MenuLocation(26, 42));
            menuItems.Add("Setup", new MenuLocation(67, 42));
            menuItems.Add("View", new MenuLocation(125, 40));
            menuItems.Add("Calibration", new MenuLocation(181, 43));
            menuItems.Add("Tools", new MenuLocation(249, 41));
            menuItems.Add("Wizards", new MenuLocation(291, 44));
            menuItems.Add("Help", new MenuLocation(344, 39));
        }

        private void buildHelpItems()
        {
            helpMenuItems.Add("About",new MenuLocation(416, 287));
        }

        public About getAboutBox()
        {
            return new About();
        }

        public FileOpen getFileOpen()
        {
            return new FileOpen();
        }

        public EventViewer getEventViewer()
        {
            return new EventViewer();
        }

        public SystemInformationSummary getSystemInformationSummary()
        {
            return new SystemInformationSummary();
        }

        public Calibration getCalibration()
        {
            return new Calibration();
        }

        public new void Close()
        {
            if (log.IsDebugEnabled)
            {
                log.Debug("Closing Down WinCal.....");
            }

            autoIT.MouseClick("left", base.windowLocation.positionX + 29, base.windowLocation.positionY + 39, 1);
            autoIT.MouseClick("left", base.windowLocation.positionX + 107, base.windowLocation.positionY + 224, 1);

            Thread.Sleep(250);
        }
    }
}
