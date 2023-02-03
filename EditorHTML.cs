using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Projeto
{
    class EditorHTML
    {

        public static void Aplication()
        {
            Show();
        }

        private static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();

            WriteOption();

            int option = int.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        private static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");

            Console.Write("\n");

            for (int i = 0; i <= 10; i++)
            {
                Console.Write("|");
                for (int j = 0; j <= 30; j++)
                    Console.Write(" ");
                Console.Write("|");

                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");
            Console.Write("+");
        }

        private static void WriteOption()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");

            Console.SetCursorPosition(3, 3);
            Console.WriteLine("---------------------");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção:");

            Console.SetCursorPosition(3, 5);
            Console.WriteLine("1 - Novo Arquivo");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("2 - Abrir");

            Console.SetCursorPosition(3, 7);
            Console.WriteLine("0 - Sair");

        }

        private static void HandleMenuOption(int option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }

    class Editor
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.WriteLine("Modo Editor");
            Console.WriteLine("---------------");

            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("---------------");
            Console.WriteLine("Deseja salvar o arquivo ?");

            Viewer.show(file.ToString());
        }

    }

    class Viewer
    {
        public static void show(string text)
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.WriteLine("Modo Visualização");
            Console.WriteLine("---------------");
            Replace(text);
            Console.WriteLine("---------------");

            Console.ReadKey();
            EditorHTML.Aplication();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[i].Substring(words[i].IndexOf('>') + 1, ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))));
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }

    }
}
