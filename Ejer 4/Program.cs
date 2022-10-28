using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Ejercicio 1
                Console.WriteLine("Ingrese un numero:");
                int num1 = int.Parse(Console.ReadLine());
                if (num1 % 2 == 0)
                    Console.WriteLine($"El numero {num1} es par");
                else
                    Console.WriteLine($"El numero {num1} es impar");

            Console.ReadKey();
            } while(true);

        }
    }
}
