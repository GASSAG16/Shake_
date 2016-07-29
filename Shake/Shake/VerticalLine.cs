using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class VerticalLine
    {
        List<Point> tlist;

        public VerticalLine(int yleft, int yrait, int x,char sym)
        {
            tlist = new List<Point>();

            for (int y = yleft; y < yrait; y++)
            {
                Point p = new Point(y, x, sym);
                tlist.Add(p);
            }
        }
        public void drow()
        {
            foreach (Point p in tlist)
            {
                p.Draw();
            }
        }

    }
}
