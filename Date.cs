using System;
using System.Globalization;

namespace Projeto
{
    class Date
    {

        public static void Aplication()
        {
            Console.Clear();

            //Criando uma nova estrutura de data com os valores padrão
            var novaData = new DateTime();

            //Carregando a data atual
            var data = DateTime.Now;

            var dataCarregada = new DateTime(2023, 01, 17, 8, 23, 13);

            Console.WriteLine(dataCarregada);
            Console.WriteLine(dataCarregada.Year);
            Console.WriteLine(dataCarregada.Month);
            Console.WriteLine(dataCarregada.Day);
            Console.WriteLine(dataCarregada.Hour);
            Console.WriteLine(dataCarregada.Minute);

            // Year = y | Month = M | Day = d
            var dtaFormatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            Console.WriteLine(dtaFormatada);

            //Formatações padrãos
            dtaFormatada = String.Format("{0:r}", data);
            dtaFormatada = String.Format("{0:s}", data);
            dtaFormatada = String.Format("{0:u}", data);

            //Acrescentando dias, mês e ano na data | OBS: NÃO MODIFICA A DATA APENAS IMPRIME COMO SERIA A DATA
            data.AddDays(-12);
            data.AddMonths(1);
            data.AddYears(1);

            // Formatação com culturas
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var cultureAtual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("d", br));

            //Data e horal global, sem aplicar os ajustes de timezone
            var dateTimeGlobal = DateTime.UtcNow;

            //Carregando o timezone da Australia
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            //Aplicando esse timezone na data e hora global para recuperar a data e hora referentes a esse timezone
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTimeGlobal, timezoneAustralia);

            //Convertendo a data e hora que possui o timezone da australia para data e hora global
            var horaAtual = TimeZoneInfo.ConvertTimeToUtc(horaAustralia, timezoneAustralia);


            //---------------Timestan -- componente muito pratico para trabalhar com horários de maneira precisa
            var timeSpan = new TimeSpan();

            //Quantos dias tem no mes ?
            DateTime.DaysInMonth(2023, 2);

            //Final de semana ou não ?
            //Função que retorne se o DayOfWeek é Saturday ou Sunday
        }

    }

}
