using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Walls
    {
        List<Figure> wallList;
    public Walls(int mapWidth,int mapHeight)
    {
            wallList = new List<Figure>();
            HorizontalLinecs upline = new HorizontalLinecs(0, mapWidth-2, 0, '#');
            HorizontalLinecs downline = new HorizontalLinecs(0, mapWidth - 2, mapHeight-1, '#');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '#');
            VerticalLine rigtLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '#');
            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftLine);
            wallList.Add(rigtLine);
        }
        internal bool IsHith(Figure figure)
        {
            foreach (Figure wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (Figure wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}
