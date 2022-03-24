using System;

namespace PeriodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual = DateTime.Now;


            Console.WriteLine(" Digite a data:");
            DateTime dataRecebida = DateTime.Parse(Console.ReadLine());

            TimeSpan dataResultado = (dataAtual.Date - dataRecebida.Date);

            // aparece o periodo de tempo em dia, mês e ano 
            Console.WriteLine("Dias :" + dataResultado.Days );
            Console.WriteLine("Meses :" + dataResultado.Days / 30 );
            Console.WriteLine("Anos :" + dataResultado.Days / 30 /12);            




        }
    }
}
