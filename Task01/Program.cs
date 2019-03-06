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
<<<<<<< HEAD
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

=======
        
        static void Main(string[] args)
        {
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            
            //ввод и проверка ширины прямоугольника
<<<<<<< HEAD
            

            Console.WriteLine("Please, enter height");
            rectangle.Height = int.Parse(Console.ReadLine());
            rectangle.Height = Result(rectangle.Height);

=======
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Please, enter height");
            rectangle.Height = int.Parse(Console.ReadLine());
            while (rectangle.Height <= 0)
            {
                Console.WriteLine("The height of the rectangle can" + "not be a negative number or a zero!");
                rectangle.Height = int.Parse(Console.ReadLine());
            }
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b

            //ввод и проверка высоты прямоугольника
            Console.WriteLine("Please, enter Wight");
            rectangle.Width = int.Parse(Console.ReadLine());
<<<<<<< HEAD
            rectangle.Width = Result(rectangle.Width);

            //Вывод
            Output(rectangle.Width, rectangle.Height);
        }

         static int Result(int value)
        {
            Rectangle rectangle = new Rectangle();
            while (value <= 0)
            {
                Console.WriteLine("The side of the rectangle cannot be a negative number or a zero!");
                value = int.Parse(Console.ReadLine());
            }
            return value;
        }

        static void Output(int FirstValue, int SecondValue)
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine($"Result = {FirstValue * SecondValue} cm");
=======
            while (rectangle.Width <= 0)
            {
                Console.WriteLine("The width of the rectangle cannot be a negative number or a zero!");
                rectangle.Width = int.Parse(Console.ReadLine());
            } 

            //вывод
            Console.WriteLine($"Result = {rectangle.Height * rectangle.Width} cm");
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b
            Console.ReadKey();
        }
    }
}
