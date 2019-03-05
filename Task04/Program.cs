using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static int Count;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Please, enter the count of lines");
            Count = int.Parse(Console.ReadLine());

            int RowsCount = Rows();

            for (int n = 1; n <=Count; n++)//Проходим по каждому треугольнику
            {
                for (int i = 1; i <= n; i++) // Проходим по каждой строке
                {
                    for (int j = RowsCount - 1; j >= i; j--) //Добавление пробелов для центрирования
                    {
                        Console.Write(" ");
                    }
                    for (int x = 1; x <= i * 2 - 1; x++) //Ввод символов
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }Console.ReadKey();


        }

        static int Rows()//Подсчет количества строк
        {
            int RowsCount = 0; 
            for (int i = Count; i >= 0; i--)
            {
                RowsCount += i;
            }
            return RowsCount;
        }
    }
}
