﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class Point
    {
        public int x, y;
        public char sym;


        public Point()
        { }
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
