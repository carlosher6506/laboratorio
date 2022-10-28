using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ejer_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tem = "";
            int cal = 0;
            string mensajes = "";
            do
            {

                Console.WriteLine("Ingrese la temperatura:");
                tem = Console.ReadLine();
                bool val = int.TryParse(tem, out cal);
                if (val == true)
                {
                    mensajes = cal <= 15 ? "Hace mucho frio" : "";
                    Console.WriteLine(mensajes);
                    mensajes = cal >= 16 && cal <= 28 ? "Hace un clima agradable" : "";
                    Console.WriteLine(mensajes);
                    mensajes = cal > 28 ? "Hace mucho calor" : "";
                    Console.WriteLine(mensajes);
                }
                else
                {
                    Console.WriteLine("Temperatura no valida");
                }
            }while(tem != "");






        }
    }
}
