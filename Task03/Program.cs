using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Please, enter the count of lines");
            var Number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= Number; i++) // Проходим по каждой строке
            {
                for (int j = Number - 1; j >= i; j--) //Добавление пробелов для центрирования
                {
                    Console.Write(" ");
                }
                for (int x = 1; x<=i*2-1; x++) //Ввод символов
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
