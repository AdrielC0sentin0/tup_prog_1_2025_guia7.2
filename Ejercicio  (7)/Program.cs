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
            int year;

            Console.Write("Ingrese un año: ");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("El año " + year + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + year + " no es bisiesto");
            }
        }
    }
}
