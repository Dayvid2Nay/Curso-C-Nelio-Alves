using System;
using System.Globalization;

namespace Exercicio04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int codFunc, horasTrab;
            double salario;
            codFunc = int.Parse(Console.ReadLine());
            horasTrab = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NUMBER = "+codFunc);
            Console.WriteLine("SALARY = U$ "+(horasTrab*salario).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
