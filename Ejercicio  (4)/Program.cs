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
            double num, mayor, i;

            Console.WriteLine(" Ingrese un numero 1 ");
            num = Convert.ToDouble(Console.ReadLine());

            mayor = num;

            for (i = 2; i <= 5; i++)
            {
                Console.WriteLine(" Ingrese un numero " + i);
                num = Convert.ToDouble(Console.ReadLine());

                if (num > mayor)
                {
                    mayor = num;
                }

            }

            Console.WriteLine("El numero: "+ mayor+ " Es Mayor");
        }
    }
}
