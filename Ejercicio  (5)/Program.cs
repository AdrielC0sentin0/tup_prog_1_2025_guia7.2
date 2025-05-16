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
            double num, menor, i;
            Console.WriteLine(" Ingresar el numero 1 ");
            num = Convert.ToDouble(Console.ReadLine());

            menor = num;

            for (i = 2; i <= 5; i++)
            {
                Console.WriteLine(" Ingresar el numero " + i);
                num = Convert.ToDouble(Console.ReadLine());

                if (num < menor)
                {
                    menor = num;

                }
            }
            Console.WriteLine("El numero: "+ menor+ " Es Menor");
        }
    }
}
