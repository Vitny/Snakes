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

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, 'o');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, 'o');
            VerticalLine leftline = new VerticalLine(0, 24, 0, 'o');
            VerticalLine rightline = new VerticalLine(0, 24, 78, 'o');
            upLine.DrawLine();
            downLine.DrawLine();
            leftline.DrawLine();
            rightline.DrawLine();


            Point p = new Point(4, 6, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();
            snake.Move();
            Console.ReadLine();
        }
       
    }
}
