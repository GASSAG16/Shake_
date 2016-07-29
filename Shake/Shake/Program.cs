using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontLine line = new HorizontLine(0, 78, 0, '+');
            HorizontLine line2 = new HorizontLine(0, 78, 24, '+');
            VerticalLine line3 = new VerticalLine(0, 24, 0, '+');
            VerticalLine line4 = new VerticalLine(0, 24, 78, '+');
            line.drow();
            line2.drow();
            line3.drow();
            line4.drow();
            
            //Point p = new Point(1, 3, '*');
            //p1.Draw();

            Point p = new Point(4, 5, '*');
            p.Draw();

            //HorizontLine line = new HorizontLine(5,10,8,'+');
            //line.drow();

            ////VerticalLine line2 = new VerticalLine(6, 11, 9, '-');
            //line2.drow();
           
            Console.ReadLine();
        }
    }
}
