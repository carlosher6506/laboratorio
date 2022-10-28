using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FACTORIAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int fac;
            int cont;
            int n;
            Console.Write("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            if(n == 0)
            {
                Console.WriteLine("El factorial de 0 es: 1");
            }
            else
            {
                fac = n;
                for (cont = n; cont > 1; cont--)
                {
                    fac = fac * (cont - 1); 
                }
                Console.WriteLine($"El factorial de {n} es {fac}");

            }
            Console.ReadKey();


        }
    }
}