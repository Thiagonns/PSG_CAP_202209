using System;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio08
    {
        public static void Executar()
        {
            Console.Write("Quantos reais você possui?: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Você pode comprar {0} dólares.", valor / 5.0);
        }
    }
}
