using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    internal class Snake : Figure
    {
        private Direction _direction;
        public Snake(Point tail,int lenght,Direction direct) 
        {
            _direction = direct;
            points= new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point point = new Point(tail);
                point.Move(i, _direction);
                points.Add(point);
            }
        }

        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key== ConsoleKey.W)
            {
                _direction = Direction.UP;
            }
            else if (key == ConsoleKey.S)
            {
                _direction = Direction.DOWN;
            }
            else if (key == ConsoleKey.D)
            {
                _direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.A)
            {
                _direction = Direction.LEFT;
            }
        }

        internal bool Eat(Point food ) 
        {
            Point head = GetNextPoint();
            if(head.IsHit(food))
            {
                food._sym = head._sym;
                points.Add(food);
                return true;
            }
            else
            { 
                return false; 
            }
        }

        internal bool IsHitTail()
        {
            Point head = points.Last();
            for (int i = 0; i < points.Count-2; i++)
            {
                if (head.IsHit(points[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
