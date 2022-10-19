using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoConsoleApp.Desafios
{
    public static class Desafio05
    {
        public static void Executar()
        {
            Console.Write("Informe a primeira nota: ");
            double n1 = Double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota: ");
            double n2 = Double.Parse(Console.ReadLine());

            double media = (n1 + n2) / 2;

            Console.WriteLine($"A média das notas informadas é: {media}");
        }
    }
}
