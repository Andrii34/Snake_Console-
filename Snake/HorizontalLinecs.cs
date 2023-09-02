using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontalLinecs:Figure
    {
        
        public HorizontalLinecs(int xLeft,int xReight,int y,char sym) 
        { 
            points = new List<Point>();
            for (int x = xLeft ; x < xReight; x++)
            {
                Point point = new Point(x, y, sym);
                points.Add(point);

            }
        }

        
    }
}
