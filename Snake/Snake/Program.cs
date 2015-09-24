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
            Console.SetBufferSize(80,25);
 

            Horizont hLine1 = new Horizont(0,78,0,'#');
            hLine1.Draw();
            Horizont hLine2 = new Horizont(0, 78, 24, '#');
            hLine2.Draw();
            Vertical vLine1 = new Vertical(0,24,0,'#');
            vLine1.Draw();
            Vertical vLine2 = new Vertical(0, 24, 78, '#');
            vLine2.Draw();

            Point p = new Point(5,5,'+');
            Snake snake = new Snake(p,3,Direction.RIGHT);
            snake.Draw();

            
        }

    }
}
