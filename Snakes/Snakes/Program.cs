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
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, 'o');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, 'o');
            VerticalLine leftline = new VerticalLine(0, 24, 0, 'o');
            VerticalLine rightline = new VerticalLine(0, 24, 78, 'o');
            upLine.Draw();
            downLine.Draw();
            leftline.Draw();
            rightline.Draw();

            Console.ReadLine();
        }
       
    }
}
