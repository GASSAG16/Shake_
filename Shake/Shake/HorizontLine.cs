using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class HorizontLine:Figura
    {
        public HorizontLine(int xleft, int xrait, int y, char sym)
        {
            tlist = new List<Point>();

            for (int x = xleft; x <= xrait; x++)
            {
                Point p = new Point(x, y, sym);
                tlist.Add(p);
            }
        }
    }
}
