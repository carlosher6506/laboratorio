using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 2;
            int cont2 = 0;
            int res;

            Console.Write("Ingrese el numero:");
            int n = int.Parse(Console.ReadLine());

            while (cont1 < n && cont2 == 0)
            {
                res = n % cont1;
                if (res == 0)
                {
                    cont2 = 1;
                }
                else
                {
                    cont1 = cont1 + 1;
                }
            }
            if (cont2 == 0)
            {
                Console.WriteLine($"El numero {n} es primo");
            }
            else
            {
                Console.WriteLine($"El numero {n} no es primo");
            }
            Console.ReadKey();
        }
    }
}
