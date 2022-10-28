using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORDENACION_DE_3_NUMEROS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Ejercicio 3
                Console.WriteLine("Ingrese primer numero");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tercer numero");
                int n2 = int.Parse(Console.ReadLine());
                if ((n > n1) && (n > n2))
                    Console.WriteLine($"El numero{n} es primero");
                if ((n1 > n) && (n1 > n2))
                    Console.WriteLine($"El numero{n1} es primero");
                if ((n2 > n) && (n2 > n1))
                    Console.WriteLine($"El numero{n2} es primero");

                //Segundo
                if (n < n1 && n > n2)
                    Console.WriteLine($"El numero{n} es segundo");
                if (n < n1 && n2 > n1)
                    Console.WriteLine($"El numero{n1} es segundo");
                if (n2 < n1 && n2 > n)
                    Console.WriteLine($"El numero{n2} es segundo");

                //Tercero
                if (n < n1 && n < n2)
                    Console.WriteLine($"El numero{n} es tercero ");
                if (n1 < n && n1 < n2)
                    Console.WriteLine($"El nuemro{n1} es tercero ");
                if (n2 < n && n2 < n1)
                    Console.WriteLine($"El numero{n2} es tercero");
                Console.ReadKey();
            }while (true);
            
        }
    }
}
