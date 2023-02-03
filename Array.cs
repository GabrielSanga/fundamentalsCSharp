using System;
using System.Globalization;

namespace Projeto
{

    class Array
    {
        public static void Aplication()
        {
            Console.Clear();

            //Formas de declarar Array
            var meuArray = new int[10];
            string[] meuArrayNovo = new string[10];

            meuArray[0] = 12;

            Console.WriteLine(meuArray[0]);

            //Inicializando arrays com valores
            var meuArrayComValor = new int[5] { 1, 2, 3, 6, 5 };

            Console.WriteLine(meuArrayComValor[0]);

            for (var i = 0; i < meuArrayComValor.Length; i++)
            {
                Console.WriteLine(meuArrayComValor[i]);
            }

            foreach (var item in meuArrayComValor)
            {
                Console.WriteLine(item);
            }
        }
    }


}