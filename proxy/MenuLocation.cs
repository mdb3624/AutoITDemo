using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cascade.WinCal.proxy
{
    class MenuLocation
    {
        public MenuLocation(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }
        public int positionX { get; set; }
        public int positionY { get; set; }
    }
}
