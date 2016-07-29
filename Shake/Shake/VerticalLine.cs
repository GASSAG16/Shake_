using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class VerticalLine :Figura
    {
        public VerticalLine(int yleft, int yrait, int x,char sym)
        {
            tlist = new List<Point>();

            for (int y = yleft; y <= yrait; y++)
            {
                Point p = new Point(x, y, sym);
                tlist.Add(p);
            }
        }
    }
}
