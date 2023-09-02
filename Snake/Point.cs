using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Point
    {
         public int _x;
         public int _y;
         public char _sym;
        
      public Point(int x,int y, char sym)

       {
            _x = x;
            _y = y;
            _sym = sym;

       }
      public Point(Point p)
        {
            _x = p._x;
            _y = p._y;
            _sym = p._sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.WriteLine(_sym);
            
        }


        public void Move(int offset, Direction direction )
 
        {
            if(direction==Direction.LEFT)
            {
                _x -= offset;
            }
            else if(direction==Direction.RIGHT)
            {
                _x += offset;
            }
            else if(direction==Direction.UP)
            {
                _y -= offset;
            }
            else if(direction== Direction.DOWN) 
            {
                _y+=offset;
            }
        }

        public void Clear()
        {
            _sym= ' ';
            Draw();
        }
        public bool IsHit(Point point)
        {
            return point._x == this._x&& point._y==this._y;
        }
    }
    
}
