using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double punt;
            string nom;
            Console.WriteLine("Ingrese su nombre");
            nom =Console.ReadLine();
            Console.WriteLine("Ingrese sus puntos");
            punt = Double.Parse(Console.ReadLine());

            Comparacion(punt, nom);
            Console.ReadLine();
        }

        static void Comparacion(double punt, string nom)
        {
            double punt2 = 9993.7;
            string nom2 = "Gohe";

            if (punt2 < punt)
            {
                Console.WriteLine($"{nom} Es la persona que rompio el record");
                Console.WriteLine($"Superando a {nom2}");
                Console.WriteLine($"Con los puntos: {punt}");
            }
            else
            {
                Console.WriteLine($"{nom2} Es la persona que aun tiene el puntaje record");
                Console.WriteLine($"{punt2} Sigue siendo la mejor puntuacion");
            }
        }
    }
}
