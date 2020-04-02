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
            Point p2 = new Point(8,4,'o');
            Point p3 = new Point(2, 7, 'o');
            Point p4 = new Point(3, 6, 'o');

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            
            foreach(Point i in pList)
            {
                i.Draw();
            }
            Console.ReadLine();
        }
       
    }
}
