﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shake
{
    class Shake : Figura
    {
        Direction direction;
        public Shake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            tlist = new List<Point>();        
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                tlist.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = tlist.First();
            tlist.Remove(tail);
            Point head = GetNextPoint();
            tlist.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = tlist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;        
        }
        
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                tlist.Add(food);
                return true;
            }
            else
                return false;
        }

    }
}
