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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontLine line = new HorizontLine(5,10,8,'+');
            line.drow();

            VerticalLine line2 = new VerticalLine(6, 11, 9, '-');
            line2.drow();
           //List <char> charlist = new List<char>();
           // charlist.Add('*');
           // charlist.Add('#');
            
            
           // List<int> numlist = new List<int>();
           // numlist.Add(0);
           // numlist.Add(1);
           // numlist.Add(2);

           // int x = numlist[0];
           // int y = numlist[1];
           // int z = numlist[2];
            
           // char rt = charlist[0];


           // foreach (var  i in numlist)
           // {
           //     Console.WriteLine(i);
           // }
           // numlist.RemoveAt(0);

           // List<Point> plist =new List<Point>();
           // plist.Add(p1);
           // plist.Add(p2);


           
            Console.ReadLine();
        }
    }
}
