using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class HorizontLine
    {
        List<Point> tlist;

        public HorizontLine(int xleft, int xrait, int y, char sym)
        {
            tlist = new List<Point>();

            for (int x = xleft; x < xrait; x++)
            {
                Point p = new Point(x, y, sym);
                tlist.Add(p);
            }
            //Point p1 = new Point(4,4,'*');
            //Point p2 = new Point(5,4,'*');
            //Point p3 = new Point(6,4,'*');

            //tlist.Add(p1);
            //tlist.Add(p2);
            //tlist.Add(p3);
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
