using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class FoodCreator
    {
        int mapWidnt, mapHeight;
        char sym;
        Random random = new Random();

        public FoodCreator(int mapWidnt, int mapHeight, char sym)
        {
            this.mapWidnt = mapWidnt;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
        
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidnt - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);   
        }



    }
}
