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
            HorizontalLine line1 = new HorizontalLine(3, 7, 5, 'o');
            VerticalLine line2 = new VerticalLine(11, 18, 8, 'o');
            line1.DrawHor();
            line2.DrawVert();
            Console.ReadLine(); 
        }
       
    }
}
