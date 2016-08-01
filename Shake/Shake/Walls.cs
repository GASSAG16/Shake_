using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class Walls
    {
        List<Figura> walllist;

        public Walls (int mapWidht, int mapHeigt)
        {
            walllist = new List<Figura>();
            
            HorizontLine line = new HorizontLine(0, mapWidht-2, 0, '+');
            HorizontLine line2 = new HorizontLine(0, mapWidht - 2, mapHeigt-1, '+');
            VerticalLine line3 = new VerticalLine(0, mapHeigt-1, 0, '+');
            VerticalLine line4 = new VerticalLine(0, mapHeigt - 1, mapWidht-2, '+');

            walllist.Add(line);
            walllist.Add(line2);
            walllist.Add(line3);
            walllist.Add(line4);
        }

        internal bool IsHit(Figura figura)
        {
            foreach (var wall in walllist)
            {
                if(wall.IsHit(figura))
                {
                    return true;
                }
            }
            return false;
        }

        public void drow()
        {
            foreach (var wall in walllist)
            {
                wall.drow();
            }
        }


    }
}
