using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class Point
    {
        public int x, y;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
