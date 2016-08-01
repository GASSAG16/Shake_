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
        internal bool IsHit(Figura figura)
        {
            foreach (var p in tlist)
            {
                if (figura.IsHit(p))
                    return true;
            }
            return false;
            
        }
        private bool IsHit(Point point)
        {
            foreach (var p in tlist)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
