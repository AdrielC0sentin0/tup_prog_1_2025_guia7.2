using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Num;

            Console.WriteLine(" Ingrese un número ");
            Num = Convert.ToDouble(Console.ReadLine());

            if (Num > 0)
            {
                Console.WriteLine("El número: " + Num + " Es Positivo");
            }
            else if (Num < 0)
            {
                Console.WriteLine("El número: " + Num + " Es Negativo");
            }
            else
            {
                Console.WriteLine("El número: " + Num + " Es Cero");
            }
        }
    }
}
