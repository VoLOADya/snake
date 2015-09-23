using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1,3,'*');
            p1.DrawSym();

            Point p2 = new Point(4,5,'*');
            p2.DrawSym();

            Horizont hLine1 = new Horizont(0,25,0,'#');
            hLine1.Draw();
            Horizont hLine2 = new Horizont(0, 25, 8, '#');
            hLine2.Draw();
            Vertical vLine1 = new Vertical(0,0,8,'#');
            vLine1.Draw();
            Vertical vLine2 = new Vertical(25, 0, 8, '#');
            vLine2.Draw();


            Console.ReadLine();
        }

    }
}
