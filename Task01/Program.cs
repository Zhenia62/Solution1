using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Rectangle
    {
        public int Height;
        public int Width;
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            
            //ввод и проверка ширины прямоугольника
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Please, enter height");
            rectangle.Height = int.Parse(Console.ReadLine());
            while (rectangle.Height <= 0)
            {
                Console.WriteLine("The height of the rectangle can" + "not be a negative number or a zero!");
                rectangle.Height = int.Parse(Console.ReadLine());
            }

            //ввод и проверка высоты прямоугольника
            Console.WriteLine("Please, enter Wight");
            rectangle.Width = int.Parse(Console.ReadLine());
            while (rectangle.Width <= 0)
            {
                Console.WriteLine("The width of the rectangle cannot be a negative number or a zero!");
                rectangle.Width = int.Parse(Console.ReadLine());
            } 

            //вывод
            Console.WriteLine($"Result = {rectangle.Height * rectangle.Width} cm");
            Console.ReadKey();
        }
    }
}
