using System;
using System.Globalization;

namespace Exercicio05
{
    public class Program
    {
        static void Main(string[] args)
        {
            int qtd = 2;
            int[] codProd = new int[qtd], quatProd = new int[qtd];
            double[] valor = new double[qtd];
            double valorTotal=0;
            for (var i = 0; i < 2; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                codProd[i] = int.Parse(values[0]);
                quatProd[i] = int.Parse(values[1]);
                valor[i] = double.Parse(values[2],CultureInfo.InvariantCulture);
                valorTotal += valor[i] * quatProd[i];
            }

            Console.WriteLine("VALOR A PAGAR: R$ "+(valorTotal.ToString("F2",CultureInfo.InvariantCulture)));
        }
    }
}
