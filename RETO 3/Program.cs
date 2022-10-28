using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cal = 0;
            double suma = 0;
            double promedio = 0;
            int cont = 0;
            string tex = "";
            do
            {
                Console.WriteLine("Ingrese la calificacion:");
                tex = Console.ReadLine();
                bool val = double.TryParse(tex, out cal);
                if(val == true)
                {
                    if (tex != "")
                    {
                        suma = suma + cal;
                        cont++;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese un valor valido");
                    }
                }
                
            } while (tex != "fin");
            promedio = suma / cont;
            Console.WriteLine($"El promedio es:{promedio}");
            Console.ReadKey();
        }
    }
}