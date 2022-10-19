using System;
using System.Collections.Generic;
using System.Globalization;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio11
    {
        public static void Executar()
        {
            Console.WriteLine("Informe seu salário atual (SEM PONTOS OU VIRGULAS): ");
            double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Aumento = Salario + Salario * 0.15;
            Console.WriteLine("Seu novo salário é: " + Aumento);
        }
    }
}
