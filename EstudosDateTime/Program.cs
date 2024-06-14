using System;
using System.Globalization;

namespace EstudosDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 11, 25); //instancia de um DateTime Ano, Mes, Dia
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 03); //instancia de um DateTime Ano, Mes, Dia, minuto, segundo
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500);//instancia de um DateTime Ano, Mes, Dia, minuto, segundo, milissegundo, porem neste formato não leva em consideração os milissegundos

            DateTime d4 = DateTime.Now; //mostrar a data de hoje e hora local de agora
            DateTime d5 = DateTime.Today;//mostra a data de hoje sem hora
            DateTime d6 = DateTime.UtcNow;//horario de agora porem em GMT+3 universal 

            DateTime c1 = DateTime.Parse("2001-12-27"); //ano, mes, dia, formatação usada em banco de dados, formatando com -
            DateTime c2 = DateTime.Parse("2001-12-27 13:05:08");//ano, mes, dia, hora, minuto, segundo

            DateTime c3 = DateTime.Parse("15/12/2000");//ano, mes, dia, formatação usada em banco de dados, outro meio de formatar porem com /
            DateTime c4 = DateTime.Parse("15/12/2000 14:06:09");//ano, mes, dia, hora, minuto, segundo 

            DateTime b1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); //formatação para o sistema entender
            DateTime b2 = DateTime.ParseExact("15/08/2000 13:05:08", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
