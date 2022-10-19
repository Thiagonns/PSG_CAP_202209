using System;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio09
    {
        public static void Executar()
        {
            Console.Write("Informe a largura da parede: ");
            double largura = Double.Parse(Console.ReadLine());
            Console.Write("Informe a altura da parede: ");
            double altura = Double.Parse(Console.ReadLine());
            double area = (largura * altura);
            Console.WriteLine($"Para uma área de {area} metros quadrados, serão utilizados {(area / 2)} litros de tinta.");
        }
    }
}
