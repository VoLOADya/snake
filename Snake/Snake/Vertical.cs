using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Vertical
    {
        List<Point> pList;

        public Vertical(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int i = yUp; i <= yDown; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.DrawSym();
            }
        }
    }
}
