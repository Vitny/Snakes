using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 6;
            p1.y = 6;
            p1.sym = 'o';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 4;
            p2.sym = 'o';
            p2.Draw();

            Console.ReadLine();
        }
       
    }
}
