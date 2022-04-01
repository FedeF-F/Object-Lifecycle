//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {

            while(Train.count < 100){
                var train = new Train($"{Train.count}");
            }
            Console.WriteLine($"{Train.count}");

            Train t1 = new Train("Last Train Home");
            Train t2 = new Train("Last Train Home");
            Train t3 = new Train("Runaway Train");

            Console.WriteLine($"{t1.Equals(t2)}");
            Console.WriteLine($"{t3.Equals(t2)}");
            Console.WriteLine($"{t1.Equals(t3)}");




        }
    }
}