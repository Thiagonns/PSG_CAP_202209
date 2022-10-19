using System;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio06
    {
        public static void Executar()
        {
            Console.Write("Informe o número em metros: ");
            double numero = Double.Parse(Console.ReadLine());
            double cent = numero * 100;
            double milim = numero * 1000;
            Console.WriteLine($"{numero} metros correspondem a {cent} centimetros.");
            Console.WriteLine($"{numero} metros correspondem a {milim} milimetros.");
        }
    }
}
