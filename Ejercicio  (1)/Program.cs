﻿using System;
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
            double n1, n2, n3, promedio, CantidadPromedio;

            Console.WriteLine(" Ingresar Nota 1 ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Ingresar Nota 2 ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Ingresar Nota 3 ");
            n3 = Convert.ToDouble(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine(" Indique promedio necesario para promocionar ");
            CantidadPromedio = Convert.ToDouble(Console.ReadLine());

            if (promedio >= CantidadPromedio)
            {
                Console.WriteLine(" Promociona ");
            }
          else
            {
                Console.WriteLine(" Debe rendir final ");
            }
        }
    }
}
