using System;
using System.Globalization;

namespace EstudosDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime q = new DateTime(2001, 8, 15, 14, 45, 58, 275);

            DateTime q2 = q.AddHours(2);//adicionando horas
            DateTime q3 = q.AddMinutes(3);//adicionando minutos
            DateTime q4 = q.AddDays(7);//adicionando dias

            Console.WriteLine(q);
            Console.WriteLine(q2);
            Console.WriteLine(q3);
            Console.WriteLine(q4);

            Console.WriteLine();
            Console.WriteLine("---------------------------------");

            DateTime d = new DateTime(2001, 8, 15, 14, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine(d.Date); //apenas a data
            Console.WriteLine(d.Day); //apenas o dia
            Console.WriteLine(d.DayOfWeek);//dia da semana 
            Console.WriteLine(d.DayOfYear);//dias no ano
            Console.WriteLine(d.Hour); //apenas a hora
            Console.WriteLine(d.Kind);//local ou univesal
            Console.WriteLine(d.Millisecond); //apenas o milissegundo
            Console.WriteLine(d.Minute); //apenas o minuto
            Console.WriteLine(d.Month); //apenas o mes
            Console.WriteLine(d.Second); //apenas o segundo
            Console.WriteLine(d.Ticks); //os ticks
            Console.WriteLine(d.TimeOfDay); ///horario do dia
            Console.WriteLine(d.Year); //apenas o ano
            Console.WriteLine("---------------------------------");

            Console.WriteLine(d.ToLongDateString());//uma forma "maior" de escrever a data 
            Console.WriteLine(d.ToLongTimeString());//imprime o horario
            Console.WriteLine(d.ToShortDateString());//uma forma resumida para mostrar a data
            Console.WriteLine(d.ToShortTimeString());//apenas hora e minuto
            Console.WriteLine(d.ToString());//formato data e horario
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));//formatação manual da data
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));//formatação manual com milissegundos


            Console.WriteLine();
            Console.WriteLine("--------------------------------");


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
