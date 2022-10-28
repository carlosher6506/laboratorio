using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESCUENTOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int precio = 6500;
                double oper = 0;
                double oper2 = 0;
                Console.WriteLine("Escritorio precio = $6500");
                Console.WriteLine("Numero de escritorio: ");
                int Num = int.Parse(Console.ReadLine());
                if(Num < 5)
                {
                    oper = precio *Num;
                    oper2= oper * 0.1;
                    Console.WriteLine($"${oper2} Lo que usted pagara");
                }
                if ((Num >=5)&&(Num<10))
                {
                    oper = precio * Num;
                    oper2 = oper * 0.2;
                    Console.WriteLine($"${oper2} Lo que usted pagara");
                }
                if (Num >=10)
                {
                    oper = precio * Num;
                    oper2 = oper * 0.4;
                    Console.WriteLine($"${oper2} Lo que usted pagara");
                }


            } while (true);
        }
    }
}
