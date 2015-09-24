using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Vertical: Figure
    {


        public Vertical(int yUp, int yDown, int x,  char sym)
        {
            pList = new List<Point>();
            for (int i = yUp; i <= yDown; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }


    }
}
