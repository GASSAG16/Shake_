using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.drow();
            
            Point p = new Point(4, 5, '*');
            Shake shake = new Shake(p,4,Direction.RIGHT);
            shake.drow();

            FoodCreator FoodCreator  = new FoodCreator (80,25, '$');
            Point food = FoodCreator.CreateFood();
            food.Draw();


            while (true)
            {
                if (walls.IsHit(shake) || shake.IsHitTail())
                {
                    break;
                }
                if (shake.Eat(food))
                {
                   food=FoodCreator.CreateFood();
                   food.Draw();
                }
                else
                {
                    shake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    shake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                shake.Move();
            }
        }
    }
}
