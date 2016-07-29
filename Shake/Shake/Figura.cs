using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class Figura
    {
        protected List<Point> tlist;

        public void drow()
        {
            foreach (Point p in tlist)
            {
                p.Draw();
            }
        }
    }
}
