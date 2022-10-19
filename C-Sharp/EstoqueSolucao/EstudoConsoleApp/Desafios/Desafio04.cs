using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio04
    {
        public static void Executar()
        {
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            int dobro = num * 2;
            int triplo = num * 3;
            double raiz = Math.Sqrt((double)num);
            Console.WriteLine();
            Console.WriteLine($" O seu dobro é: {dobro}");
            Console.WriteLine($" O seu triplo é: {triplo}");
            Console.WriteLine($" E a sua raiz vale: {raiz}");
        }
    }
}
