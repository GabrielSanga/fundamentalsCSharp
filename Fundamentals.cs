using System;

namespace Projeto
{
    class Fundamentals
    {
        static void BuiltInType()
        {
            //-------------------------------------- Types primitivos
            byte meuByte = 127;

            const int IDADE = 1;

            char caracter = 'S';

            string cadeiaCaracter = "Texto";

            //inteiros
            short menorInteiro = 1;
            int medioInteiro = 10;
            long maiorInteiro = 100;

            //reais
            float menorReal = 1.0f;
            double medioReal = 1.500;
            decimal maiorReal = 25.000m;

            bool tipoBoleano = false;

            var assumiTipoString = "Teste";
            var assumiTipoInt = 12;

            object nome = "teste";
            nome = 12.5;

            //O ? expecifica que o type dessa variavel pode ser nullable, em alguns types o nullable não é permitido por padrão
            int? idade = null;

            //Todo tipo built-in já possui um valor padrão, por isso não precisa se preocupar se a variavel é null

            //------------------------------------------ Conversão de dados
            //Implicita (Cast)
            float pontoFlutuante = 30.4f;
            int vlrInteiro = 30;

            pontoFlutuante = vlrInteiro;

            //Explicita (Cast)
            vlrInteiro = (int)pontoFlutuante;

            //Parse
            vlrInteiro = int.Parse(pontoFlutuante.ToString());

            //Convert
            vlrInteiro = Convert.ToInt32(pontoFlutuante);

            //------------------------------------------ Value Types And References Types
            //Valur Type
            var valor1 = 10;
            var valor2 = valor1;

            valor1 = 20;
            //A veriavel valor2 manteve o mesmo valor, pois foi criada um cópia desse valor

            //References Type
            var array = new string[2];
            array[0] = "teste";

            var array2 = array;

            array[0] = "alterado";
            //Ambos as variaveis tiveram seu valor alterado, pois possuiam apenas a referencia em memoria

            //------------------------------------------ Structs

            Product mouse = new Product(1, "Razer", 10.00, EProductType.Product);

            Console.WriteLine("Hello World!");
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double priceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }

}