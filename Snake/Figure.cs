using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Figure
    {
        protected List<Point> points;

        public void Drow()
        {
            foreach (Point point in points)
            {
                point.Draw();
            }
           
        }
        internal bool IsHit(Figure figure)
        {
            foreach(Point point in points)
            {
                if (figure.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach(Point point1 in points)
            {
                if(point1.IsHit(point)) 
                    return true;
            }
            return false;
        }
    }
}   
