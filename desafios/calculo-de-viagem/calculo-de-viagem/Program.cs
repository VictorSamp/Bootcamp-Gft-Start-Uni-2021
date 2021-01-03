using System;
using System.Globalization;

namespace calculo_de_viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            int tempoGasto, velocidadeMedia;
            double totalLitros;

            input = Console.ReadLine().Split(" ");
            tempoGasto = int.Parse(input[0]);
            velocidadeMedia = int.Parse(input[1]);

            totalLitros = tempoGasto * velocidadeMedia / 12.00;

            Console.WriteLine(totalLitros.ToString("N3", CultureInfo.InvariantCulture));
        }
    }
}
