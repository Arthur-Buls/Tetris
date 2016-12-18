using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris.Helpers
{
    public static class ConstantHelper
    {
        public static int BlockXNumber
        {
            get { return 20; }
        }
        public static int BlockYNumber
        {
            get { return 40; }
        }
        public static Pen GridPen = new Pen(Brushes.HotPink, 1);
    }
}
