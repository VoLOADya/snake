﻿using System;
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
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            //     Console.SetCursorPosition(x1, y1);
            //     Console.Write(sym1);
            DrawSym(x1, y1, sym1);
            
            int x2 = 3;
            int y2 = 5;
            char sym2 = '#';
            //      Console.SetCursorPosition(x2, y2);
            //       Console.Write(sym2);
            DrawSym(x2, y2, sym2);

            Console.ReadLine();
        }
            static void DrawSym(int x,int y,char sym)
            {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
