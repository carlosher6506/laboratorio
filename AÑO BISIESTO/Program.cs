using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AÑO_BISIESTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese un año: ");
                int Año = int.Parse(Console.ReadLine());
                if (Año % 4 == 0)
                {
                    if (Año % 100 == 1)
                    {
                        if (Año % 400 == 0)
                        {
                            Console.WriteLine("Este año es bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("Este año no es bisiesto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Este año es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("Este año no es bisiesto");
                }
            } while (true);
        }
    }
}
