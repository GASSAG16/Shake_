using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class Shake : Figura
    {
        public Shake(Point tail, int lenght, Direction direction)
        {      
            tlist = new List<Point>();
            
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                tlist.Add(p);
            }
        }
    }
}
