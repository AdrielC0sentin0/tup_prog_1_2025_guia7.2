﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Guia_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string j1, j2;
            int sj1, sj2, setwinj1, setwinj2, i;

            Console.WriteLine(" Ingrese el nombre del jugador 1 ");
            j1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" Ingrese el nombre del jugador 2 ");
            j2 = Convert.ToString(Console.ReadLine());

            setwinj1 = 0;
            setwinj2 = 0;

            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine("Ingrese los puntos del set "+ i + " ("+ j1+ " y "+ j2+ ") ");
                sj1 = Convert.ToInt32(Console.ReadLine());
                sj2 = Convert.ToInt32(Console.ReadLine());

                if (sj1 > sj2)
                {
                    setwinj1 += setwinj2;
                }
                else
                {
                    setwinj2 += setwinj1;
                }
            }
            if (setwinj1 > setwinj2)
            {
                Console.WriteLine("El ganador es: " + j1);
            }
            else
            {
                Console.WriteLine("El ganador es: " + j2);
            }
        }
    }
}
