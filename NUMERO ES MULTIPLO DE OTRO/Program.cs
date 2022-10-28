using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMERO_ES_MULTIPLO_DE_OTRO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                int N1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero para saber si es multiplo del primero: ");
                int N2 = int.Parse(Console.ReadLine());
                if(N1 % N2 == 0)
                {
                    Console.WriteLine($"El numero {N2} es multiplo de {N1}");
                }
                else
                {
                    Console.WriteLine($"El numero {N2} no es multiplo de {N1}");
                }
            }while(true);
        Console.ReadKey();
        }
    }
}
