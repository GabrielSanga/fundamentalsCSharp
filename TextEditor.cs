using System;
using System.IO;

namespace Projeto
{
    class TextEditor
    {

        public static void Aplication()
        {
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oque deseja fazer ?");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - Criar/Editar Arquivo");
            Console.WriteLine("0 - Sair");
            int result = int.Parse(Console.ReadLine());

            switch (result)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Criar(); break;
            }
        }

        private static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            string text = "";

            using (var file = new StreamReader(path))
            {
                text = file.ReadToEnd();
            }

            Console.WriteLine(text);

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        private static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (ESC) para sair");
            Console.WriteLine("--------------------------");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        private static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo ?");
            string path = Console.ReadLine();

            using (var file = new StreamWriter(path)) //o USING é reponsavel por criar e fechar o objeto referido
            {
                file.Write(text);
            }

            Console.WriteLine("Arquivo salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }

    }

}
