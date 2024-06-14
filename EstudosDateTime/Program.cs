using System;
using System.Globalization;

namespace EstudosDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime h1 = DateTime.Parse("2000-08-15 13:05:58"); //formatação padrão local
            DateTime h2 = DateTime.Parse("2000-08-15T13:05:58Z"); //formatação ISO ja com horario UTC

            Console.WriteLine(h1); //manteve o local
            Console.WriteLine(h1.Kind); //não é especificada, não é o adequado
            Console.WriteLine(h1.ToLocalTime());//por não ser kind especificado ele subtrai 3
            Console.WriteLine(h1.ToUniversalTime());//por não ser kind especificado ele adiciona 3
            Console.WriteLine();
            Console.WriteLine(h2);//feito no formato ISO
            Console.WriteLine(h2.Kind); //ja considera como local, pois com ISO ele ja recebe 3 hrs
            Console.WriteLine(h2.ToLocalTime()); //por ser considerado ISO +3 horas, quando convertida para local ele subtrai 3
            Console.WriteLine(h2.ToUniversalTime());//por ser considerada ISO +3, ele entende que aquela é o horario certo
            Console.WriteLine();
            Console.WriteLine(h2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); //sempre passe ToUniversalTime() quando retornar em string
            


            Console.WriteLine();
            Console.WriteLine("------------------------------");

            DateTime k1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local); //instanciando uma data como se fosse no meu horario local, porem não muda, pois o C# entende que sua intancia é como quer

            DateTime k2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc); //instanciando para o horario utc

            DateTime k3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine(k1);
            Console.WriteLine(k1.Kind); //mostra qual o tipo de horario que está sendo usado
            Console.WriteLine(k1.ToLocalTime());//desta forma utiliza o horario local ou instanciado
            Console.WriteLine(k1.ToUniversalTime()); //desta forma ele utiliza o horario utc
            Console.WriteLine();
            Console.WriteLine(k2);
            Console.WriteLine(k2.Kind); //mostra qual o tipo de horario que está sendo usado
            Console.WriteLine(k2.ToLocalTime());//desta forma utiliza o horario local ou instanciado, como em k2 era utc, ele volta 3 horas
            Console.WriteLine(k2.ToUniversalTime()); //desta forma ele utiliza o horario utc, por k2 ja ser utc, ele apenas mantem 
            Console.WriteLine();
            Console.WriteLine(k3);
            Console.WriteLine(k3.Kind); //mostra qual o tipo de horario que está sendo usado, neste caso não esta sendo especificada, neste caso, no local ele subtrai 3 e no utc acrescenta 3
            Console.WriteLine(k3.ToLocalTime());//desta forma utiliza o horario local ou instanciado, por k3 não ser especifico ele subtrai 3
            Console.WriteLine(k3.ToUniversalTime()); //desta forma ele utiliza o horario utc, por k3 não ser especificado ele acrescenta 3


            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

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
