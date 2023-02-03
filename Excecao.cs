using System;

namespace Projeto
{

    class Excecao
    {
        public static void Aplication()
        {
            Console.Clear();

            var arr = new int[3];

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                cadastrar("teste");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Não encontrado o index no array");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Falha ao cadastrar o texto! " + ex.Message);
            }
            catch (MinhaException ex)
            {
                Console.WriteLine("Erro ocorreu em: " + ex.QuandoAconteceu);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Sempre vai ser executado!");
            }

        }

        static void cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentNullException("String não pode ser nula ou vazia");
            }
            else
            {
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { get; set; }
        }
    }


}