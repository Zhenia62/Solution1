using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

<<<<<<< HEAD
            var count = 0;
            Console.WriteLine("Please, enter the count of lines");
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                var str = new string('*', count+=1);
=======
            var Count = 0;
            Console.WriteLine("Please, enter the count of lines");
            var Number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Number; i++)
            {
                var str = new string('*', Count+=1);
>>>>>>> 983fa694862a66bf2bd37d9183c14f62645afd7b
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
