using System;

namespace Projeto
{
    class Calculator
    {
        public static void Aplication()
        {
            Menu();
        }

        static void Menu()
        {

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("Selecione uma opção:");
            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;

                default: Console.WriteLine("Opção Inválida"); break;
            }

            Menu();

            Console.ReadKey();
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Soma: " + (v1 + v2));
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Subtração: " + (v1 - v2));
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Divisão: " + (v1 / v2));
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Multiplicação: " + (v1 * v2));
        }
    }

}
