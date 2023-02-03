using System;
using System.Globalization;

namespace Projeto
{

    class Moeda
    {
        public static void Aplication()
        {
            Console.Clear();

            decimal valor = 10322.95m;

            //Formats de número: C, E04, G, F, N, P
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

            //Math é uma classe matematica

            //Arredendo valores
            Console.WriteLine(Math.Round(valor));

            //Arredendo valores para cima
            Console.WriteLine(Math.Ceiling(valor));

            //Arredendo valores para baixo
            Console.WriteLine(Math.Floor(valor));
        }
    }


}