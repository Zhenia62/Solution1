using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
<<<<<<< HEAD
        static int CountTriangles;
=======
        static int Count;
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

<<<<<<< HEAD
            Console.WriteLine("Please, enter the count of triangles");
            CountTriangles = int.Parse(Console.ReadLine());

            int rowscount = Rows();

            for (int n = 1; n <= CountTriangles; n++)//Проходим по каждому треугольнику
            {
                for (int i = 1; i <= n; i++) // Проходим по каждой строке
                {
                    for (int j = rowscount - 1; j >= i; j--) //Добавление пробелов для центрирования
=======
            Console.WriteLine("Please, enter the count of lines");
            Count = int.Parse(Console.ReadLine());

            int RowsCount = Rows();

            for (int n = 1; n <=Count; n++)//Проходим по каждому треугольнику
            {
                for (int i = 1; i <= n; i++) // Проходим по каждой строке
                {
                    for (int j = RowsCount - 1; j >= i; j--) //Добавление пробелов для центрирования
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b
                    {
                        Console.Write(" ");
                    }
                    for (int x = 1; x <= i * 2 - 1; x++) //Ввод символов
                    {
                        Console.Write("*");
                    }
<<<<<<< HEAD
=======
                    Console.WriteLine();
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b
                }

            }Console.ReadKey();


        }

        static int Rows()//Подсчет количества строк
        {
<<<<<<< HEAD
            int rowscount = 0; 
            for (int i = CountTriangles; i >= 0; i--)
            {
                rowscount += i;
            }
            return rowscount;
=======
            int RowsCount = 0; 
            for (int i = Count; i >= 0; i--)
            {
                RowsCount += i;
            }
            return RowsCount;
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b
        }
    }
}
