using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCiclos
{
    class Program
    {
        static double exponencial(int a, int b)
        {
            return Math.Pow(a, b);
        }
        static void Main(string[] args)
        {
            int exponente, b;
            int n;

            Console.Write("favor de ingresar el valor de n:");
            n = int.Parse(Console.ReadLine());

            for (int x = 0; x < n; x++)
            {
                Console.Write("\nFavor de ingresar la base:");
                b = int.Parse(Console.ReadLine());

                Console.Write("Favor de ingresar el exponente:");
                exponente = int.Parse(Console.ReadLine());

                Console.Write(b + "Elevado a:" + exponente + " = " + exponencial(b, exponente));
            }
            Console.ReadKey();
        }
    }
}
