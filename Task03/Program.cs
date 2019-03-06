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

<<<<<<< HEAD
            int count = -1;

=======
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b
            for (int i = 1; i <= Number; i++) // Проходим по каждой строке
            {
                for (int j = Number - 1; j >= i; j--) //Добавление пробелов для центрирования
                {
                    Console.Write(" ");
                }
<<<<<<< HEAD
                var str = new string('*', count += 2);
                Console.WriteLine(str);
=======
                for (int x = 1; x<=i*2-1; x++) //Ввод символов
                {
                    Console.Write("*");
                }
                Console.WriteLine();
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b
            }
            Console.ReadKey();
        }
    }
}
