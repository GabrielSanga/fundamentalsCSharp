using System;
using System.Text;

namespace Projeto
{
    class Strings
    {

        public static void Aplication()
        {
            //---------------------------- Guid
            var id = Guid.NewGuid();

            //---------------------------- Interpolação de String
            var price = 10.2;

            var text1 = "O preço do produto é: " + price + "somente na promoção!";

            var text2 = String.Format("O preço do produto é {0} sómente na promoção!", price);

            var text3 = $@"O preço do produto é {price} somente na promoção";

            //---------------------------- Comparação de String

            text1.CompareTo(text2);

            text1.Contains(text2, StringComparison.OrdinalIgnoreCase);

            text1.StartsWith("O Preço");
            text1.EndsWith("na promoção");

            text1.Equals("O preço do produto é 20 somente na promoção!");

            //---------------------------- Manipulação de String

            text1.IndexOf("preço");
            text1.LastIndexOf("preço");

            text1.ToLower();
            text1.ToUpper();

            text1.Insert(5, "Teste");
            text1.Remove(5, 5);

            text1.Replace("preço", "valor");

            text1.Split(" ");

            text1.Substring(5, 5);

            text1.Trim();

            var texto = new StringBuilder();
            texto.Append("Teste 1");
            texto.Append("Concatenando");
        }

    }

}
