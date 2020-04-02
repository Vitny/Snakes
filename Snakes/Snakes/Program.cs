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
            Point p1 = new Point(6,6,'o');
            p1.Draw();

            Point p2 = new Point(8,4,'o');
            p2.Draw();

            Console.ReadLine();
        }
       
    }
}
