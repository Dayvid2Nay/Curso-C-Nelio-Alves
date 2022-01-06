using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1_Estrutura_Sequencial
{
    public class Exercicio02
    {
        static void Main(string[] args)
        {
            double pi, raio;
            pi = 3.14159;
            raio = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("A = " + (pi * Math.Pow(raio,2)).ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
