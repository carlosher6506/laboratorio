using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMERO_MAYOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Ejercicio 2
                Console.WriteLine("Ingrese primer numero");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero");
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tercer numero");
                int num4 = int.Parse(Console.ReadLine());
                if ((num2 > num3) && (num2 > num4))
                    Console.WriteLine($"El numero: {num2} es mayor");
                if ((num3 > num2) && (num3 > num4))
                    Console.WriteLine($"El numero: {num3} es mayor");
                if ((num4 > num2) && (num4 > num3))
                    Console.WriteLine($"El numero:{num4} es mayor");
            }while (true);
           
        }
    }
}
